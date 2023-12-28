
namespace פרוייקט_מונחה_עצמים
{
    partial class loadingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redBall = new System.Windows.Forms.PictureBox();
            this.yellowBall = new System.Windows.Forms.PictureBox();
            this.greenBall = new System.Windows.Forms.PictureBox();
            this.loadLabel = new System.Windows.Forms.Label();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressBartimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::פרוייקט_מונחה_עצמים.Properties.Resources.bow___Copy1;
            this.pictureBox1.Location = new System.Drawing.Point(184, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // redBall
            // 
            this.redBall.Image = global::פרוייקט_מונחה_עצמים.Properties.Resources.Ball1;
            this.redBall.Location = new System.Drawing.Point(365, 94);
            this.redBall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.redBall.Name = "redBall";
            this.redBall.Size = new System.Drawing.Size(126, 127);
            this.redBall.TabIndex = 1;
            this.redBall.TabStop = false;
            // 
            // yellowBall
            // 
            this.yellowBall.Image = global::פרוייקט_מונחה_עצמים.Properties.Resources.Ball2;
            this.yellowBall.Location = new System.Drawing.Point(416, -3);
            this.yellowBall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yellowBall.Name = "yellowBall";
            this.yellowBall.Size = new System.Drawing.Size(106, 115);
            this.yellowBall.TabIndex = 2;
            this.yellowBall.TabStop = false;
            // 
            // greenBall
            // 
            this.greenBall.Image = global::פרוייקט_מונחה_עצמים.Properties.Resources.Ball3;
            this.greenBall.Location = new System.Drawing.Point(480, 94);
            this.greenBall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.greenBall.Name = "greenBall";
            this.greenBall.Size = new System.Drawing.Size(104, 123);
            this.greenBall.TabIndex = 3;
            this.greenBall.TabStop = false;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadLabel.ForeColor = System.Drawing.Color.White;
            this.loadLabel.Location = new System.Drawing.Point(290, 242);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(181, 59);
            this.loadLabel.TabIndex = 4;
            this.loadLabel.Text = "label1";
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Location = new System.Drawing.Point(121, 344);
            this.loadingProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.Size = new System.Drawing.Size(545, 21);
            this.loadingProgressBar.TabIndex = 5;
            // 
            // progressBartimer
            // 
            this.progressBartimer.Tick += new System.EventHandler(this.progressBartimer_Tick);
            // 
            // loadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(822, 453);
            this.Controls.Add(this.loadingProgressBar);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.greenBall);
            this.Controls.Add(this.yellowBall);
            this.Controls.Add(this.redBall);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadingForm";
            this.Load += new System.EventHandler(this.loadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox redBall;
        private System.Windows.Forms.PictureBox yellowBall;
        private System.Windows.Forms.PictureBox greenBall;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Timer progressBartimer;
    }
}

