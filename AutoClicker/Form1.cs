using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private System.Windows.Forms.Timer clickTimer;


        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;

            // Force-populate the ComboBox items so it's never empty
            comboBoxKey.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBoxKey.Items.Add($"F{i}");
            }

            // Set default selection to F6 (if F6 exists in the list)
            if (comboBoxKey.Items.Count >= 6)
            {
                comboBoxKey.SelectedIndex = 5;
            }

            clickTimer = new System.Windows.Forms.Timer();
            clickTimer.Interval = 100; // Default: 100ms speed
            clickTimer.Tick += ClickTimer_Tick;

            button2.Enabled = false; // Stop button disabled initially
        }

        private void ClickTimer_Tick(object? sender, EventArgs e)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartClicking();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            StopClicking();
        }

        private void StartClicking()
        {
            clickTimer.Start();
            button1.Enabled = false; // Disable Start
            button2.Enabled = true;  // Enable Stop
            comboBoxKey.Enabled = false; // Lock dropdown while running
        }

        private void StopClicking()
        {
            clickTimer.Stop();
            button1.Enabled = true;  // Enable Start
            button2.Enabled = false; // Disable Stop
            comboBoxKey.Enabled = true; // Unlock dropdown
        }

        // Global hotkey check reading dynamically from the ComboBox
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            string selectedKeyStr = comboBoxKey.Text;
            if (string.IsNullOrEmpty(selectedKeyStr))
            {
                selectedKeyStr = "F6";
            }

            if (Enum.TryParse(selectedKeyStr, out Keys targetKey))
            {
                if (keyData == targetKey)
                {
                    if (clickTimer.Enabled)
                    {
                        StopClicking();
                    }
                    else
                    {
                        StartClicking();
                    }

                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}