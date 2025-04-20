
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CountDownTimer.Model
{
    internal class TimerModel
    {
        private int seconds;
        private System.Windows.Forms.Timer timer;

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0) seconds = value;
                else seconds = 0;

                // Notify the view to update
                UpdateViewTime?.Invoke(seconds);
            }
        }

        public delegate void NotifyView(int sec);
        public NotifyView UpdateViewTime;
        public NotifyView UpdateViewButton;

        public TimerModel()
        {
            seconds = 0;
            UpdateViewTime = _ => { }; // Initialize with a no-op delegate
            UpdateViewButton = _ => { }; // Initialize with a no-op delegate
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                UpdateViewTime?.Invoke(seconds);
            }
            else
            {
                timer.Stop();
                UpdateViewButton?.Invoke(0);
            }
        }

        public void ChangeStateTimer()
        {
            if ( (!timer.Enabled)&&(seconds>0) )
            {
                timer.Start();
                UpdateViewButton?.Invoke(1); // Timer started
            }
            else
            {
                timer.Stop();
                UpdateViewButton?.Invoke(0); // Timer stopped
            }

        }

    }
}
