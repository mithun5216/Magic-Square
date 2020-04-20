/*
 * Created by SharpDevelop.
 * User: ROMAN
 * Date: 23-11-2017
 * Time: 14:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace demo
{
	partial class devdet
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel developer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(devdet));
			this.developer = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.developer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// developer
			// 
			this.developer.Controls.Add(this.pictureBox1);
			this.developer.Controls.Add(this.label4);
			this.developer.Controls.Add(this.label3);
			this.developer.Controls.Add(this.label2);
			this.developer.Controls.Add(this.label1);
			this.developer.Location = new System.Drawing.Point(74, 12);
			this.developer.Name = "developer";
			this.developer.Size = new System.Drawing.Size(441, 479);
			this.developer.TabIndex = 8;
			this.developer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(261, 88);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(164, 241);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(226, 420);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(212, 42);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mobile.no:9677335808\r\nmail id:mithun5216@gmail.com";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(309, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(236, 394);
			this.label2.TabIndex = 1;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(72, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(287, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Developer Details";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// devdet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 504);
			this.Controls.Add(this.developer);
			this.Name = "devdet";
			this.Text = "devdet";
			this.developer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
