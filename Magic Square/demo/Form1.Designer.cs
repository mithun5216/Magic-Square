/*
 * Created by SharpDevelop.
 * User: ROMAN
 * Date: 22-11-2017
 * Time: 15:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace demo
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel instruction;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		
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
			this.instruction = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.instruction.SuspendLayout();
			this.SuspendLayout();
			// 
			// instruction
			// 
			this.instruction.Controls.Add(this.label11);
			this.instruction.Controls.Add(this.label10);
			this.instruction.Controls.Add(this.label9);
			this.instruction.Controls.Add(this.label8);
			this.instruction.Controls.Add(this.label7);
			this.instruction.Controls.Add(this.label6);
			this.instruction.Controls.Add(this.label5);
			this.instruction.Controls.Add(this.label4);
			this.instruction.Controls.Add(this.label3);
			this.instruction.Controls.Add(this.label2);
			this.instruction.Controls.Add(this.label1);
			this.instruction.Location = new System.Drawing.Point(63, 12);
			this.instruction.Name = "instruction";
			this.instruction.Size = new System.Drawing.Size(441, 479);
			this.instruction.TabIndex = 8;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(43, 370);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(374, 48);
			this.label11.TabIndex = 10;
			this.label11.Text = "The buttons can be continuously clicked for \r\nincrementing the number values. ";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label10.Location = new System.Drawing.Point(15, 370);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(22, 27);
			this.label10.TabIndex = 9;
			this.label10.Text = "*";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(43, 301);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(374, 48);
			this.label9.TabIndex = 8;
			this.label9.Text = "The puzzle logic clearly shows the logic in which the \r\nnumbers can be placed.";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(43, 237);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(374, 32);
			this.label8.TabIndex = 7;
			this.label8.Text = "You can use hints for a clue about the puzzle.";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(43, 165);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(374, 48);
			this.label7.TabIndex = 6;
			this.label7.Text = "Unique values are only allowed.Repetition of values\r\n are not entertained.";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label6.Location = new System.Drawing.Point(15, 301);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 27);
			this.label6.TabIndex = 5;
			this.label6.Text = "*";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(15, 237);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 27);
			this.label5.TabIndex = 4;
			this.label5.Text = "*";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label4.Location = new System.Drawing.Point(15, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "*";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(43, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(374, 48);
			this.label3.TabIndex = 2;
			this.label3.Text = "The puzzle is to check equal sum in rows,columns as well as diagonals.";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(15, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "*";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(74, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Instructions";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 510);
			this.Controls.Add(this.instruction);
			this.Name = "Form1";
			this.Text = "Form1";
			this.instruction.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
