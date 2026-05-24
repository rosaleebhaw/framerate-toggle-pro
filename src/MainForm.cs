```csharp
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace CS2FrameRateManager
{
    public partial class MainForm : Form
    {
        private const string TargetProcessName = "cs2"; // Change based on the actual game process name
        private const int TimerInterval = 1000; // 1 second
        private Timer processCheckTimer;
        
        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.processCheckTimer = new Timer();
            this.processCheckTimer.Interval = TimerInterval;
            this.processCheckTimer.Tick += ProcessCheckTimer_Tick;
            this.processCheckTimer.Start();
        }

        private void ProcessCheckTimer_Tick(object sender, EventArgs e)
        {
            var processes = Process.GetProcessesByName(TargetProcessName);
            if (processes.Any())
            {
                UpdateUI(processes.First());
            }
            else
            {
                ResetUI();
            }
        }

        private void UpdateUI(Process gameProcess)
        {
            lblStatus.Text = $"Game Running: {gameProcess.ProcessName}";
            btnSetFramerate.Enabled = true;
        }

        private void ResetUI()
        {
            lblStatus.Text = "Game Not Running";
            btnSetFramerate.Enabled = false;
        }

        private void btnSetFramerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFramerate.Text) ||
                !int.TryParse(txtFramerate.Text, out int targetRate))
            {
                MessageBox.Show("Please enter a valid frame rate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Code to set the frame rate for the target game process
            SetTargetFrameRate(targetRate);
        }

        private void SetTargetFrameRate(int frameRate)
        {
            // Placeholder for setting frame rate logic
            MessageBox.Show($"Setting frame rate to {frameRate} FPS for {TargetProcessName}.", "Frame Rate Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            processCheckTimer.Stop();
            processCheckTimer.Dispose();
        }
    }
}
```