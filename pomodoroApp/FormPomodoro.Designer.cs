namespace PomodoroApp {
  partial class FormPomodoro {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.lblWork = new System.Windows.Forms.Label();
      this.lblRest = new System.Windows.Forms.Label();
      this.lblClock = new System.Windows.Forms.Label();
      this.tbWork = new System.Windows.Forms.TextBox();
      this.tbRest = new System.Windows.Forms.TextBox();
      this.btnStartStop = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.tmrClock = new System.Windows.Forms.Timer(this.components);
      this.lblStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblWork
      // 
      this.lblWork.Location = new System.Drawing.Point(39, 36);
      this.lblWork.Name = "lblWork";
      this.lblWork.Size = new System.Drawing.Size(125, 20);
      this.lblWork.TabIndex = 0;
      this.lblWork.Text = "Work (min):";
      this.lblWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblRest
      // 
      this.lblRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblRest.Location = new System.Drawing.Point(454, 36);
      this.lblRest.Name = "lblRest";
      this.lblRest.Size = new System.Drawing.Size(125, 20);
      this.lblRest.TabIndex = 1;
      this.lblRest.Text = "Rest (min):";
      this.lblRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblClock
      // 
      this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblClock.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.lblClock.Location = new System.Drawing.Point(76, 123);
      this.lblClock.Name = "lblClock";
      this.lblClock.Size = new System.Drawing.Size(471, 67);
      this.lblClock.TabIndex = 2;
      this.lblClock.Text = "25:00";
      this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbWork
      // 
      this.tbWork.Location = new System.Drawing.Point(39, 59);
      this.tbWork.Name = "tbWork";
      this.tbWork.Size = new System.Drawing.Size(125, 27);
      this.tbWork.TabIndex = 3;
      this.tbWork.Text = "25";
      this.tbWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // tbRest
      // 
      this.tbRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbRest.Location = new System.Drawing.Point(454, 59);
      this.tbRest.Name = "tbRest";
      this.tbRest.Size = new System.Drawing.Size(125, 27);
      this.tbRest.TabIndex = 4;
      this.tbRest.Text = "5";
      this.tbRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnStartStop
      // 
      this.btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnStartStop.Location = new System.Drawing.Point(39, 224);
      this.btnStartStop.Name = "btnStartStop";
      this.btnStartStop.Size = new System.Drawing.Size(125, 45);
      this.btnStartStop.TabIndex = 5;
      this.btnStartStop.Text = "Start / Stop";
      this.btnStartStop.UseVisualStyleBackColor = true;
      this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
      // 
      // btnReset
      // 
      this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReset.Location = new System.Drawing.Point(454, 224);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(125, 45);
      this.btnReset.TabIndex = 6;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // tmrClock
      // 
      this.tmrClock.Interval = 1000;
      this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
      // 
      // lblStatus
      // 
      this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblStatus.BackColor = System.Drawing.Color.LightYellow;
      this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblStatus.Location = new System.Drawing.Point(170, 62);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(278, 24);
      this.lblStatus.TabIndex = 7;
      this.lblStatus.Text = "Work in progress...";
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FormPomodoro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(635, 311);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnStartStop);
      this.Controls.Add(this.tbRest);
      this.Controls.Add(this.tbWork);
      this.Controls.Add(this.lblClock);
      this.Controls.Add(this.lblRest);
      this.Controls.Add(this.lblWork);
      this.Name = "FormPomodoro";
      this.Text = "PomodoroApp";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label lblWork;
    private Label lblRest;
    private Label lblClock;
    private TextBox tbWork;
    private TextBox tbRest;
    private Button btnStartStop;
    private Button btnReset;
    private System.Windows.Forms.Timer tmrClock;
    private Label lblStatus;
  }
}