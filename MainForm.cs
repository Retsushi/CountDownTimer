namespace CountDownTimer
{
    public partial class MainForm : Form
    {
        int Time = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_1SecUP_Click(object sender, EventArgs e)
        {
            int minutes = 0;
            int seconds = 0;
            Time++;

            minutes = Time / 60;
            seconds = Time % 60;
            Lbl_Time.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        private void Btn_1MinUP_Click(object sender, EventArgs e)
        {
            int minutes = 0;
            int seconds = 0;
            Time+=60;

            minutes = Time / 60;
            seconds = Time % 60;
            Lbl_Time.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        private void Btn_1SecDwn_Click(object sender, EventArgs e)
        {
            int minutes = 0;
            int seconds = 0;
            Time--;

            if (Time < 0)
            {
                Time = 0;
            }

            minutes = Time / 60;
            seconds = Time % 60;
            Lbl_Time.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        private void Btn_1MinDwn_Click(object sender, EventArgs e)
        {
            int minutes = 0;
            int seconds = 0;
            Time-=60;

            if (Time < 0)
            {
                Time = 0;
            }

            minutes = Time / 60;
            seconds = Time % 60;
            Lbl_Time.Text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }


        // This is ZEN-POWER branch!


    }
}
