using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using WMPLib;
using static System.Windows.Media.MediaPlayer;
namespace פרוייקט_מונחה_עצמים
{
    public partial class gameMenu : Form
    {
        private WindowsMediaPlayer song;
        public gameMenu()
        {
            InitializeComponent();
        }
        string fileName;
        private void gameMenu_Load(object sender, EventArgs e)
        {
            // Screen adjustments
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // Start Button adjustments
            this.StartButton.Enabled = true;
            this.StartButton.BackColor = Color.White;
            // Label/TestBox adjustments
            this.EnterYourNameLabel.Visible = false;
            this.EnterYourNameLabel.Text = "Please Enter Your Name: ";
            this.NameTextBox.Visible = false;
            // Continue Menu Adjustments
            this.GiveUpButton.Visible = false;
            this.ContinueButton.Visible = false;
            this.ContinueLabel.Visible = false;
            song = new WindowsMediaPlayer();
            song.settings.volume = 1;
            song.settings.setMode("loop", true);
            string songPath = System.IO.Path.Combine(Application.StartupPath, "GameSong.wav");
            song.URL = songPath;
            song.controls.play();
        }
        // Exit Button Functions
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Exitbutton_MouseHover(object sender, EventArgs e)
        {
            this.Exitbutton.Image = Image.FromFile("ClickedExitButton.png");
        }
        private void Exitbutton_MouseLeave(object sender, EventArgs e)
        {
            this.Exitbutton.Image = Image.FromFile("RegulerExitButton.png");
        }
        // Start Button Functions
        private void StartButton_MouseHover(object sender, EventArgs e)
        {
            this.StartButton.ForeColor = Color.Red;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            this.StartButton.ForeColor = Color.Black;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(player.name == " ") // Player needs to give his name for first time
            {
                this.StartButton.Visible = false;
                this.Exitbutton.Visible = false;
                this.saveButton.Visible = false;
                this.LoadButton.Visible = false;
                this.EnterYourNameLabel.Visible = true;
                this.NameTextBox.Visible = true;
            }
            else
            {
                this.Hide();
                levelMenu lvlmenu = new levelMenu();
                lvlmenu.ShowDialog();
                this.Show();
            }
        }


        // TestBox Functions
        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Hide();
                player.name = this.NameTextBox.Text;
                levelMenu lvlmenu = new levelMenu();
                lvlmenu.ShowDialog();
                // When the user coming back
                this.NameTextBox.Visible = false;
                this.EnterYourNameLabel.Visible = false;
                this.StartButton.Visible = true;
                this.Exitbutton.Visible = true;
                this.saveButton.Visible = true;
                this.LoadButton.Visible = true;
                this.Show();
            }
        }
        // Save Button Function
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog p = new SaveFileDialog();
            p.InitialDirectory = Directory.GetCurrentDirectory() + "\\gs";
            if(p.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream s = new FileStream(p.FileName, FileMode.Create, FileAccess.Write);
                formatter.Serialize(s, player.name);
                formatter.Serialize(s, player.level);
                formatter.Serialize(s, player.middleGameExit);
                formatter.Serialize(s, player.levelOfmiddleGameExit);
                s.Close();
            }
            
        }

        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            saveButton.ForeColor = Color.Red;
        }
        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.ForeColor = Color.Black;
        }
        // Load Button Functions
        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog p = new OpenFileDialog();
            p.InitialDirectory = Directory.GetCurrentDirectory();
            if(p.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream s = new FileStream(p.FileName, FileMode.Open);
                player.name = (string)formatter.Deserialize(s);
                player.level = (int)formatter.Deserialize(s);
                player.middleGameExit = (bool)formatter.Deserialize(s);
                player.levelOfmiddleGameExit = (int)formatter.Deserialize(s);
                s.Close();
                if (player.middleGameExit == true)
                {
                    this.ContinueLabel.Text = "You left in the middle of level " + player.levelOfmiddleGameExit + ", do you want to come back?";
                    this.fileName = p.FileName;
                    showMiddleGameExitMenu();
                }
            }
        }
        private void LoadButton_MouseHover(object sender, EventArgs e)
        {
            LoadButton.ForeColor = Color.Red;
        }
        private void LoadButton_MouseLeave(object sender, EventArgs e)
        {
            LoadButton.ForeColor = Color.Black;
        }

        private void GiveUpButton_MouseClick(object sender, MouseEventArgs e)
        {
            showMainMenu();
        }

        private void ContinueButton_MouseClick(object sender, MouseEventArgs e)
        {
            gameInProgress g = new gameInProgress(fileName);
            g.ShowDialog();
            levelMenu l = new levelMenu();
            l.ShowDialog();
            showMainMenu();
        }
        // Middle Of The Game Exit Menu
        private void showMiddleGameExitMenu()
        {
            this.ContinueLabel.Visible = true;
            this.ContinueButton.Visible = true;
            this.GiveUpButton.Visible = true;
            this.LoadButton.Visible = false;
            this.saveButton.Visible = false;
            this.Exitbutton.Visible = false;
            this.StartButton.Visible = false;
        }
        // Reguler Main Menu
        private void showMainMenu()
        {
            this.ContinueLabel.Visible = false;
            this.ContinueButton.Visible = false;
            this.GiveUpButton.Visible = false;
            this.LoadButton.Visible = true;
            this.saveButton.Visible = true;
            this.Exitbutton.Visible = true;
            this.StartButton.Visible = true;
        }
    }
}
