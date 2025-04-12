using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownTimer.Controller
{
    internal class Controller
    {
        private Controller controller = new Controller();
        public Controller ControllerInstance
        {
            get
            {
                return controller;
            }
        }

        // Constructor
        private Controller() { }

        public int AddSec(int sec, int add)
        {
            if (sec + add >= 0)
            {
                return sec + add;
            }
            else
            {
                return 0;
            }
        }

        public int SubSec(int sec, int sub)
        {
            if (sec - sub >= 0)
            {
                return sec - sub;
            }
            else
            {
                return 0;
            }
        }
    }
}
