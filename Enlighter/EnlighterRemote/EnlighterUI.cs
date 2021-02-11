using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnlighterRemote
{
    class EnlighterUI : Form
    {
        private EnlightmentUtils utils;
        private Label label1;
        private Label label3;
        private TextBox InputMAC;
        private Button BtnON;
        private Button BtnOFF;
        private TextBox InputIP;

        public EnlighterUI()
        {
            this.InitializeComponent();

            this.BtnON.Click += (s, e) =>
                utils.SendMagicPacket(InputIP.Text, InputMAC.Text);
            this.BtnOFF.Click += (s, e) =>
                utils.SendGoodbyePacket(InputIP.Text);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InputIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputMAC = new System.Windows.Forms.TextBox();
            this.BtnON = new System.Windows.Forms.Button();
            this.BtnOFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // InputIP
            // 
            this.InputIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.InputIP.Location = new System.Drawing.Point(44, 96);
            this.InputIP.Name = "InputIP";
            this.InputIP.Size = new System.Drawing.Size(168, 26);
            this.InputIP.TabIndex = 1;
            this.InputIP.Text = "255.255.255.255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label3.Location = new System.Drawing.Point(47, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "MAC:";
            // 
            // InputMAC
            // 
            this.InputMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.InputMAC.Location = new System.Drawing.Point(44, 179);
            this.InputMAC.Name = "InputMAC";
            this.InputMAC.Size = new System.Drawing.Size(168, 26);
            this.InputMAC.TabIndex = 4;
            // 
            // BtnON
            // 
            this.BtnON.BackColor = System.Drawing.Color.Transparent;
            this.BtnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnON.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnON.Location = new System.Drawing.Point(227, 88);
            this.BtnON.Name = "BtnON";
            this.BtnON.Size = new System.Drawing.Size(151, 43);
            this.BtnON.TabIndex = 5;
            this.BtnON.Text = "ACCENDERE";
            this.BtnON.UseVisualStyleBackColor = false;
            // 
            // BtnOFF
            // 
            this.BtnOFF.BackColor = System.Drawing.Color.Transparent;
            this.BtnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnOFF.Location = new System.Drawing.Point(227, 171);
            this.BtnOFF.Name = "BtnOFF";
            this.BtnOFF.Size = new System.Drawing.Size(151, 43);
            this.BtnOFF.TabIndex = 6;
            this.BtnOFF.Text = "SPEGNERE";
            this.BtnOFF.UseVisualStyleBackColor = false;
            // 
            // EnlighterUI
            // 
            this.ClientSize = new System.Drawing.Size(389, 232);
            this.Controls.Add(this.BtnOFF);
            this.Controls.Add(this.BtnON);
            this.Controls.Add(this.InputMAC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputIP);
            this.Controls.Add(this.label1);
            this.Name = "EnlighterUI";
            this.Text = "Enlighter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
