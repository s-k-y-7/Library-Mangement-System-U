using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LMS
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public AppBody()
        {
            InitializeComponent();
            //initializing the sliding panel
            isSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_timer.Start();
        }

        private void Log_in_timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_timer.Stop();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void TitleBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidingPanelGUI()
        {
            BooksTabButton.Text = "BOOKS";
            BorrowersTabButton.Text = "BORROWERS";
            TransactionTabButton.Text = "TRANSACTIONS";
            SettingsTabButton.Text = "SETTINGS";
            AboutTabButton.Text = "ABOUT";
            SlidingPanel_ToggleButton.Image = Properties.Resources.llarrow;
            BooksTabButton.Image = null;
            BorrowersTabButton.Image = null;
            TransactionTabButton.Image = null;
            SettingsTabButton.Image = null;
            AboutTabButton.Image = null;
        }

        public void retractSlidingPanelGUI()
        {
            BooksTabButton.Text = "";
            BorrowersTabButton.Text = "";
            TransactionTabButton.Text = "";
            SettingsTabButton.Text = "";
            AboutTabButton.Text = "";
            SlidingPanel_ToggleButton.Image = Properties.Resources.rrArrow;
            BooksTabButton.Image = Properties.Resources.Books;
            BorrowersTabButton.Image = Properties.Resources.Borrowers;
            TransactionTabButton.Image = Properties.Resources.Transactions;
            SettingsTabButton.Image = Properties.Resources.Settings;
            AboutTabButton.Image =Properties.Resources.About;
        }

        // sliding panel code

        bool isSlidingPanelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;
        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                // retract panel
                retractSlidingPanelGUI();
            }
            SlidingPanel_Timer.Start();
        }

        private void Sliding_Panel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                // retract panel
                SlidingPanel.Width -= 30;
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    isSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                // expand panel
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    isSlidingPanelExpanded = true;
                    SlidingPanel_Timer.Stop();
                    expandSlidingPanelGUI();
                    this.Refresh();
                }
            }
        }

        private void BooksTabButton_Click(object sender, EventArgs e)
        {

        }
    }
}
