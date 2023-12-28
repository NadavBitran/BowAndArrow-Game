
namespace פרוייקט_מונחה_עצמים
{
    partial class gameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameMenu));
            this.Exitbutton = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.EnterYourNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.GiveUpButton = new System.Windows.Forms.Button();
            this.ContinueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.Image = ((System.Drawing.Image)(resources.GetObject("Exitbutton.Image")));
            this.Exitbutton.Location = new System.Drawing.Point(-9, 370);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(112, 121);
            this.Exitbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Exitbutton.TabIndex = 1;
            this.Exitbutton.TabStop = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            this.Exitbutton.MouseLeave += new System.EventHandler(this.Exitbutton_MouseLeave);
            this.Exitbutton.MouseHover += new System.EventHandler(this.Exitbutton_MouseHover);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(249, 10);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(269, 84);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
            this.StartButton.MouseHover += new System.EventHandler(this.StartButton_MouseHover);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Showcard Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(249, 162);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(269, 84);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // EnterYourNameLabel
            // 
            this.EnterYourNameLabel.AutoSize = true;
            this.EnterYourNameLabel.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterYourNameLabel.Location = new System.Drawing.Point(159, 124);
            this.EnterYourNameLabel.Name = "EnterYourNameLabel";
            this.EnterYourNameLabel.Size = new System.Drawing.Size(136, 44);
            this.EnterYourNameLabel.TabIndex = 4;
            this.EnterYourNameLabel.Text = "label1";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(299, 200);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(156, 37);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Showcard Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadButton.Location = new System.Drawing.Point(249, 314);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(269, 84);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            this.LoadButton.MouseLeave += new System.EventHandler(this.LoadButton_MouseLeave);
            this.LoadButton.MouseHover += new System.EventHandler(this.LoadButton_MouseHover);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Showcard Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueButton.Location = new System.Drawing.Point(427, 176);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(330, 100);
            this.ContinueButton.TabIndex = 7;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContinueButton_MouseClick);
            // 
            // GiveUpButton
            // 
            this.GiveUpButton.Font = new System.Drawing.Font("Showcard Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GiveUpButton.Location = new System.Drawing.Point(25, 176);
            this.GiveUpButton.Name = "GiveUpButton";
            this.GiveUpButton.Size = new System.Drawing.Size(330, 100);
            this.GiveUpButton.TabIndex = 8;
            this.GiveUpButton.Text = "Give Up";
            this.GiveUpButton.UseVisualStyleBackColor = true;
            this.GiveUpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GiveUpButton_MouseClick);
            // 
            // ContinueLabel
            // 
            this.ContinueLabel.AutoSize = true;
            this.ContinueLabel.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueLabel.Location = new System.Drawing.Point(25, 124);
            this.ContinueLabel.Name = "ContinueLabel";
            this.ContinueLabel.Size = new System.Drawing.Size(73, 25);
            this.ContinueLabel.TabIndex = 9;
            this.ContinueLabel.Text = "label1";
            // 
            // gameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(814, 481);
            this.Controls.Add(this.ContinueLabel);
            this.Controls.Add(this.GiveUpButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EnterYourNameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gameMenu";
            this.Load += new System.EventHandler(this.gameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exitbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Exitbutton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label EnterYourNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button GiveUpButton;
        private System.Windows.Forms.Label ContinueLabel;
    }
}