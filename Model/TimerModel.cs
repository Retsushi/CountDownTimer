
namespace CountDownTimer.Model
{
    internal class TimerModel
    {
        private int seconds;
        private static  TimerModel _instance = new TimerModel();

        public static TimerModel TimerModelInstance
        {
            get { return _instance; }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0) seconds = value;
                else seconds = 0;
            }
        }

        private TimerModel()
        {
            seconds = 0;
        }
    }
}
