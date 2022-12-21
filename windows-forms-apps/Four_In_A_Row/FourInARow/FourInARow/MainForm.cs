/*
 * Created by SharpDevelop.
 * User: skolotajs
 * Date: 07.12.2022
 * Time: 17:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FourInARow
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
		public Button[,] gameBoard = new Button[7,6];
		public bool IsRedTurn;
		void MainFormLoad(object sender, EventArgs e)
		{
			gameBoard[0,0] = X1Y1;gameBoard[1,0] = X2Y1;gameBoard[2,0] = X3Y1;gameBoard[3,0] = X4Y1;gameBoard[4,0] = X5Y1;gameBoard[5,0] = X6Y1;gameBoard[6,0] = X7Y1;
			gameBoard[0,1] = X1Y2;gameBoard[1,1] = X2Y2;gameBoard[2,1] = X3Y2;gameBoard[3,1] = X4Y2;gameBoard[4,1] = X5Y2;gameBoard[5,1] = X6Y2;gameBoard[6,1] = X7Y2;
			gameBoard[0,2] = X1Y3;gameBoard[1,2] = X2Y3;gameBoard[2,2] = X3Y3;gameBoard[3,2] = X4Y3;gameBoard[4,2] = X5Y3;gameBoard[5,2] = X6Y3;gameBoard[6,2] = X7Y3;
			gameBoard[0,3] = X1Y4;gameBoard[1,3] = X2Y4;gameBoard[2,3] = X3Y4;gameBoard[3,3] = X4Y4;gameBoard[4,3] = X5Y4;gameBoard[5,3] = X6Y4;gameBoard[6,3] = X7Y4;
			gameBoard[0,4] = X1Y5;gameBoard[1,4] = X2Y5;gameBoard[2,4] = X3Y5;gameBoard[3,4] = X4Y5;gameBoard[4,4] = X5Y5;gameBoard[5,4] = X6Y5;gameBoard[6,4] = X7Y5;
			gameBoard[0,5] = X1Y6;gameBoard[1,5] = X2Y6;gameBoard[2,5] = X3Y6;gameBoard[3,5] = X4Y6;gameBoard[4,5] = X5Y6;gameBoard[5,5] = X6Y6;gameBoard[6,5] = X7Y6;
			IsRedTurn = false;
			turn.Text = IsRedTurn?"Red turn":"Blue turn";
			turn.ForeColor = IsRedTurn?Color.FromName("Red"):Color.FromName("Blue");
		}
		void Button1Click(object sender, EventArgs e)
		{
			AddPiece(0);
			Console.WriteLine("Checked for winner");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			AddPiece(1);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			AddPiece(2);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			AddPiece(3);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			AddPiece(4);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			AddPiece(5);
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			AddPiece(6);
		}
		void AddPiece(int row)
		{
			for(int i = 6; i > 0; i--)
			{
				if(gameBoard[row,i - 1].BackColor == Color.FromName("White"))
				{
					if(IsRedTurn)
					{
						gameBoard[row,i - 1].BackColor = Color.FromName("Red");
					}
					else
					{
						gameBoard[row,i - 1].BackColor = Color.FromName("Blue");
					}
					IsRedTurn = !IsRedTurn;
					break;
				}
			}
			CheckForWinner();
			turn.Text = IsRedTurn?"Red turn":"Blue turn";
			turn.ForeColor = IsRedTurn?Color.FromName("Red"):Color.FromName("Blue");
		}
		void CheckForWinner()
		{
			CheckForWinnerV();
			CheckForWinnerH();
			CheckForWinnerDR();
			CheckForWinnerDL();
			CheckForDraw();
		}
		void CheckForWinnerV()
		{
			for(int i = 0; i < 3; i++)
			{
				for(int j = 0; j < 7; j++)
				{
					string Y1 = gameBoard[j,i].BackColor.Name;
					string Y2 = gameBoard[j,i+1].BackColor.Name;
					string Y3 = gameBoard[j,i+2].BackColor.Name;
					string Y4 = gameBoard[j,i+3].BackColor.Name;
					if( Y1 == Y2 && Y2 == Y3 && Y3 == Y4 && Y4 != "White")
					{
						HaveWinner(Y1,Y2,Y3,Y4,Y4);
					}
				}
			}
		}
		void CheckForWinnerH()
		{
			for(int i = 0; i < 6; i++)
			{
				for(int j = 0; j < 4; j++)
				{
					string Y1 = gameBoard[j,i].BackColor.Name;
					string Y2 = gameBoard[j+1,i].BackColor.Name;
					string Y3 = gameBoard[j+2,i].BackColor.Name;
					string Y4 = gameBoard[j+3,i].BackColor.Name;
					if( Y1 == Y2 && Y2 == Y3 && Y3 == Y4 && Y4 != "White")
					{
						HaveWinner(Y1,Y2,Y3,Y4,Y4);
					}
				}
			}
		}
		void CheckForWinnerDR()
		{
			for(int i = 0; i < 3; i++)
			{
				for(int j = 0; j < 4; j++)
				{
					string Y1 = gameBoard[j,i].BackColor.Name;
					string Y2 = gameBoard[j+1,i+1].BackColor.Name;
					string Y3 = gameBoard[j+2,i+2].BackColor.Name;
					string Y4 = gameBoard[j+3,i+3].BackColor.Name;
					if( Y1 == Y2 && Y2 == Y3 && Y3 == Y4 && Y4 != "White")
					{
						HaveWinner(Y1,Y2,Y3,Y4,Y4);
					}
				}
			}
		}
		void CheckForWinnerDL()
		{	
			for(int i = 6; i > 2; i--)
			{
				for(int j = 2; j >= 0; j--)
				{
					string Y1 = gameBoard[i,j].BackColor.Name;
					string Y2 = gameBoard[i-1,j+1].BackColor.Name;
					string Y3 = gameBoard[i-2,j+2].BackColor.Name;
					string Y4 = gameBoard[i-3,j+3].BackColor.Name;
					if( Y1 == Y2 && Y2 == Y3 && Y3 == Y4 && Y4 != "White")
					{
						HaveWinner(Y1,Y2,Y3,Y4,Y4);
					}
				}
			}
		}
		void HaveWinner(string Y1, string Y2, string Y3, string Y4, string winner)
		{
			if( Y1 == Y2 && Y2 == Y3 && Y3 == Y4 && Y4 != "White")
			{
				output.Text = winner + " WINS!" ;
				output.ForeColor = Color.FromName(winner);
			}
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			foreach(Button piece in gameBoard)
			{
				piece.BackColor = Color.FromName("white");
				IsRedTurn = false;
				turn.Text = IsRedTurn?"Red turn":"Blue turn";
				turn.ForeColor = IsRedTurn?Color.FromName("Red"):Color.FromName("Blue");
				output.Text = "";
			}
		}
		void CheckForDraw()
		{
			int count = 0;
			foreach(Button btn in gameBoard)
			{
				if(btn.BackColor == Color.FromName("white"))
				{
				 	count++;  	
				}
			}
			if(count == 0)
			{
				draw();
			}
		}
		void draw()
		{
			output.Text = "BOTH LOST";
			output.ForeColor = Color.FromName("green");
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
		}
	}
}
