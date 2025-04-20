using CountDownTimer.Controller;

namespace CountDownTimer
{
    public partial class MainForm : Form
    {
        private TimerController TCtrl;
        public Button Btn1SecUP() { return Btn_1SecUP; }
        public Button Btn1SecDwn() { return Btn_1SecDwn; }
        public Button BtnMin1Up() { return Btn_Min1Up; }
        public Button BtnMin1Dwn() { return Btn_Min1Dwn; }
        public Button BtnStartStop() { return Btn_StartStop; }

        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateTime(int seconds)
        {
            int minutes = seconds / 60;
            int remainingSeconds = seconds % 60;
            // Update the label with the formatted time
            Lbl_Time.Text = $"{minutes:D2}:{remainingSeconds:D2}";
        }

    }
}
