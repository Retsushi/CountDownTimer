
using CountDownTimer.Model;
using System.Diagnostics.CodeAnalysis;

namespace CountDownTimer.Controller
{
    public class TimerController
    {
        TimerModel TModel;
        MainForm Mform;

        // Constructor
        public TimerController()
        {
            TModel = new TimerModel();
            Mform = new MainForm();
            TModel.UpdateView += Mform.UpdateTime;
            Mform.Btn1SecUP().Click += Btn_1SecUp_Click!;
            Mform.Btn1SecDwn().Click += Btn_1SecDwn_Click!;
            Mform.BtnMin1Up().Click += Btn_1MinUp_Click!;
            Mform.BtnMin1Dwn().Click += Btn_1MinDwn_Click!;
            Application.Run(Mform);
        }

        public int AddSec(int add)
        {
            if (TModel.Seconds + add >= 0) TModel.Seconds += add;
            else TModel.Seconds = 0;

            return TModel.Seconds;
        }

        public int SubSec(int sub)
        {
            if (TModel.Seconds - sub >= 0) TModel.Seconds -= sub;
            else TModel.Seconds = 0;

            return TModel.Seconds;
        }

        [MemberNotNullWhen(true, nameof(TModel))]
        public void Btn_1SecUp_Click(object sender, EventArgs e)
        {
            AddSec(1);
        }

        public void Btn_1SecDwn_Click(object sender, EventArgs e)
        {
            SubSec(1);
            
        }

        public void Btn_1MinUp_Click(object sender, EventArgs e)
        {
            AddSec(60);
        }

        public void Btn_1MinDwn_Click(object sender, EventArgs e)
        {
            SubSec(60);
        }

        private void Btn_StartStop_Click(object sender, EventArgs e)
        {

        }
    }
}
