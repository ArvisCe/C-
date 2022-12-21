/*
 * Created by SharpDevelop.
 * User: skolotajs
 * Date: 02.11.2022
 * Time: 17:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desas
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
		
		public bool CircleTurn = false;
		void B1Click(object sender, EventArgs e)
		{
			B1.Text = CircleTurn? "O":"X";
			B1.Enabled = false;
			DoTurn();
		}
		
		void B2Click(object sender, EventArgs e)
		{
			B2.Text = CircleTurn? "O":"X";
			B2.Enabled = false;
			DoTurn();
		}
		
		void B3Click(object sender, EventArgs e)
		{
			B3.Text = CircleTurn? "O":"X";
			B3.Enabled = false;
			DoTurn();			
		}
		
		void B4Click(object sender, EventArgs e)
		{
			B4.Text = CircleTurn? "O":"X";
			B4.Enabled = false;
			DoTurn();			
		}
		
		void B5Click(object sender, EventArgs e)
		{
			B5.Text = CircleTurn? "O":"X";
			B5.Enabled = false;
			DoTurn();			
		}
		
		void B6Click(object sender, EventArgs e)
		{
			B6.Text = CircleTurn? "O":"X";
			B6.Enabled = false;
			DoTurn();			
		}
		
		void B7Click(object sender, EventArgs e)
		{
			B7.Text = CircleTurn? "O":"X";
			B7.Enabled = false;
			DoTurn();			
		}
		
		void B8Click(object sender, EventArgs e)
		{
			B8.Text = CircleTurn? "O":"X";
			B8.Enabled = false;
			DoTurn();			
		}
		
		void B9Click(object sender, EventArgs e)
		{
			B9.Text = CircleTurn? "O":"X";
			B9.Enabled = false;
			DoTurn();			
		}
		public void DoTurn()
		{
			CircleTurn = !CircleTurn;
			if(CircleTurn)
			{
				Turn.Text = "Turn: Circle";
			}
			else
			{
				Turn.Text = "Turn: Cross";
			}
			CheckWinner();
		}
		
		public void CheckWinner()
		{
			if(B1.Text == B2.Text && B2.Text == B3.Text && B2.Text != "")
			{
				winner.Text = "Winner: " + B2.Text;
				HaveWinner();
			}
			if(B4.Text == B5.Text && B5.Text == B6.Text && B5.Text != "")
			{
				winner.Text = "Winner: " + B5.Text;
				HaveWinner();
			}
			if(B7.Text == B8.Text && B8.Text == B9.Text && B8.Text != "")
			{
				winner.Text = "Winner: " + B8.Text;
				HaveWinner();
			}
			if(B1.Text == B4.Text && B4.Text == B7.Text && B4.Text != "")
			{
				winner.Text = "Winner: " + B4.Text;
				HaveWinner();
			}
			if(B2.Text == B5.Text && B5.Text == B8.Text && B5.Text != "")
			{
				winner.Text = "Winner: " + B5.Text;
				HaveWinner();
			}
			if(B3.Text == B6.Text && B6.Text == B9.Text && B6.Text != "")
			{
				winner.Text = "Winner: " + B6.Text;
				HaveWinner();
			}
			if(B1.Text == B5.Text && B5.Text == B9.Text && B5.Text != "")
			{
				winner.Text = "Winner: " + B5.Text;
				HaveWinner();
			}
			if(B3.Text == B5.Text && B5.Text == B7.Text && B5.Text != "")
			{
				winner.Text = "Winner: " + B5.Text;
				HaveWinner();
			}
		}
		
		public void HaveWinner()
		{
			B1.Enabled = false;
			B2.Enabled = false;
			B3.Enabled = false;
			B4.Enabled = false;
			B5.Enabled = false;
			B6.Enabled = false;
			B7.Enabled = false;
			B8.Enabled = false;
			B9.Enabled = false;
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			DoTurn();
		}
		
		void ResetClick(object sender, EventArgs e)
		{
			B1.Enabled = true;
			B2.Enabled = true;
			B3.Enabled = true;
			B4.Enabled = true;
			B5.Enabled = true;
			B6.Enabled = true;
			B7.Enabled = true;
			B8.Enabled = true;
			B9.Enabled = true;
			
			B1.Text = "";
			B2.Text = "";
			B3.Text = "";
			B4.Text = "";
			B5.Text = "";
			B6.Text = "";
			B7.Text = "";
			B8.Text = "";
			B9.Text = "";
			
			winner.Text = "";
			Turn.Text = "";
			DoTurn();
		}
	}
}
