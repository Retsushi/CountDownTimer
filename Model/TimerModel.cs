
using System.Runtime.CompilerServices;

namespace CountDownTimer.Model
{
    internal class TimerModel
    {
        private int seconds;
        
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0) seconds = value;
                else seconds = 0;

                // Notify the view to update
                UpdateView?.Invoke(seconds);
            }
        }

        public delegate void NotifyView(int sec);
        public NotifyView UpdateView;

        public TimerModel()
        {
            seconds = 0;
            UpdateView = null;

        }
    }
}
