/*
 * Created by SharpDevelop.
 * User: skolotajs
 * Date: 02.11.2022
 * Time: 17:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Desas
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
			this.B1 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.B4 = new System.Windows.Forms.Button();
			this.B5 = new System.Windows.Forms.Button();
			this.B6 = new System.Windows.Forms.Button();
			this.B7 = new System.Windows.Forms.Button();
			this.B8 = new System.Windows.Forms.Button();
			this.B9 = new System.Windows.Forms.Button();
			this.Turn = new System.Windows.Forms.Label();
			this.winner = new System.Windows.Forms.Label();
			this.reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// B1
			// 
			this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1.Location = new System.Drawing.Point(6, 57);
			this.B1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(161, 118);
			this.B1.TabIndex = 0;
			this.B1.UseVisualStyleBackColor = true;
			this.B1.Click += new System.EventHandler(this.B1Click);
			// 
			// B2
			// 
			this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2.Location = new System.Drawing.Point(161, 57);
			this.B2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(161, 118);
			this.B2.TabIndex = 1;
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.B2Click);
			// 
			// B3
			// 
			this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3.Location = new System.Drawing.Point(319, 57);
			this.B3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(161, 118);
			this.B3.TabIndex = 2;
			this.B3.UseVisualStyleBackColor = true;
			this.B3.Click += new System.EventHandler(this.B3Click);
			// 
			// B4
			// 
			this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B4.Location = new System.Drawing.Point(6, 173);
			this.B4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B4.Name = "B4";
			this.B4.Size = new System.Drawing.Size(161, 118);
			this.B4.TabIndex = 3;
			this.B4.UseVisualStyleBackColor = true;
			this.B4.Click += new System.EventHandler(this.B4Click);
			// 
			// B5
			// 
			this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B5.Location = new System.Drawing.Point(161, 173);
			this.B5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B5.Name = "B5";
			this.B5.Size = new System.Drawing.Size(161, 118);
			this.B5.TabIndex = 4;
			this.B5.UseVisualStyleBackColor = true;
			this.B5.Click += new System.EventHandler(this.B5Click);
			// 
			// B6
			// 
			this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B6.Location = new System.Drawing.Point(319, 173);
			this.B6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B6.Name = "B6";
			this.B6.Size = new System.Drawing.Size(161, 118);
			this.B6.TabIndex = 5;
			this.B6.UseVisualStyleBackColor = true;
			this.B6.Click += new System.EventHandler(this.B6Click);
			// 
			// B7
			// 
			this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B7.Location = new System.Drawing.Point(6, 287);
			this.B7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B7.Name = "B7";
			this.B7.Size = new System.Drawing.Size(161, 126);
			this.B7.TabIndex = 6;
			this.B7.UseVisualStyleBackColor = true;
			this.B7.Click += new System.EventHandler(this.B7Click);
			// 
			// B8
			// 
			this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B8.Location = new System.Drawing.Point(161, 287);
			this.B8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B8.Name = "B8";
			this.B8.Size = new System.Drawing.Size(161, 126);
			this.B8.TabIndex = 7;
			this.B8.UseVisualStyleBackColor = true;
			this.B8.Click += new System.EventHandler(this.B8Click);
			// 
			// B9
			// 
			this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B9.Location = new System.Drawing.Point(319, 287);
			this.B9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.B9.Name = "B9";
			this.B9.Size = new System.Drawing.Size(161, 126);
			this.B9.TabIndex = 8;
			this.B9.UseVisualStyleBackColor = true;
			this.B9.Click += new System.EventHandler(this.B9Click);
			// 
			// Turn
			// 
			this.Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Turn.Location = new System.Drawing.Point(494, 121);
			this.Turn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Turn.Name = "Turn";
			this.Turn.Size = new System.Drawing.Size(205, 91);
			this.Turn.TabIndex = 9;
			this.Turn.Text = "Turn: ";
			// 
			// winner
			// 
			this.winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.winner.Location = new System.Drawing.Point(494, 259);
			this.winner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.winner.Name = "winner";
			this.winner.Size = new System.Drawing.Size(205, 113);
			this.winner.TabIndex = 10;
			this.winner.Text = "Winner: none";
			// 
			// reset
			// 
			this.reset.Location = new System.Drawing.Point(40, 444);
			this.reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.reset.Name = "reset";
			this.reset.Size = new System.Drawing.Size(403, 86);
			this.reset.TabIndex = 11;
			this.reset.Text = "restart";
			this.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.reset.UseVisualStyleBackColor = true;
			this.reset.Click += new System.EventHandler(this.ResetClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 559);
			this.Controls.Add(this.reset);
			this.Controls.Add(this.winner);
			this.Controls.Add(this.Turn);
			this.Controls.Add(this.B9);
			this.Controls.Add(this.B8);
			this.Controls.Add(this.B7);
			this.Controls.Add(this.B6);
			this.Controls.Add(this.B5);
			this.Controls.Add(this.B4);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "Desas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Label winner;
		private System.Windows.Forms.Label Turn;
		private System.Windows.Forms.Button B9;
		private System.Windows.Forms.Button B8;
		private System.Windows.Forms.Button B7;
		private System.Windows.Forms.Button B6;
		private System.Windows.Forms.Button B5;
		private System.Windows.Forms.Button B4;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B1;
	}
}
