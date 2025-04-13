
using CountDownTimer.Model;

namespace CountDownTimer.Controller
{
    internal class TimerController
    {

        TimerModel TModel;

        // Singleton instance
        private static TimerController _instance = new TimerController();

        // Constructor
        private TimerController()
        {
            TModel = TimerModel.TimerModelInstance;
        }

        // Singleton Property
        public static TimerController ControllerInstance
        {
            get
            {
                return _instance;
            }
        }


        public int AddSec(int add)
        {
            if (TModel.Seconds + add >= 0)
            {
                TModel.Seconds += add;
            }
            else
            {
                TModel.Seconds = 0;
            }
            return TModel.Seconds;
        }

        public int SubSec(int sub)
        {
            if (TModel.Seconds - sub >= 0)
            {
                TModel.Seconds -= sub;
            }
            else
            {
                TModel.Seconds = 0;
            }
            return TModel.Seconds;
        }
    }
}
