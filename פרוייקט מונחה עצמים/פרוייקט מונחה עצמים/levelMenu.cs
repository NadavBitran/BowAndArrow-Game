using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace פרוייקט_מונחה_עצמים
{
    public partial class levelMenu : Form
    {
        public levelMenu()
        {
            InitializeComponent();
        }
        Label[] levellabels;
        private void levelMenu_Load(object sender, EventArgs e)
        {
            // Screen Adjustments
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // Main Label adjustments
            this.levelLabel.Text = "Choose Your Level!";
            // GoBackButton adjustments
            this.GoBackButton.Text = "<-- BACK";
            // GoNextButton adjustments
            this.GoNextButton.Text = "NEXT -->";
            // Level Labels adjustments
            levellabels = new Label[13];
            SetLabels();
            LoadFirstPage();
            // Welcome Label
            this.WelcomeLabel.Text = "Hello " + player.name + "!";

        }
        // GoBackButton Functions
        private void GoBackButton_MouseHover(object sender, EventArgs e)
        {
            this.GoBackButton.BackColor = Color.Red;
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            if (this.levellabels[1].Visible == true)
            {
                this.Close();
            }
            else
            {
                LoadFirstPage();
                this.GoNextButton.Visible = true;
                this.GoNextButton.Enabled = true;
            }
        }
        private void GoBackButton_MouseLeave(object sender, EventArgs e)
        {
            this.GoBackButton.BackColor = Color.White;
        }

        private void GoNextButton_MouseHover(object sender, EventArgs e)
        {
            this.GoNextButton.BackColor = Color.Red;
        }

        private void GoNextButton_MouseLeave(object sender, EventArgs e)
        {
            this.GoNextButton.BackColor = Color.White;
        }
        private void GoNextButton_MouseClick(object sender, MouseEventArgs e)
        {
            LoadSecondPage();
            this.GoNextButton.Visible = false;
            this.GoNextButton.Enabled = false;
        }
        // Additional Functions
        private void SetLabels()
        {
            int upperLeftX = 80;
            int upperLeftY = 200;
            int xGap = 320;
            int yGap = 153;
            Size labelSize = new Size(100, 30);
            // Deafult Adjustments
            levellabels[0] = null;
            for(int i=1;i<levellabels.Length;i++)
            {
                levellabels[i] = new Label();
                levellabels[i].Name = i + "";
                levellabels[i].Text = "Level " + i;
                levellabels[i].Font = new Font("Snap ITC", 10);
                levellabels[i].Enabled = false;
                levellabels[i].Visible = false;
                levellabels[i].ForeColor = Color.Gray;
                levellabels[i].Location = new Point(upperLeftX + xGap * ((i - 1) % 3), upperLeftY + (yGap * (((i - 1) / 3) % 2)));
                levellabels[i].Size = labelSize;
                levellabels[i].Click += new EventHandler(this.labelClick);
            }
            // Adjusting the colors/enable clicking option duo to the player level
            for(int i=1;i<player.level;i++)
            {
                levellabels[i].ForeColor = Color.Green;
                levellabels[i].Enabled = true;
            }
            levellabels[player.level].ForeColor = Color.Red;
            levellabels[player.level].Enabled = true;
            // Adding all the labels into the form
            for(int i=1;i<levellabels.Length;i++)
            {
                this.Controls.Add(levellabels[i]);
            }
        }
        // EVENT HANDLER FOR ALL OF THE DYNAMIC ALLOCATED LABELS
        private void labelClick(object sender,EventArgs e)
        {
            gameInProgress g;
            int level;
            int length = ((Label)sender).Name.Length;
            string labelName = ((Label)sender).Name;
            if (length == 1)
            {
                level = (int)(labelName[0] - '0');
                g = new gameInProgress(level);
            }
            else
            {
                level = (int)(labelName[0] - '0') * 10 + (int)(labelName[1] - '0');
                g = new gameInProgress(level);
            }
            this.Hide();
            g.ShowDialog();
            LevelUp();
            this.Show();
        }
        private void LevelUp()
        {
            if (player.level == 1) return;
            levellabels[player.level - 1].ForeColor = Color.Green;
            levellabels[player.level].Enabled = true;
            levellabels[player.level].ForeColor = Color.Red;
        }
        // Functions For Loading First And Second Pages
        private void LoadFirstPage()
        {
            int i;
            for(i=1;i<=6;i++)
            {
                levellabels[i].Visible = true;
            }
            for(i=7;i<levellabels.Length;i++)
            {
                levellabels[i].Visible = false;
            }
        }
        private void LoadSecondPage()
        {
            int i;
            for (i = 1; i <= 6; i++)
            {
                levellabels[i].Visible = false;
            }
            for(i=7;i<levellabels.Length;i++)
            {
                levellabels[i].Visible = true;
            }
        }
    }
}
