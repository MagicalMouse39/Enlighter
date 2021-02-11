using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnlighterRemote
{
    class EnlighterUI : Form
    {
        private Label ipLabel, macLabel;
        private Button onBtn, offBtn, closeBtn;
        private TextBox ipInput, macInput;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MouseDownHandler(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SendMagicPacket(string ip, string mac)
        {
            if (ip == string.Empty)
                ip = "255.255.255.255";

            if (mac.Length == 17)
            {
                char s = mac[2];
                mac = mac.Replace(s.ToString(), "");
            }

            string tmpMac = string.Empty;
            for (int i = 0; i < 16; i++)
                tmpMac += mac;

            string sPacket = "FFFFFFFFFFFF" + tmpMac;

            byte[] packet = Enumerable.Range(0, sPacket.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(sPacket.Substring(x, 2), 16))
                .ToArray();

            UdpClient socket = new UdpClient();
            socket.Send(packet, packet.Length, ip, 9);
            socket.Close();
        }

        private void SendGoodbyePacket(string ip)
        {
            TcpClient client = new TcpClient();
            client.Connect(ip, 39390);
            byte[] buffer = Encoding.UTF8.GetBytes("shutdown");
            client.GetStream().Write(buffer, 0, buffer.Length);
            client.Close();
        }

        public EnlighterUI()
        {
            this.Width = 300;
            this.Height = 350;

            this.ipLabel = new Label() { Left = 10, Top = 30, Text = "IP", Height = 50, BackColor = Color.Transparent, Width = this.Width - 20, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 32, FontStyle.Regular) };
            this.macLabel = new Label() { Left = 10, Top = 140, Text = "MAC", Height = 50, BackColor = Color.Transparent, Width = this.Width - 20, TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Arial", 32, FontStyle.Regular) };

            this.ipInput = new TextBox() { Left = 10, Top = 80, Width = 280, Text = "255.255.255.255", Font = new Font("Arial", 18, FontStyle.Regular) };
            this.macInput = new TextBox() { Left = 10, Top = 200, Width = 280, Text = "FF:FF:FF:FF:FF:FF", Font = new Font("Arial", 18, FontStyle.Regular) };

            this.closeBtn = new Button() { Left = this.Width - 30, Top = 10, Width = 20, Height = 20, Text = "X", FlatStyle = FlatStyle.Flat, ForeColor = Color.Red };
            this.closeBtn.Click += (s, e) => this.Close();

            this.onBtn = new Button() { Left = 10, Top = 250, Height = 85, Width = this.Width / 2 - 40, BackgroundImage = Resources.ON, BackgroundImageLayout = ImageLayout.Stretch };
            this.onBtn.Click += (s, e) => SendMagicPacket(this.ipInput.Text.Trim(), this.macInput.Text.Trim());
            this.offBtn = new Button() { Left = this.Width / 2 + 30, Height = 85, Top = 250, Width = this.Width / 2 - 40, BackgroundImage = Resources.OFF, BackgroundImageLayout = ImageLayout.Stretch };
            this.offBtn.Click += (s, e) => SendGoodbyePacket(this.ipInput.Text.Trim());

            //Se premi esc, closeBtn viene premuto
            this.CancelButton = this.closeBtn;
            //Se premi invio, onBtn viene premuto
            this.AcceptButton = this.onBtn;

            //Setto border a none e inserisco utility per trascinare il form
            this.FormBorderStyle = FormBorderStyle.None;

            this.MouseDown += (s, e) => this.MouseDownHandler(e);
            this.ipLabel.MouseDown += (s, e) => this.MouseDownHandler(e);
            this.macLabel.MouseDown += (s, e) => this.MouseDownHandler(e);

            //Aggiungo i controlli al form
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.macLabel);
            this.Controls.Add(this.ipInput);
            this.Controls.Add(this.macInput);
            this.Controls.Add(this.onBtn);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.closeBtn);
        }
    }
}
