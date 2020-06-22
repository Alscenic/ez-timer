namespace ezTimer
{
	partial class TimerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ResetButton = new System.Windows.Forms.Button();
			this.TimerBox = new System.Windows.Forms.TextBox();
			this.LoopTimer = new System.Windows.Forms.Timer(this.components);
			this.StartStopButton = new System.Windows.Forms.Button();
			this.Dummy = new System.Windows.Forms.Label();
			this.QuitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ResetButton
			// 
			this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ResetButton.Location = new System.Drawing.Point(24, 5);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(32, 23);
			this.ResetButton.TabIndex = 0;
			this.ResetButton.Text = "RES";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// TimerBox
			// 
			this.TimerBox.CausesValidation = false;
			this.TimerBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.TimerBox.Location = new System.Drawing.Point(59, 8);
			this.TimerBox.Multiline = true;
			this.TimerBox.Name = "TimerBox";
			this.TimerBox.ReadOnly = true;
			this.TimerBox.ShortcutsEnabled = false;
			this.TimerBox.Size = new System.Drawing.Size(69, 17);
			this.TimerBox.TabIndex = 1;
			this.TimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TimerBox.Enter += new System.EventHandler(this.TimerBox_Enter);
			this.TimerBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimerBox_MouseDown);
			// 
			// LoopTimer
			// 
			this.LoopTimer.Interval = 1;
			// 
			// StartStopButton
			// 
			this.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.StartStopButton.Location = new System.Drawing.Point(131, 5);
			this.StartStopButton.Name = "StartStopButton";
			this.StartStopButton.Size = new System.Drawing.Size(32, 23);
			this.StartStopButton.TabIndex = 0;
			this.StartStopButton.Text = "S/S";
			this.StartStopButton.UseVisualStyleBackColor = true;
			this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
			// 
			// Dummy
			// 
			this.Dummy.AutoSize = true;
			this.Dummy.Location = new System.Drawing.Point(0, 0);
			this.Dummy.Name = "Dummy";
			this.Dummy.Size = new System.Drawing.Size(0, 13);
			this.Dummy.TabIndex = 2;
			this.Dummy.Visible = false;
			// 
			// QuitButton
			// 
			this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.QuitButton.Location = new System.Drawing.Point(5, 5);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(17, 23);
			this.QuitButton.TabIndex = 0;
			this.QuitButton.Text = "X";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// TimerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(168, 32);
			this.Controls.Add(this.Dummy);
			this.Controls.Add(this.TimerBox);
			this.Controls.Add(this.StartStopButton);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.ResetButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TimerForm";
			this.Opacity = 0.7D;
			this.ShowInTaskbar = false;
			this.Text = "ezTimer";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.TimerForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimerForm_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.TextBox TimerBox;
		private System.Windows.Forms.Timer LoopTimer;
		private System.Windows.Forms.Button StartStopButton;
		private System.Windows.Forms.Label Dummy;
		private System.Windows.Forms.Button QuitButton;
	}
}

