/*
 * Created by SharpDevelop.
 * User: skolotajs
 * Date: 02.11.2022
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kalkulators2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.box = new System.Windows.Forms.TextBox();
			this.B1 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.B4 = new System.Windows.Forms.Button();
			this.B5 = new System.Windows.Forms.Button();
			this.B6 = new System.Windows.Forms.Button();
			this.B7 = new System.Windows.Forms.Button();
			this.B8 = new System.Windows.Forms.Button();
			this.B9 = new System.Windows.Forms.Button();
			this.B0 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.div = new System.Windows.Forms.Button();
			this.min = new System.Windows.Forms.Button();
			this.mult = new System.Windows.Forms.Button();
			this.equal = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.BK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// box
			// 
			this.box.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.box.Location = new System.Drawing.Point(12, 12);
			this.box.Multiline = true;
			this.box.Name = "box";
			this.box.Size = new System.Drawing.Size(571, 143);
			this.box.TabIndex = 0;
			this.box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// B1
			// 
			this.B1.Location = new System.Drawing.Point(12, 161);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(84, 83);
			this.B1.TabIndex = 1;
			this.B1.Text = "1";
			this.B1.UseVisualStyleBackColor = true;
			this.B1.Click += new System.EventHandler(this.B1Click);
			// 
			// B2
			// 
			this.B2.Location = new System.Drawing.Point(102, 161);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(84, 83);
			this.B2.TabIndex = 2;
			this.B2.Text = "2";
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.B2Click);
			// 
			// B3
			// 
			this.B3.Location = new System.Drawing.Point(192, 161);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(84, 83);
			this.B3.TabIndex = 3;
			this.B3.Text = "3";
			this.B3.UseVisualStyleBackColor = true;
			this.B3.Click += new System.EventHandler(this.B3Click);
			// 
			// B4
			// 
			this.B4.Location = new System.Drawing.Point(12, 251);
			this.B4.Name = "B4";
			this.B4.Size = new System.Drawing.Size(81, 83);
			this.B4.TabIndex = 4;
			this.B4.Text = "4";
			this.B4.UseVisualStyleBackColor = true;
			this.B4.Click += new System.EventHandler(this.B4Click);
			// 
			// B5
			// 
			this.B5.Location = new System.Drawing.Point(99, 252);
			this.B5.Name = "B5";
			this.B5.Size = new System.Drawing.Size(84, 83);
			this.B5.TabIndex = 5;
			this.B5.Text = "5";
			this.B5.UseVisualStyleBackColor = true;
			this.B5.Click += new System.EventHandler(this.B5Click);
			// 
			// B6
			// 
			this.B6.Location = new System.Drawing.Point(192, 253);
			this.B6.Name = "B6";
			this.B6.Size = new System.Drawing.Size(84, 83);
			this.B6.TabIndex = 6;
			this.B6.Text = "6";
			this.B6.UseVisualStyleBackColor = true;
			this.B6.Click += new System.EventHandler(this.B6Click);
			// 
			// B7
			// 
			this.B7.Location = new System.Drawing.Point(12, 340);
			this.B7.Name = "B7";
			this.B7.Size = new System.Drawing.Size(84, 83);
			this.B7.TabIndex = 7;
			this.B7.Text = "7";
			this.B7.UseVisualStyleBackColor = true;
			this.B7.Click += new System.EventHandler(this.B7Click);
			// 
			// B8
			// 
			this.B8.Location = new System.Drawing.Point(99, 340);
			this.B8.Margin = new System.Windows.Forms.Padding(0);
			this.B8.Name = "B8";
			this.B8.Size = new System.Drawing.Size(84, 83);
			this.B8.TabIndex = 8;
			this.B8.Text = "8";
			this.B8.UseVisualStyleBackColor = true;
			this.B8.Click += new System.EventHandler(this.B8Click);
			// 
			// B9
			// 
			this.B9.Location = new System.Drawing.Point(192, 340);
			this.B9.Margin = new System.Windows.Forms.Padding(0);
			this.B9.Name = "B9";
			this.B9.Size = new System.Drawing.Size(84, 83);
			this.B9.TabIndex = 9;
			this.B9.Text = "9";
			this.B9.UseVisualStyleBackColor = true;
			this.B9.Click += new System.EventHandler(this.B9Click);
			// 
			// B0
			// 
			this.B0.Location = new System.Drawing.Point(290, 255);
			this.B0.Margin = new System.Windows.Forms.Padding(0);
			this.B0.Name = "B0";
			this.B0.Size = new System.Drawing.Size(87, 81);
			this.B0.TabIndex = 10;
			this.B0.Text = "0";
			this.B0.UseVisualStyleBackColor = true;
			this.B0.Click += new System.EventHandler(this.B0Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(496, 251);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 83);
			this.button2.TabIndex = 12;
			this.button2.Text = "+";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// div
			// 
			this.div.Location = new System.Drawing.Point(496, 161);
			this.div.Margin = new System.Windows.Forms.Padding(0);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(87, 82);
			this.div.TabIndex = 13;
			this.div.Text = "/";
			this.div.UseVisualStyleBackColor = true;
			this.div.Click += new System.EventHandler(this.DivClick);
			// 
			// min
			// 
			this.min.Location = new System.Drawing.Point(393, 162);
			this.min.Margin = new System.Windows.Forms.Padding(0);
			this.min.Name = "min";
			this.min.Size = new System.Drawing.Size(92, 82);
			this.min.TabIndex = 14;
			this.min.Text = "-";
			this.min.UseVisualStyleBackColor = true;
			this.min.Click += new System.EventHandler(this.MinClick);
			// 
			// mult
			// 
			this.mult.Location = new System.Drawing.Point(393, 251);
			this.mult.Margin = new System.Windows.Forms.Padding(0);
			this.mult.Name = "mult";
			this.mult.Size = new System.Drawing.Size(92, 83);
			this.mult.TabIndex = 15;
			this.mult.Text = "*";
			this.mult.UseVisualStyleBackColor = true;
			this.mult.Click += new System.EventHandler(this.MultClick);
			// 
			// equal
			// 
			this.equal.Location = new System.Drawing.Point(290, 162);
			this.equal.Margin = new System.Windows.Forms.Padding(0);
			this.equal.Name = "equal";
			this.equal.Size = new System.Drawing.Size(87, 83);
			this.equal.TabIndex = 16;
			this.equal.Text = "=";
			this.equal.UseVisualStyleBackColor = true;
			this.equal.Click += new System.EventHandler(this.EqualClick);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(393, 340);
			this.clear.Margin = new System.Windows.Forms.Padding(0);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(190, 81);
			this.clear.TabIndex = 17;
			this.clear.Text = "C";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.ClearClick);
			// 
			// BK
			// 
			this.BK.Location = new System.Drawing.Point(290, 342);
			this.BK.Margin = new System.Windows.Forms.Padding(0);
			this.BK.Name = "BK";
			this.BK.Size = new System.Drawing.Size(87, 81);
			this.BK.TabIndex = 18;
			this.BK.Text = ",";
			this.BK.UseVisualStyleBackColor = true;
			this.BK.Click += new System.EventHandler(this.BKClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(595, 430);
			this.Controls.Add(this.BK);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.equal);
			this.Controls.Add(this.mult);
			this.Controls.Add(this.min);
			this.Controls.Add(this.div);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.B0);
			this.Controls.Add(this.B9);
			this.Controls.Add(this.B8);
			this.Controls.Add(this.B7);
			this.Controls.Add(this.B6);
			this.Controls.Add(this.B5);
			this.Controls.Add(this.B4);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.box);
			this.Name = "MainForm";
			this.Text = "Kalkulators2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BK;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button equal;
		private System.Windows.Forms.Button mult;
		private System.Windows.Forms.Button min;
		private System.Windows.Forms.Button div;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button B0;
		private System.Windows.Forms.Button B9;
		private System.Windows.Forms.Button B8;
		private System.Windows.Forms.Button B7;
		private System.Windows.Forms.Button B6;
		private System.Windows.Forms.Button B5;
		private System.Windows.Forms.Button B4;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.TextBox box;
	}
}
