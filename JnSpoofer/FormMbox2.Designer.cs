namespace JnSpoofer
{
	// Token: 0x02000015 RID: 21
	public partial class FormMbox2 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00008A94 File Offset: 0x00006C94
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00008AC4 File Offset: 0x00006CC4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::JnSpoofer.FormMbox2));
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new global::System.Drawing.Point(161, 228);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(292, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "UNBAN SERVERS SUCCESSFULLY";
			this.button1.BackColor = global::System.Drawing.Color.SkyBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(126, 104);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(134, 55);
			this.button1.TabIndex = 2;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.siticoneControlBox2);
			this.panel2.Controls.Add(this.siticoneControlBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new global::System.Drawing.Point(-105, -163);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(496, 370);
			this.panel2.TabIndex = 19;
			this.panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
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
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(380, 44);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 32);
			this.siticoneControlBox2.TabIndex = 56;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(425, 44);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 32);
			this.siticoneControlBox1.TabIndex = 55;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new global::System.Drawing.Point(17, 44);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(153, 18);
			this.label2.TabIndex = 54;
			this.label2.Text = "FiveM Spoofer Page";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			base.ClientSize = new global::System.Drawing.Size(387, 188);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel2);
			this.ForeColor = global::System.Drawing.SystemColors.Control;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormMbox2";
			this.Text = "ForsaSpoofer";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400008E RID: 142
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000093 RID: 147
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000094 RID: 148
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Label label2;
	}
}
