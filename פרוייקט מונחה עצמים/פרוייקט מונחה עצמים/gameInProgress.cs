using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using WMPLib;
namespace פרוייקט_מונחה_עצמים
{
    public enum creatureTypes
    {
        Red,
        Yellow,
        Green,
        Purple,
        Black,
    }
    public partial class gameInProgress : Form
    {
        //                   x   y
        // Size Of Window : 816x489
        // BackGround Materials
        Size[] background_Sizes;
        Point[] background_Points;
        Pen p;
        SolidBrush sky;
        SolidBrush grass;
        // Player
        player me;
        // Creatures
        creaturelist lst;
        // Other
        int timeleft = 30;
        int enemysleft;
        int currLevel;
        bool pauseMode;
        Keys curr_key;
        private WindowsMediaPlayer arrowSound;
        public gameInProgress()
        {
            InitializeComponent();
        }
        public gameInProgress(int level)
        {
            InitializeComponent();
            currLevel = level;
            me = new player();
            lst = new creaturelist();
            setGame();
            loadLevel(currLevel);
            this.enemyLeftLabel.Text = "Enemys Left: " + enemysleft;
            string songPath = System.IO.Path.Combine(Application.StartupPath, "ArrowSound.wav");
            arrowSound = new WindowsMediaPlayer();
            arrowSound.settings.autoStart = false;
            arrowSound.URL = songPath;
            arrowSound.settings.volume = 5;
        }
        public gameInProgress(string fileName)
        {
            InitializeComponent();
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(fileName, FileMode.Open);
            player.name = (string)formatter.Deserialize(s);
            player.level = (int)formatter.Deserialize(s);
            player.middleGameExit = (bool)formatter.Deserialize(s);
            player.levelOfmiddleGameExit = (int)formatter.Deserialize(s);
            lst = (creaturelist)formatter.Deserialize(s);
            me = (player)formatter.Deserialize(s);
            timeleft = (int)formatter.Deserialize(s);
            enemysleft = (int)formatter.Deserialize(s);
            currLevel = player.levelOfmiddleGameExit;
            s.Close();
            setGame();
            this.enemyLeftLabel.Text = "Enemys Left: " + enemysleft;
        }
        private void gameInProgress_Paint(object sender, PaintEventArgs e)
        {
            drawBackground(e.Graphics);
            lst.drawAll(e.Graphics);
            me.draw(e.Graphics);
        }
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            switch (curr_key)
            {
                case Keys.Right:
                    me.moveRight();
                    break;

                case Keys.Left:
                    me.moveLeft();
                    break;

                case Keys.Space:
                    if (me.IsShooting == false)
                    {
                        me.IsShooting = true;
                        arrowSound.controls.play();
                    }
                    break;
                case Keys.Escape:
                    if (this.GoBackButton.Visible == false)
                    {
                        mainTimer.Stop();
                        countdownTimer.Stop();
                        this.GoBackButton.Visible = true;
                        this.SaveAndExitButton.Visible = true;
                    }
                    else if (this.pauseMode == false)
                    {
                        mainTimer.Start();
                        countdownTimer.Start();
                        this.GoBackButton.Visible = false;
                        this.SaveAndExitButton.Visible = false;
                    }
                    break;
            }
            if (me.IsShooting == true)
            {
                int counter = lst.playerHitCheck(me.ArrowX, me.ArrowY, me.ArrowSize);
                this.enemysleft -= counter;
                this.enemyLeftLabel.Text = "Enemies Left " + this.enemysleft;
                me.shoot();
            }
            if (lst.greenCreatureHitCheck(me.CurrX, me.CurrY, me.BowSize) == true)
            {
                mainTimer.Stop();
                countdownTimer.Stop();
                showLostMenu();
            }
            
            lst.moveAll();
            Invalidate();
        }
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            this.countDownLabel.Text = "Time Left: " + --timeleft;
            if (timeleft == 0 || enemysleft == 0)
            {
                pauseMode = true;
                countdownTimer.Stop();
                mainTimer.Stop();
                if (enemysleft == 0)
                    showWinMenu();
                else showLostMenu(); // timeleft == 0
            }
            else if(timeleft<=5)
            {
                this.countDownLabel.ForeColor = Color.Red;
            }
            else if(timeleft<=15)
            {
                this.countDownLabel.ForeColor = Color.Orange;
            }

            // In Every 5 seconds, purple Creature will get smaller
            // And faster
            if (timeleft % 5 == 0)
            {
                this.lst.makePurpleSmaller();
            }
        }
        // Additoinal Functions:
        private void adjustBackground()
        { //  For Levels - 1 to 6
            // background_Points
            // [0] = upper left point of grass
            // [1] = upper left point of sky
            background_Points = new Point[2];
            background_Points[0] = new Point(0, this.Size.Height - 75);
            background_Points[1] = new Point(0, 0);
            // background_sizes
            // [0] = size of grass
            // [1] = size of sky
            background_Sizes = new Size[2];
            background_Sizes[0] = new Size(this.Size.Width, 75);
            background_Sizes[1] = new Size(this.Size.Width, this.Size.Height);
            // pen and brushes
            p = new Pen(Color.Black);
            sky = new SolidBrush(Color.Aqua);
            grass = new SolidBrush(Color.Green);
        }
        private void drawBackground(Graphics g)
        {
            // first: drawing sky
            g.FillRectangle(sky, new Rectangle(background_Points[1], background_Sizes[1]));
            // second: drawing grass
            g.FillRectangle(grass, new Rectangle(background_Points[0], background_Sizes[0]));
            g.DrawRectangle(p, new Rectangle(background_Points[0], background_Sizes[0]));
        }

        private void gameInProgress_KeyDown(object sender, KeyEventArgs e)
        {
            curr_key = e.KeyCode;
        }

        private void loadLevel(int lvl)
        {
            switch(lvl)
            {
                case 1:
                    lst.addCreatue(5, creatureTypes.Red);
                    enemysleft = 5;
                    break;
                case 2:
                    lst.addCreatue(5, creatureTypes.Red);
                    lst.addCreatue(2, creatureTypes.Yellow);
                    enemysleft = 7;
                    break;
                case 3:
                    lst.addCreatue(5, creatureTypes.Red);
                    lst.addCreatue(3, creatureTypes.Yellow);
                    lst.addCreatue(2, creatureTypes.Green);
                    enemysleft = 10;
                    break;
                case 4:
                    lst.addCreatue(5, creatureTypes.Red);
                    lst.addCreatue(5, creatureTypes.Yellow);
                    lst.addCreatue(3, creatureTypes.Green);
                    enemysleft = 13;
                    break;
                case 5:
                    lst.addCreatue(5, creatureTypes.Red);
                    lst.addCreatue(5, creatureTypes.Yellow);
                    lst.addCreatue(5, creatureTypes.Green);
                    enemysleft = 15;
                    break;
                case 6:
                    lst.addCreatue(7, creatureTypes.Green);
                    enemysleft = 7;
                    break;
                case 7: 
                    lst.addCreatue(5, creatureTypes.Purple);
                    enemysleft = 5;
                    break;
                case 8:
                    lst.addCreatue(4, creatureTypes.Purple);
                    lst.addCreatue(5, creatureTypes.Green);
                    lst.addCreatue(3, creatureTypes.Yellow);
                    lst.addCreatue(2, creatureTypes.Red);
                    enemysleft = 14;
                    break;
                case 9:
                    lst.addCreatue(3, creatureTypes.Black);
                    enemysleft = 3;
                    break;
                case 10:
                    lst.addCreatue(2, creatureTypes.Purple);
                    lst.addCreatue(4, creatureTypes.Black);
                    enemysleft = 6;
                    break;
                case 11:
                    lst.addCreatue(4, creatureTypes.Green);
                    lst.addCreatue(3, creatureTypes.Yellow);
                    lst.addCreatue(2, creatureTypes.Red);
                    lst.addCreatue(3, creatureTypes.Purple);
                    lst.addCreatue(2, creatureTypes.Black);
                    enemysleft = 14;
                    break;
                case 12:
                    lst.addCreatue(6, creatureTypes.Green);
                    lst.addCreatue(5, creatureTypes.Black);
                    lst.addCreatue(3, creatureTypes.Red);
                    lst.addCreatue(2, creatureTypes.Yellow);
                    enemysleft = 16;
                    timeleft = 45;
                    break;
                default:
                    lst.addCreatue(5, creatureTypes.Red);
                    enemysleft = 5;
                    break;
            }
        }
        private void showWinMenu()
        {
            this.LevelFinishedLabel.ForeColor = Color.Green;
            this.LevelFinishedLabel.Text = "You Won!";
            this.LevelFinishedLabel.Visible = true;
            this.FullStar1.Visible = true;
            this.FullStar2.Visible = true;
            this.FullStar3.Visible = true;
            if (this.countDownLabel.ForeColor == Color.Red)
            {
                this.FullStar2.Visible = false;
                this.FullStar3.Visible = false;
            }
            else if (this.countDownLabel.ForeColor == Color.Orange)
            {
                this.FullStar3.Visible = false;
            }
            this.GoBackButton.Visible = true;
        }
        private void showLostMenu()
        {
            this.LevelFinishedLabel.ForeColor = Color.Red;
            this.LevelFinishedLabel.Text = "You Lost!";
            this.LevelFinishedLabel.Visible = true;
            this.GoBackButton.Visible = true;
        }
        private void setGame()
        {
            // Screen adjustments
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            adjustBackground();
            // Timers adjustments
            this.mainTimer.Interval = 10;
            this.mainTimer.Start();
            this.countdownTimer.Interval = 1000; // 1 second
            this.countdownTimer.Start();
            // buttons adjustments and more
            this.GoBackButton.Visible = false;
            this.SaveAndExitButton.Visible = false;
            this.pauseMode = false;
            // Player and Creatures adjustments
            player.WindowSize = this.Size;
            creature.WindowSize = this.Size;
            // Label adjustments
            this.countDownLabel.Text = "Time Left: " + timeleft;
            this.countDownLabel.ForeColor = Color.Green;
            this.LevelFinishedLabel.Visible = false;
            this.LevelFinishedLabel.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Size.Height * 2);
            this.FullStar1.Visible = false;
            this.FullStar2.Visible = false;
            this.FullStar3.Visible = false;
            this.FullStar1.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Height);
            this.FullStar2.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width + this.FullStar1.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Height);
            this.FullStar3.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width + 2 * this.FullStar1.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Height);
        }
        private void gameInProgress_SizeChanged(object sender, EventArgs e)
        {
            // objects fix
            player.WindowSize = this.Size;
            creature.WindowSize = this.Size;
            if (this.lst != null)
            {
                this.lst.fixY(this.Size.Height - 75);
            }
            // background fix
            adjustBackground();
            // labels fix
            this.LevelFinishedLabel.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Size.Height*2);
            this.FullStar1.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width + 2 * this.FullStar1.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Height - 40);
            this.FullStar2.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width + this.FullStar1.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Height);
            this.FullStar3.Location = new Point(this.Size.Width / 2 - this.LevelFinishedLabel.Size.Width + 2 * this.FullStar1.Size.Width, this.Size.Height / 2 - this.LevelFinishedLabel.Height);
            // button fix
            this.GoBackButton.Location = new Point(1, this.Size.Height - this.GoBackButton.Size.Height*2);
            Invalidate();
        }
        // Button's Functions
        private void GoBackButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.enemysleft == 0 && this.currLevel == player.level)
            {
                player.level++;
                if (player.middleGameExit == true)
                {
                    player.middleGameExit = false;
                }
            }
            this.Close();
        }

        private void GoBackButton_MouseHover(object sender, EventArgs e)
        {
            this.GoBackButton.ForeColor = Color.Red;
        }

        private void GoBackButton_MouseLeave(object sender, EventArgs e)
        {
            this.GoBackButton.ForeColor = Color.Black;
        }

        private void gameInProgress_Load(object sender, EventArgs e)
        {

        }
        // Save And Exit Button Functions
        private void SaveAndExitButton_MouseHover(object sender, EventArgs e)
        {
            this.SaveAndExitButton.ForeColor = Color.Red;
        }

        private void SaveAndExitButton_MouseLeave(object sender, EventArgs e)
        {
            this.SaveAndExitButton.ForeColor = Color.Black;
        }
        private void SaveAndExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            player.middleGameExit = true;
            player.levelOfmiddleGameExit = this.currLevel;
            SaveFileDialog p = new SaveFileDialog();
            p.InitialDirectory = Directory.GetCurrentDirectory();
            if (p.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream s = new FileStream(p.FileName, FileMode.Create, FileAccess.Write);
                formatter.Serialize(s, player.name);
                formatter.Serialize(s, player.level);
                formatter.Serialize(s, player.middleGameExit);
                formatter.Serialize(s, player.levelOfmiddleGameExit);
                formatter.Serialize(s, this.lst);
                formatter.Serialize(s, this.me);
                formatter.Serialize(s, this.timeleft);
                formatter.Serialize(s, this.enemysleft);
                s.Close();
            }
            Application.Exit();
        }

        private void gameInProgress_KeyUp(object sender, KeyEventArgs e)
        {
            this.curr_key = Keys.None;
        }

        private void gameInProgress_Click(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
