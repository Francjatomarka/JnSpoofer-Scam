using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KeyAuth;
using Siticone.UI.WinForms;

namespace Loader
{
	// Token: 0x02000002 RID: 2
	public class UserControl1 : UserControl
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
		public UserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000251C File Offset: 0x0000071C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		private void label1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002554 File Offset: 0x00000754
		private void expiry_Click(object sender, EventArgs e)
		{
			this.expiry.Text = "Expiration: " + this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000025A4 File Offset: 0x000007A4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025D4 File Offset: 0x000007D4
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UserControl1));
			this.pictureBox2 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.expiry = new SiticoneLabel();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			base.SuspendLayout();
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(388, 318);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(102, 86);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(90, 82);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(282, 74);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.expiry.BackColor = Color.FromArgb(27, 27, 27);
			this.expiry.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.expiry.ForeColor = SystemColors.ButtonHighlight;
			this.expiry.Location = new Point(104, 139);
			this.expiry.Margin = new Padding(2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new Size(65, 17);
			this.expiry.TabIndex = 39;
			this.expiry.Text = "Expiration : ";
			this.expiry.Click += this.expiry_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(27, 27, 27);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.pictureBox2);
			base.Name = "UserControl1";
			base.Size = new Size(504, 419);
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private IContainer components = null;

		// Token: 0x04000002 RID: 2
		private PictureBox pictureBox2;

		// Token: 0x04000003 RID: 3
		private PictureBox pictureBox3;

		// Token: 0x04000004 RID: 4
		private SiticoneLabel expiry;
	}
}
