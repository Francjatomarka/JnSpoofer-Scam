namespace JnSpoofer
{
	// Token: 0x02000013 RID: 19
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000079DC File Offset: 0x00005BDC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00007A0C File Offset: 0x00005C0C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::JnSpoofer.Form1));
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.userControl21 = new global::Loader.UserControl2();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			base.SuspendLayout();
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.panel2.Controls.Add(this.expiry);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.siticoneControlBox2);
			this.panel2.Controls.Add(this.siticoneControlBox1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new global::System.Drawing.Point(-5, -35);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(592, 526);
			this.panel2.TabIndex = 18;
			this.panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new global::System.Drawing.Point(17, 452);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(27, 18);
			this.label3.TabIndex = 55;
			this.label3.Text = "v.1";
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.label6.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label6.Location = new global::System.Drawing.Point(17, 487);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(135, 14);
			this.label6.TabIndex = 57;
			this.label6.Text = "Last update : 23/06/2022";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Comic Sans MS", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new global::System.Drawing.Point(208, 465);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(171, 30);
			this.label4.TabIndex = 56;
			this.label4.Text = "Please Wait....";
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(476, 44);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 32);
			this.siticoneControlBox2.TabIndex = 56;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(521, 44);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 32);
			this.siticoneControlBox1.TabIndex = 55;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new global::System.Drawing.Point(17, 44);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(153, 18);
			this.label1.TabIndex = 54;
			this.label1.Text = "FiveM Spoofer Page";
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button5.ForeColor = global::System.Drawing.SystemColors.Window;
			this.button5.Location = new global::System.Drawing.Point(300, 144);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(238, 36);
			this.button5.TabIndex = 53;
			this.button5.Text = "Unban all server";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.SystemColors.Window;
			this.button4.Location = new global::System.Drawing.Point(95, 201);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(383, 36);
			this.button4.TabIndex = 52;
			this.button4.Text = "Buy Rockstar account";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Arial", 36f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new global::System.Drawing.Point(214, 64);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(143, 55);
			this.label2.TabIndex = 51;
			this.label2.Text = "ғᴏʀsᴀ";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.button1.Location = new global::System.Drawing.Point(40, 144);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(238, 36);
			this.button1.TabIndex = 47;
			this.button1.Text = "Unban global FiveM";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.pictureBox4.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.pictureBox4.Image = global::JnSpoofer.Properties.Resources.icons8_discord_new_100;
			this.pictureBox4.Location = new global::System.Drawing.Point(521, 415);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(45, 45);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 48;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new global::System.EventHandler(this.pictureBox4_Click_1);
			this.userControl21.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.userControl21.Location = new global::System.Drawing.Point(60, 437);
			this.userControl21.Name = "userControl21";
			this.userControl21.Size = new global::System.Drawing.Size(506, 415);
			this.userControl21.TabIndex = 2;
			this.expiry.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(20, 471);
			this.expiry.Margin = new global::System.Windows.Forms.Padding(2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(65, 17);
			this.expiry.TabIndex = 60;
			this.expiry.Text = "Expiration : ";
			this.expiry.Click += new global::System.EventHandler(this.expiry_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(578, 472);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.userControl21);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "ForsaSpoofer";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000076 RID: 118
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000080 RID: 128
		private global::Loader.UserControl2 userControl21;

		// Token: 0x04000081 RID: 129
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000082 RID: 130
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000084 RID: 132
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;
	}
}
