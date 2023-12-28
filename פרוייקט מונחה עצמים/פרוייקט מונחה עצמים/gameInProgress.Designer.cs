
namespace פרוייקט_מונחה_עצמים
{
    partial class gameInProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyLeftLabel = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.countDownLabel = new System.Windows.Forms.Label();
            this.LevelFinishedLabel = new System.Windows.Forms.Label();
            this.FullStar1 = new System.Windows.Forms.PictureBox();
            this.FullStar2 = new System.Windows.Forms.PictureBox();
            this.FullStar3 = new System.Windows.Forms.PictureBox();
            this.SaveAndExitButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FullStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullStar3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // enemyLeftLabel
            // 
            this.enemyLeftLabel.AutoSize = true;
            this.enemyLeftLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enemyLeftLabel.Location = new System.Drawing.Point(13, 13);
            this.enemyLeftLabel.Name = "enemyLeftLabel";
            this.enemyLeftLabel.Size = new System.Drawing.Size(82, 27);
            this.enemyLeftLabel.TabIndex = 0;
            this.enemyLeftLabel.Text = "label1";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // countDownLabel
            // 
            this.countDownLabel.AutoSize = true;
            this.countDownLabel.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countDownLabel.Location = new System.Drawing.Point(17, 66);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(78, 26);
            this.countDownLabel.TabIndex = 1;
            this.countDownLabel.Text = "label1";
            // 
            // LevelFinishedLabel
            // 
            this.LevelFinishedLabel.AutoSize = true;
            this.LevelFinishedLabel.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LevelFinishedLabel.Location = new System.Drawing.Point(203, 13);
            this.LevelFinishedLabel.Name = "LevelFinishedLabel";
            this.LevelFinishedLabel.Size = new System.Drawing.Size(246, 79);
            this.LevelFinishedLabel.TabIndex = 2;
            this.LevelFinishedLabel.Text = "label1";
            // 
            // FullStar1
            // 
            this.FullStar1.Image = global::פרוייקט_מונחה_עצמים.Properties.Resources.FullStar;
            this.FullStar1.Location = new System.Drawing.Point(230, 106);
            this.FullStar1.Name = "FullStar1";
            this.FullStar1.Size = new System.Drawing.Size(94, 95);
            this.FullStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FullStar1.TabIndex = 3;
            this.FullStar1.TabStop = false;
            // 
            // FullStar2
            // 
            this.FullStar2.Image = global::פרוייקט_מונחה_עצמים.Properties.Resources.FullStar1;
            this.FullStar2.Location = new System.Drawing.Point(330, 120);
            this.FullStar2.Name = "FullStar2";
            this.FullStar2.Size = new System.Drawing.Size(94, 95);
            this.FullStar2.TabIndex = 4;
            this.FullStar2.TabStop = false;
            // 
            // FullStar3
            // 
            this.FullStar3.Image = global::פרוייקט_מונחה_עצמים.Properties.Resources.FullStar2;
            this.FullStar3.Location = new System.Drawing.Point(429, 120);
            this.FullStar3.Name = "FullStar3";
            this.FullStar3.Size = new System.Drawing.Size(94, 95);
            this.FullStar3.TabIndex = 5;
            this.FullStar3.TabStop = false;
            // 
            // SaveAndExitButton
            // 
            this.SaveAndExitButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveAndExitButton.Location = new System.Drawing.Point(231, 187);
            this.SaveAndExitButton.Name = "SaveAndExitButton";
            this.SaveAndExitButton.Size = new System.Drawing.Size(278, 98);
            this.SaveAndExitButton.TabIndex = 7;
            this.SaveAndExitButton.Text = "Save And Exit";
            this.SaveAndExitButton.UseVisualStyleBackColor = true;
            this.SaveAndExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveAndExitButton_MouseClick);
            this.SaveAndExitButton.MouseLeave += new System.EventHandler(this.SaveAndExitButton_MouseLeave);
            this.SaveAndExitButton.MouseHover += new System.EventHandler(this.SaveAndExitButton_MouseHover);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBackButton.Location = new System.Drawing.Point(-4, 422);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(159, 60);
            this.GoBackButton.TabIndex = 8;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            this.GoBackButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GoBackButton_MouseClick);
            this.GoBackButton.MouseLeave += new System.EventHandler(this.GoBackButton_MouseLeave);
            this.GoBackButton.MouseHover += new System.EventHandler(this.GoBackButton_MouseHover);
            // 
            // gameInProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 481);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.SaveAndExitButton);
            this.Controls.Add(this.FullStar3);
            this.Controls.Add(this.FullStar2);
            this.Controls.Add(this.FullStar1);
            this.Controls.Add(this.LevelFinishedLabel);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.enemyLeftLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gameInProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gameInProgress";
            this.Load += new System.EventHandler(this.gameInProgress_Load);
            this.SizeChanged += new System.EventHandler(this.gameInProgress_SizeChanged);
            this.Click += new System.EventHandler(this.gameInProgress_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameInProgress_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameInProgress_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameInProgress_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.FullStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullStar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label enemyLeftLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Label LevelFinishedLabel;
        private System.Windows.Forms.PictureBox FullStar1;
        private System.Windows.Forms.PictureBox FullStar2;
        private System.Windows.Forms.PictureBox FullStar3;
        private System.Windows.Forms.Button SaveAndExitButton;
        private System.Windows.Forms.Button GoBackButton;
    }
}