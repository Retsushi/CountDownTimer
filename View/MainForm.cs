namespace CountDownTimer
{
    public partial class MainForm : Form
    {
        private Model.TimerModel timerModel;
        private Controller.Controller controller;


        public MainForm()
        {
            //controller = Controller.Controller.ControllerInstance;
            //timerModel = Model.TimerModel.TimerModelInstance;
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
            // nannkayaruyo
        }
    }
}
