/*
 * Created by SharpDevelop.
 * User: ROMAN
 * Date: 13-03-2018
 * Time: 12:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace demo
{
	partial class hints
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel hintspuzzle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hints));
			this.hintspuzzle = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.hintspuzzle.SuspendLayout();
			this.SuspendLayout();
			// 
			// hintspuzzle
			// 
			this.hintspuzzle.Controls.Add(this.label4);
			this.hintspuzzle.Controls.Add(this.label5);
			this.hintspuzzle.Controls.Add(this.label3);
			this.hintspuzzle.Controls.Add(this.label2);
			this.hintspuzzle.Controls.Add(this.label1);
			this.hintspuzzle.Location = new System.Drawing.Point(48, 8);
			this.hintspuzzle.Name = "hintspuzzle";
			this.hintspuzzle.Size = new System.Drawing.Size(441, 479);
			this.hintspuzzle.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(51, 259);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(367, 197);
			this.label4.TabIndex = 6;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(23, 266);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 27);
			this.label5.TabIndex = 5;
			this.label5.Text = "*";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(47, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(367, 197);
			this.label3.TabIndex = 4;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(19, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "*";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(82, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 43);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hints/Puzzle Logic";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hints
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 499);
			this.Controls.Add(this.hintspuzzle);
			this.Name = "hints";
			this.Text = "hints";
			this.hintspuzzle.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
