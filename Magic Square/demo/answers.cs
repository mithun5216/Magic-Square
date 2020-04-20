/*
 * Created by SharpDevelop.
 * User: ROMAN
 * Date: 01-03-2018
 * Time: 14:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace demo
{
	/// <summary>
	/// Description of answers.
	/// </summary>
	public partial class answers : Form
	{
		int  rowCount;
	 	int  columnCount;
		public answers()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			drapdown.SelectedIndex = 0;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void DrapdownSelectedIndexChanged(object sender, EventArgs e)
		{
			string selected_value = drapdown.SelectedItem.ToString();
			string sub = selected_value.Substring(0,1);
			//b.Text="1";
			//MessageBox.Show(sub);
			rowCount = Convert.ToInt32(sub);
			columnCount = Convert.ToInt32(sub);
			
			generate1(rowCount,columnCount);
		}
		public void generate1(int rc, int cc){
			// this.tableLayoutPanel1.Controls.Clear;
			tableLayoutPanel1.Controls.Clear();
			this.tableLayoutPanel1.ColumnCount = rc;
		    this.tableLayoutPanel1.RowCount = cc;
		
		    this.tableLayoutPanel1.ColumnStyles.Clear();
		    this.tableLayoutPanel1.RowStyles.Clear();
		   // this.tableLayoutPanel1
			
		    for (int i = 0; i < columnCount; i++)
		    {
		        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));
		    }
		    for (int i = 0; i < rowCount; i++)
		    {
		        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
		    }
		
		    
			int[] array = new int[]{8,1,6,3,5,7,4,9,2};
			int[] array1 = new int[]{1,15,14,4,12,6,7,9,8,10,11,5,13,2,3,16};
			int[] array2 = new int[]{17,24,1,8,15,23,5,7,14,16,4,6,13,20,22,10,12,19,21,3,11,18,25,2,9};
			int[] array3 = new int[]{1,2,34,33,5,6,7,29,9,10,26,12,24,14,15,16,17,19,18,20,21,22,23,13,25,11,27,28,8,30,31,32,4,3,35,36};
		    //static Padding _padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
		    for (int i = 0; i < rowCount* columnCount; i++)
		    {
			 	Button b = new Button();
		        //if(b.Text!="0")
		        if(rowCount == 3){
		        	b.Text = array[i].ToString();
		        }else if(rowCount == 4){
		        	b.Text = array1[i].ToString();
		        }else if(rowCount == 5){
		        	b.Text = array2[i].ToString();
		        }else if(rowCount == 6){
		        	b.Text = array3[i].ToString();
		        }
		        //MessageBox.Show(b.Text.ToString());
		       // b.Height = 10;
		       //b.Width = 50;
		        b.Name = string.Format("b_{0}", i + 1);
		        b.Dock = DockStyle.Fill;
		        this.tableLayoutPanel1.Controls.Add(b);
		        //MessageBox.Show(b.Name);
		        
		    }
		}
		void AnswersLoad(object sender, EventArgs e)
		{
	
		}
	}
}
