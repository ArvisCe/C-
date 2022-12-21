/*
 * Created by SharpDevelop.
 * User: skolotajs
 * Date: 23.11.2022
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Karatavas
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
		
		
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			Guess.Text = Guess.Text.ToLower();
			if(Guess.Text != "")
			{
				string guess = Guess.Text;
				Guess.Text = ""; 
				if(word.Contains(guess))
				{
					string placeHolder = "";
					for(int i = 0; i < word.Length; i++)
					{
						if(word[i] == guess[0])
						{
							placeHolder += guess[0];
						}
						else
						{
							placeHolder += Vword.Text[i];
						}
					}
					Vword.Text = placeHolder;
				}
				else
				{
					if(!Wrongs.Text.Contains(guess))
					{
						Wrongs.Text += " "+guess[0];
						lives -= 1;
						livesT.Text = "";
						for(int i = 0; i < lives; i++)
						{
							livesT.Text += "♥";
						}
					}
				}
			}			
			if(!Vword.Text.Contains("︵"))
			{
				Win();
			}
			if(lives == 0)
			{
				Lose();
			}

		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void SubmitClick(object sender, EventArgs e)
		{
			if(Guess.Text != "")
			{
				string guess = Guess.Text;
				Guess.Text = ""; 
			}
		}
		public string word;
		public string[] words = System.IO.File.ReadAllLines(@"C:\Users\skolotajs\Documents\SharpDevelop Projects\Karatavas\Karatavas\WordList.txt");
		public int lives = 5;
		void MainFormLoad(object sender, EventArgs e)
		{
			status.Text = "";
			status.ForeColor = Color.Black;
			livesT.Text = "♥ ♥ ♥ ♥ ♥";
			Guess.Enabled = true;
			Random rnd = new Random();
			word = words[rnd.Next(0, words.Length)];
			Vword.Text = "";	
			foreach (char letter in word) 
			{
				Vword.Text += "︵";	
			}
		}
		public void Lose()
		{
			Guess.Enabled = false;
			status.Text = "You lose";
			status.ForeColor = Color.Red;
			Vword.Text = "Correct word: "+word;
		}
		public void Win()
		{
			Guess.Enabled = false;
			status.Text = "You win";
			status.ForeColor = Color.Green;
			Vword.Text = "You guess the word: "+word;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			status.Text = "";
			status.ForeColor = Color.Black;
			livesT.Text = "♥ ♥ ♥ ♥ ♥";
			Guess.Enabled = true;
			Random rnd = new Random();
			word = words[rnd.Next(0, words.Length)];
			Vword.Text = "";	
			lives = 5;
			Wrongs.Text = "";
			foreach (char letter in word) 
			{
				Vword.Text += "︵";	
			}
		}
	}
}
