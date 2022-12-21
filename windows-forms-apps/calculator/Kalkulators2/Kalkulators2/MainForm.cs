/*
 * Created by SharpDevelop.
 * User: skolotajs
 * Date: 02.11.2022
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulators2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public double sum = 0;
		public bool operation = false;
		public string number1 = "";
		public string number2 = "";
		public string operationText = " ";
		
		void MainFormLoad(object sender, EventArgs e)
		{
			box.Enabled = false;
			box.Text = "0";
		}
		
		void B1Click(object sender, EventArgs e)
		{
			AddNumber("1");
		}
		
		void B2Click(object sender, EventArgs e)
		{
			AddNumber("2");
		}
		
		void B3Click(object sender, EventArgs e)
		{
			AddNumber("3");
		}
		
		void B4Click(object sender, EventArgs e)
		{
			AddNumber("4");	
		}
		
		void B5Click(object sender, EventArgs e)
		{
			AddNumber("5");
		}
		
		void B6Click(object sender, EventArgs e)
		{
			AddNumber("6");
		}
		
		void B7Click(object sender, EventArgs e)
		{
			AddNumber("7");
		}
		
		void B8Click(object sender, EventArgs e)
		{
			AddNumber("8");
		}
		
		void B9Click(object sender, EventArgs e)
		{
			AddNumber("9");		
		}
		
		void B0Click(object sender, EventArgs e)
		{
			AddNumber("0");
		}
		public void AddNumber(string number)
		{
			if(!operation)
			{
				number1 += number;
				box.Text = number1 + operationText + number2;
			}
			else
			{
				number2 += number;
				box.Text = number1 + operationText + number2;
			}	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			operationText = "+";
			operation = true;
			box.Text = number1 + operationText + number2;
		}
		
		void MinClick(object sender, EventArgs e)
		{
			operationText = "-";
			operation = true;
			box.Text = number1 + operationText + number2;
		}
		
		void DivClick(object sender, EventArgs e)
		{
			operationText = "/";
			operation = true;
			box.Text = number1 + operationText + number2;
		}
		void MultClick(object sender, EventArgs e)
		{
			operationText = "*";
			operation = true;
			box.Text = number1 + operationText + number2;					
		}
		
		void EqualClick(object sender, EventArgs e)
		{
			if(operation)
			{
				if(operationText == "+")
				{
					sum = Convert.ToDouble(number1) + Convert.ToDouble(number2);
					box.Text = Convert.ToString(sum);
					number1 = box.Text;
					number2 = "";
					operation = false;
					operationText = " ";
				}
				if(operationText == "-")
				{
					sum = Convert.ToDouble(number1) - Convert.ToDouble(number2);
					box.Text = Convert.ToString(sum);
					number1 = box.Text;
					number2 = "";
					operation = false;
					operationText = " ";
				}
				if(operationText == "/")
				{
					sum = Convert.ToDouble(number1) / Convert.ToDouble(number2);
					box.Text = Convert.ToString(sum);
					number1 = box.Text;
					number2 = "";
					operation = false;
					operationText = " ";
				}
				if(operationText == "*")
				{
					sum = Convert.ToDouble(number1) * Convert.ToDouble(number2);
					box.Text = Convert.ToString(sum);
					number1 = box.Text;
					number2 = "";
					operation = false;
					operationText = " ";
				}
			}
		}
		
		void ClearClick(object sender, EventArgs e)
		{
			sum = 0;
			number1 = "";
			number2 = "";
			operation = false;
			box.Text = "0";
		}
		
		void BKClick(object sender, EventArgs e)
		{
			AddNumber(",");
		}
	}
}
