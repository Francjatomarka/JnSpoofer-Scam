namespace JnSpoofer
{
	// Token: 0x02000014 RID: 20
	public partial class FormMbox : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x0000865C File Offset: 0x0000685C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000868C File Offset: 0x0000688C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::JnSpoofer.FormMbox));
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new global::System.Drawing.Point(150, 228);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(286, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "UNBAN GLOBAL SUCCESSFULLY";
			this.button1.BackColor = global::System.Drawing.Color.SkyBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(220, 267);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(134, 55);
			this.button1.TabIndex = 1;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new global::System.Drawing.Point(-97, -163);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(486, 369);
			this.panel2.TabIndex = 19;
			this.panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
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
			base.Controls.Add(this.panel2);
			this.ForeColor = global::System.Drawing.SystemColors.Control;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormMbox";
			this.Text = "ForsaSpoofer";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000087 RID: 135
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label label2;
	}
}
