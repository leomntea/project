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
using System.Diagnostics;


namespace PC_room_management
{
    public partial class LoginOk : Form
    {
        private Stopwatch stopwatch;

        public LoginOk()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            StartStopwatch(); // 폼이 실행될 때 스톱워치를 자동으로 시작
        }

        private void LoginOk_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 수행할 작업
        }

        private void StartStopwatch()
        {
            stopwatch.Start();
            buttonStartStop.Text = "중지";
            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                buttonStartStop.Text = "시작";
            }
            else
            {
                StartStopwatch();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan elapsed = stopwatch.Elapsed;
                labelElapsedTime.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    elapsed.Hours, elapsed.Minutes, elapsed.Seconds,
                    elapsed.Milliseconds / 10);
            }
        }
    }
}