namespace JnSpoofer
{
	// Token: 0x02000016 RID: 22
	public partial class WaitForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CF RID: 207 RVA: 0x000091DC File Offset: 0x000073DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000920C File Offset: 0x0000740C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::JnSpoofer.WaitForm));
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			this.label1.Image = global::JnSpoofer.Properties.Resources.loading_2;
			this.label1.Location = new global::System.Drawing.Point(-23, -9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(544, 348);
			this.label1.TabIndex = 0;
			this.label1.Text = " ";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(27, 27, 27);
			base.ClientSize = new global::System.Drawing.Size(492, 304);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "WaitForm";
			this.Text = "ForsaSpoofer";
			base.ResumeLayout(false);
		}

		// Token: 0x04000096 RID: 150
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Label label1;
	}
}
