/*
 * Created by SharpDevelop.
 * User: skolotajs
 * Date: 23.11.2022
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Karatavas
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
			this.Guess = new System.Windows.Forms.TextBox();
			this.Wrongs = new System.Windows.Forms.Label();
			this.Vword = new System.Windows.Forms.Label();
			this.livesT = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Guess
			// 
			this.Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Guess.Location = new System.Drawing.Point(134, 341);
			this.Guess.MaxLength = 1;
			this.Guess.Name = "Guess";
			this.Guess.Size = new System.Drawing.Size(146, 128);
			this.Guess.TabIndex = 0;
			this.Guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Guess.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// Wrongs
			// 
			this.Wrongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Wrongs.ForeColor = System.Drawing.Color.Red;
			this.Wrongs.Location = new System.Drawing.Point(12, 260);
			this.Wrongs.Name = "Wrongs";
			this.Wrongs.Size = new System.Drawing.Size(401, 78);
			this.Wrongs.TabIndex = 2;
			this.Wrongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Vword
			// 
			this.Vword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Vword.Location = new System.Drawing.Point(12, 152);
			this.Vword.Name = "Vword";
			this.Vword.Size = new System.Drawing.Size(401, 37);
			this.Vword.TabIndex = 4;
			this.Vword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// livesT
			// 
			this.livesT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.livesT.Location = new System.Drawing.Point(12, 15);
			this.livesT.Name = "livesT";
			this.livesT.Size = new System.Drawing.Size(401, 48);
			this.livesT.TabIndex = 5;
			this.livesT.Text = "♥ ♥ ♥";
			this.livesT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// status
			// 
			this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.status.Location = new System.Drawing.Point(12, 63);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(401, 89);
			this.status.TabIndex = 6;
			this.status.Text = "label2";
			this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(368, 406);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 54);
			this.button1.TabIndex = 7;
			this.button1.Text = "⟲ ";
			this.button1.UseCompatibleTextRendering = true;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 472);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.status);
			this.Controls.Add(this.livesT);
			this.Controls.Add(this.Vword);
			this.Controls.Add(this.Wrongs);
			this.Controls.Add(this.Guess);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "MainForm";
			this.Text = "Karatavas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Label livesT;
		private System.Windows.Forms.Label Vword;
		private System.Windows.Forms.Label Wrongs;
		private System.Windows.Forms.TextBox Guess;
	}
}
