namespace PomodoroApp {
  public partial class FormPomodoro : Form {
    public FormPomodoro() {
      InitializeComponent();
      pomodoro = new Pomodoro(25 ,5);
            pomodoro.ToString();
    }

    public void RefreshClock() {
            lblClock.Text = pomodoro.ToString();
    }

    public void RefreshStatus() {
      if (pomodoro.WorkInProgress) {
        lblStatus.Text = "Work in progress...";
        lblStatus.BackColor = Color.LightYellow;
      } else {
        lblStatus.Text = "Rest in progress...";
        lblStatus.BackColor = Color.PaleGreen;
      }
    }

    private void tmrClock_Tick(object sender, EventArgs e) {
      pomodoro.Update();
      RefreshStatus();
      RefreshClock();
    }

    private void btnStartStop_Click(object sender, EventArgs e) {
      tmrClock.Enabled = !tmrClock.Enabled;
    }

    private void btnReset_Click(object sender, EventArgs e) {
      tmrClock.Enabled = false;

            int workDurationInSeconds = int.Parse(tbWork.Text);
            int restDurationInSeconds = int.Parse(tbRest.Text);
            pomodoro = new Pomodoro(workDurationInSeconds, restDurationInSeconds);
            RefreshClock();
    }

        /*
        private bool workInProgress;
        private int seconds;
        */
        private Pomodoro pomodoro; //nema objekt

  }
}