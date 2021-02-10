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
		private Label label1;
		private Label label3;
		private TextBox textBox2;
		private Button button1;
		private Button button2;
		private TextBox textBox1;

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
			this.label1.Location = new System.Drawing.Point(47, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ip(Opzionale):";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.textBox1.Location = new System.Drawing.Point(44, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "255.255.255.255";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.textBox2.Location = new System.Drawing.Point(44, 179);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(168, 26);
			this.textBox2.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Location = new System.Drawing.Point(227, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 43);
			this.button1.TabIndex = 5;
			this.button1.Text = "ACCENDERE";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.Location = new System.Drawing.Point(227, 171);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(151, 43);
			this.button2.TabIndex = 6;
			this.button2.Text = "SPEGNERE";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// EnlighterUI
			// 
			this.ClientSize = new System.Drawing.Size(448, 284);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "EnlighterUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
