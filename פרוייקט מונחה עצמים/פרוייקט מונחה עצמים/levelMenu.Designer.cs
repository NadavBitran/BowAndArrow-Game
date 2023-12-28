
namespace פרוייקט_מונחה_עצמים
{
    partial class levelMenu
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
            this.levelLabel = new System.Windows.Forms.Label();
            this.Level2Label = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.GoNextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelLabel.Location = new System.Drawing.Point(256, 34);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(144, 46);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "label1";
            // 
            // Level2Label
            // 
            this.Level2Label.Location = new System.Drawing.Point(0, 0);
            this.Level2Label.Name = "Level2Label";
            this.Level2Label.Size = new System.Drawing.Size(100, 23);
            this.Level2Label.TabIndex = 13;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBackButton.Location = new System.Drawing.Point(0, 421);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(158, 52);
            this.GoBackButton.TabIndex = 7;
            this.GoBackButton.Text = "button1";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            this.GoBackButton.MouseLeave += new System.EventHandler(this.GoBackButton_MouseLeave);
            this.GoBackButton.MouseHover += new System.EventHandler(this.GoBackButton_MouseHover);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 13);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(104, 33);
            this.WelcomeLabel.TabIndex = 12;
            this.WelcomeLabel.Text = "label1";
            // 
            // GoNextButton
            // 
            this.GoNextButton.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoNextButton.Location = new System.Drawing.Point(655, 421);
            this.GoNextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GoNextButton.Name = "GoNextButton";
            this.GoNextButton.Size = new System.Drawing.Size(158, 52);
            this.GoNextButton.TabIndex = 14;
            this.GoNextButton.Text = "button1";
            this.GoNextButton.UseVisualStyleBackColor = true;
            this.GoNextButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GoNextButton_MouseClick);
            this.GoNextButton.MouseLeave += new System.EventHandler(this.GoNextButton_MouseLeave);
            this.GoNextButton.MouseHover += new System.EventHandler(this.GoNextButton_MouseHover);
            // 
            // levelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 481);
            this.Controls.Add(this.GoNextButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.Level2Label);
            this.Controls.Add(this.levelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "levelMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "levelMenu";
            this.Load += new System.EventHandler(this.levelMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label Level2Label;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button GoNextButton;
    }
}