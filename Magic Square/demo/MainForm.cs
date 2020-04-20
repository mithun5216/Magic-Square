/*
 * Created by SharpDevelop.
 * User: ROMAN
 * Date: 20-11-2017
 * Time: 10:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace demo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int  rowCount;
	 	int  columnCount;
	 	int  w;
	 	int[] rowstot = new int[10];
	 	int[] columnstot = new int[10];
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			drapdown.SelectedIndex = 0;
			
			label3.Hide();
			label4.Hide();
			developer.Hide();
			//ans.Hide();
			play.Show();
			hintspuzzle.Hide();
			instruction.Hide();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void DrapdownSelectedIndexChanged(object sender, EventArgs e)
		{
			//for (int i = tableLayoutPanel1.ColumnCount - 1;i>=0;--i)
			
			//MessageBox.Show(drapdown.SelectedIndex.ToString());
			//if(drapdown.SelectedIndex==0)
			//{
			string selected_value = drapdown.SelectedItem.ToString();
			string sub = selected_value.Substring(0,1);
			//b.Text="1";
			//MessageBox.Show(sub);
			rowCount = Convert.ToInt32(sub);
			columnCount = Convert.ToInt32(sub);
			
			generate(rowCount,columnCount);
		}
		public void generate(int rc, int cc){
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
		
		    
		    //static Padding _padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
		    for (int i = 0; i < rowCount* columnCount; i++)
		    {
			 	Button b = new Button();
		        //if(b.Text!="0")
		        b.Text = "0";
		        //MessageBox.Show(b.Text.ToString());
		       // b.Height = 10;
		       //b.Width = 50;
		        b.Name = string.Format("b_{0}", i + 1);
		        b.Click += b_Click;
		        b.Dock = DockStyle.Fill;
		        this.tableLayoutPanel1.Controls.Add(b);
		        //MessageBox.Show(b.Name);
		        
		    }
		}
		void b_Click(object sender, EventArgs e)
		{
			Control control = (Control) sender;
			string b = control.Name;
			    //if (b != null)
			     //   MessageBox.Show(string.Format("{0} Clicked", b));
    
   			 int a= Int32.Parse(control.Text);
   			// MessageBox.Show(control.Name);
			if(a== rowCount* columnCount)
				a=0;
			control.Text=(a+1).ToString();
			
		}
		void Clear_btnClick(object sender, EventArgs e)
		{
			
			generate(rowCount,columnCount);
		}
		void CheckClick(object sender, EventArgs e)
		{
			rowsum();
			columnsum();
			
			int sum=0;
			
			for(int i=0; i< rowCount; i++)
			{
				for(int j=0; j< columnCount; j++)
				{
					if(rowstot[i]==columnstot[j])
					{
						sum++;
					}
				}				
			}
			
			
			for(int j=0; j< columnCount; j++)
			{				
				for(int i=0; i< rowCount; i++)
				{
					if(columnstot[j]==rowstot[i])
					{
						sum++;					
				    }
				}
			}
			
			
			for(int i=0; i< rowCount; i++)
			{
				for(int j=0; j< rowCount; j++)
				{
					if(rowstot[i]==rowstot[j])
					{
						sum++;
					}
				}
			}
			
			for(int i=0; i< columnCount; i++)
			{				
				for(int j=0; j< columnCount; j++)
				{
					if(columnstot[i]==columnstot[j])
					{
						sum++;
					}
				}
			}
			
			int sumt=Int32.Parse(sum.ToString());
			
			if(sum.Equals(4*(rowCount*columnCount)))
			{
				label3.Show();
				
					
				
			}
			else
			{
				label4.Show();
				label3.Hide();
			}
		}
		
		 void rowsum()
		{
			
			int i = 0,io = 0,rowCount1=0;
			w=0;
			
			//MessageBox.Show(tableLayoutPanel1.RowCount.ToString());
			
			for(int j=0; j < tableLayoutPanel1.RowCount;j++)
			{
				w=0;
				// MessageBox.Show(rowCount.ToString());
				
				if(j>0)
				{
					int ios=rowCount;
					
					rowCount1 =rowCount1+rowCount;
					io= io + ios;
				
				}
				
				else
				{
					rowCount1= rowCount;
				}
			    for ( i = io; i < rowCount1; i++)
			    {
			    	w=w+Int32.Parse(this.tableLayoutPanel1.Controls[i].Text);
			    	
			    }
			    rowstot[j] = w;
			    //MessageBox.Show(rowstot[0].ToString());
		    
			}
		}
		 
			
		 void columnsum()
		{
		 	
			
			
			//MessageBox.Show(tableLayoutPanel1.RowCount.ToString());
			
			for(int j=0; j< columnCount;j++)
			{
				 w=0; 
				 int temp;
				for(int i=0;i< columnCount;i++)
				{
					temp=i*columnCount;
					//MessageBox .Show (temp.ToString ());
					w=w+Int32.Parse(this.tableLayoutPanel1.Controls[j+temp].Text);
			    	
				}
				
				//MessageBox.Show(w.ToString());
				
				//w=w+Int32.Parse(this.tableLayoutPanel1.Controls[j+columnCount].Text);
				//MessageBox.Show(w.ToString());
				//w=w+Int32.Parse(this.tableLayoutPanel1.Controls[j+columnCount+columnCount].Text);
				columnstot[j] = w;
				//MessageBox.Show(columnstot[0].ToString());
			}
		}
		void Button6Click(object sender, EventArgs e)
		{
			//devdet s=new devdet();
			//s.Show();
			//developer.Show(); 
			play.Hide();
			developer.Show();
			//ans.Hide();
			hintspuzzle.Hide();
			instruction.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
			//Form1 d=new Form1();
			
			instruction.Show();
			play.Hide();
			developer.Hide();
			//ans.Hide();
			hintspuzzle.Hide();
		}
		void Button7Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
			play.Show();
			developer.Hide();
			//ans.Hide();
			hintspuzzle.Hide();
			instruction.Hide();
		}
		void Button4Click(object sender, EventArgs e)
		{
			hintspuzzle.Show();
			play.Hide();
			developer.Hide();
			//ans.Hide();
			instruction.Hide();
		}
		void Button5Click(object sender, EventArgs e)
		{
			//ans.Show();
			//play.Hide();
			//developer.Hide();
			//hintspuzzle.Hide();
			//instruction.Hide();
			answers ans = new answers();
			ans.Show();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
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
			
			
		
			
		}
		
		
	}

