using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer.Model
{
    internal class TimerModel
    {
        private int seconds;
        private TimerModel timerModel = new TimerModel();

        public TimerModel TimerModelInstance
        {
            get
            {
                return timerModel;
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0)
                {
                    seconds = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Seconds cannot be negative.");
                }
            }
        }

        private TimerModel()
        {
            seconds = 0;
        }
    }
}
