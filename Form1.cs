using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezTimer
{
	public partial class TimerForm : Form
	{
		private Stopwatch Timer = new Stopwatch();

		public TimerForm()
		{
			InitializeComponent();
			LoopTimer.Tick += Loop;
		}

		private void TimerForm_Load(object sender,EventArgs e)
		{
			LoopTimer.Start();
			this.Size = new Size(168,32);
		}

		private void ResetButton_Click(object sender,EventArgs e)
		{
			Timer.Reset();
		}

		private void StartStopButton_Click(object sender,EventArgs e)
		{
			if (Timer.IsRunning)
			{
				Stop();
			}
			else
			{
				Start();
			}
		}

		private void Loop(object sender,EventArgs e)
		{
			TimerBox.Text = Timer.Elapsed.ToString(@"hh\:mm\:ss\:ff");
		}

		private void Start()
		{
			Timer.Start();
		}

		private void Stop()
		{
			Timer.Stop();
		}

		private void TimerBox_Enter(object sender,EventArgs e)
		{
			this.ActiveControl = Dummy;
		}

		private void QuitButton_Click(object sender,EventArgs e)
		{
			Application.Exit();
		}

		////

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,int Msg,int wParam,int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void TimerForm_MouseDown(object sender,MouseEventArgs e)
		{
			DragCapture(sender,e);
		}

		private void TimerBox_MouseDown(object sender,MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle,WM_NCLBUTTONDOWN,HT_CAPTION,0);
			}
		}

		private void DragCapture(object sender,MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle,WM_NCLBUTTONDOWN,HT_CAPTION,0);
			}
		}
	}
}
