using System;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace Win10_Keyboard_Resizer
{
    public partial class MainForm : Form
    {
        // Registry key path
        string RegKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Scaling";
        // The name of the registry value we need to change
        string RegValName = "Monitorsize";
        // The size of the screen in inches
        double ScreenSizeInches = 15;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Update the form with the current value
            LoadValue();

            // Work out diagonal size of the screen (not super accurate but close enough)
            // https://theezitguy.wordpress.com/2016/09/26/get-monitor-size-programmatically/
            var searcher = new ManagementObjectSearcher("\\root\\wmi", "SELECT * FROM WmiMonitorBasicDisplayParams");
            foreach (ManagementObject mo in searcher.Get())
            {
                double width = (byte)mo["MaxHorizontalImageSize"] / 2.54;
                double height = (byte)mo["MaxVerticalImageSize"] / 2.54;
                double diagonal = Math.Sqrt(width * width + height * height);
                ScreenSizeInches = diagonal;
            }
        }

        /// <summary>
        /// Calculates a new screen size, updates the registry and then restarts the keyboard process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Get the new keyboard scale percentage
            double percent = Convert.ToDouble(KeyboardScale.Text);

            // Start off with the current screen size
            double newSize = ScreenSizeInches;

            // As long as we have a valid percentage
            if (percent > 0)
            {
                // Divide the screen size by the percentage so we get a bigger screen size number
                newSize = newSize / (percent / 100);
            }

            // Update the registry
            Registry.SetValue(RegKey, RegValName, newSize.ToString());

            // Restart the keyboard so the new registry value takes effect
            RestartKeyboard();
        }

        /// <summary>
        /// Gets the current keyboard scale from the registry
        /// </summary>
        private void LoadValue()
        {
            try
            {
                KeyboardScale.Text = Registry.GetValue(RegKey, "Monitorsize", "100").ToString();
            }
            catch (Exception ex)
            {
                KeyboardScale.Text = "100";
            }
            KeyboardScaleBar.Value = Convert.ToInt32(KeyboardScale.Text);
        }

        /// <summary>
        /// Reset button deletes the registry value to reset it back to default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Registry.DeleteValue(RegKey, RegValName);
            RestartKeyboard();
            LoadValue();
        }

        /// <summary>
        /// Restarts the TabTip.exe process so the keyboard changes size instantly
        /// </summary>
        private void RestartKeyboard()
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("TabTip"))
                {
                    process.Kill();
                    process.WaitForExit();
                }
                Process.Start(@"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe");
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error restarting the keyboard!\r\n" + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// When the scale trackbar value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardScaleBar_Scroll(object sender, EventArgs e)
        {
            KeyboardScale.Text = KeyboardScaleBar.Value.ToString();
        }

        /// <summary>
        /// When the value of the textbox changes update the trackbar so it's in sync
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardScale_ValueChanged(object sender, EventArgs e)
        {
            KeyboardScaleBar.Value = Convert.ToInt32(KeyboardScale.Value);
        }

        /// <summary>
        /// When user presses a keyboard key make sure it still has a number in the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardScale_KeyUp(object sender, KeyEventArgs e)
        {
            KeyboardScaleBar.Value = Convert.ToInt32(KeyboardScale.Value);
            if (KeyboardScale.Text.Length == 0)
                KeyboardScale.Text = "0";
        }
    }
}
