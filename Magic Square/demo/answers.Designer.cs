/*
 * Created by SharpDevelop.
 * User: ROMAN
 * Date: 01-03-2018
 * Time: 14:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace demo
{
	partial class answers
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel ans;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox drapdown;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		
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
			this.ans = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.drapdown = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ans.SuspendLayout();
			this.SuspendLayout();
			// 
			// ans
			// 
			this.ans.BackColor = System.Drawing.Color.Transparent;
			this.ans.Controls.Add(this.label1);
			this.ans.Controls.Add(this.drapdown);
			this.ans.Controls.Add(this.tableLayoutPanel1);
			this.ans.Location = new System.Drawing.Point(74, 25);
			this.ans.Name = "ans";
			this.ans.Size = new System.Drawing.Size(441, 479);
			this.ans.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(129, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Select your choice here:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// drapdown
			// 
			this.drapdown.FormattingEnabled = true;
			this.drapdown.Items.AddRange(new object[] {
			"3 * 3",
			"4 * 4",
			"5 * 5",
			"6 * 6"});
			this.drapdown.Location = new System.Drawing.Point(314, 32);
			this.drapdown.Name = "drapdown";
			this.drapdown.Size = new System.Drawing.Size(95, 21);
			this.drapdown.TabIndex = 7;
			this.drapdown.SelectedIndexChanged += new System.EventHandler(this.DrapdownSelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 97);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 308);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// answers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 528);
			this.Controls.Add(this.ans);
			this.Name = "answers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "answers";
			this.Load += new System.EventHandler(this.AnswersLoad);
			this.ans.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
