using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace פרוייקט_מונחה_עצמים
{
    public partial class loadingForm : Form
    {
        public loadingForm()
        {
            InitializeComponent();
        }
        // Happends When The Form Loading
        private void loadingForm_Load(object sender, EventArgs e)
        {
            // Screen Adjustments
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            // Label Adjustments
            this.loadLabel.ForeColor = Color.White;
            this.loadLabel.Text = "Please Wait...";
            // Progress Bar + Timer Adjustments
            this.progressBartimer.Interval = 50;
            this.progressBartimer.Start();
            this.loadingProgressBar.Maximum = 100;
        }
        // Happends Every Tick Of The Timer (every 50 Miliseconds)
        private void progressBartimer_Tick(object sender, EventArgs e)
        {
            this.loadingProgressBar.Value++;
            if(this.loadingProgressBar.Value==this.loadingProgressBar.Maximum)
            {
                this.progressBartimer.Stop();
                this.Hide();
                gameMenu menu = new gameMenu();
                menu.ShowDialog();
            }
        }
    }
}
