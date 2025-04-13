using CountDownTimer.Controller;
using CountDownTimer.Model;

namespace CountDownTimer
{
    public partial class MainForm : Form
    {
        private TimerController TCtrl;

        public MainForm()
        {
            TCtrl = TimerController.ControllerInstance;
            InitializeComponent();
        }

        public void UpdateTime(int seconds)
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            // Update the label with the formatted time
            Lbl_Time.Text = $"{minutes:D2}:{remainingSeconds:D2}";
        }

        public void Btn_1SecUp_Click(object sender, EventArgs e)
        {
            int seconds = TCtrl.AddSec(1);
            UpdateTime(seconds);
        }

        public void Btn_1SecDwn_Click(object sender, EventArgs e)
        {
            int seconds = TCtrl.SubSec(1);
            UpdateTime(seconds);
        }

        public void Btn_1MinUp_Click(object sender, EventArgs e)
        {
            int seconds = TCtrl.AddSec(60);
            UpdateTime(seconds);
        }

        public void Btn_1MinDwn_Click(object sender, EventArgs e)
        {
            int seconds = TCtrl.SubSec(60);
            UpdateTime(seconds);
        }
    }
}
