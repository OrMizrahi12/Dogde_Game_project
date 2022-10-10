namespace DogdeGame
{
    partial class Form1
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
            this.txtLive = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.HealthProgress = new System.Windows.Forms.ProgressBar();
            this.txtHealth = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.resetGameImg = new System.Windows.Forms.PictureBox();
            this.playerAnimation = new System.Windows.Forms.PictureBox();
            this.freezOrRunMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resetGameImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLive
            // 
            this.txtLive.AutoSize = true;
            this.txtLive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLive.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLive.Location = new System.Drawing.Point(12, 9);
            this.txtLive.Name = "txtLive";
            this.txtLive.Size = new System.Drawing.Size(104, 25);
            this.txtLive.TabIndex = 1;
            this.txtLive.Text = "Ammo: 0 ";
            // 
            // txtKills
            // 
            this.txtKills.AutoSize = true;
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKills.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtKills.Location = new System.Drawing.Point(138, 9);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(78, 25);
            this.txtKills.TabIndex = 2;
            this.txtKills.Text = "Kills: 0";
            // 
            // HealthProgress
            // 
            this.HealthProgress.Location = new System.Drawing.Point(320, 11);
            this.HealthProgress.Name = "HealthProgress";
            this.HealthProgress.Size = new System.Drawing.Size(124, 23);
            this.HealthProgress.TabIndex = 3;
            this.HealthProgress.Value = 100;
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHealth.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHealth.Location = new System.Drawing.Point(240, 9);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(74, 25);
            this.txtHealth.TabIndex = 4;
            this.txtHealth.Text = "Health";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // resetGameImg
            // 
            this.resetGameImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resetGameImg.Image = global::DogdeGame.Properties.Resources.startGameImg;
            this.resetGameImg.Location = new System.Drawing.Point(119, 187);
            this.resetGameImg.Margin = new System.Windows.Forms.Padding(0);
            this.resetGameImg.Name = "resetGameImg";
            this.resetGameImg.Size = new System.Drawing.Size(784, 329);
            this.resetGameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resetGameImg.TabIndex = 6;
            this.resetGameImg.TabStop = false;
            this.resetGameImg.Visible = false;
            // 
            // playerAnimation
            // 
            this.playerAnimation.ErrorImage = global::DogdeGame.Properties.Resources.playerLeft;
            this.playerAnimation.Image = global::DogdeGame.Properties.Resources.playerLeft;
            this.playerAnimation.Location = new System.Drawing.Point(407, 533);
            this.playerAnimation.Name = "playerAnimation";
            this.playerAnimation.Size = new System.Drawing.Size(169, 122);
            this.playerAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerAnimation.TabIndex = 5;
            this.playerAnimation.TabStop = false;
            // 
            // freezOrRunMsg
            // 
            this.freezOrRunMsg.AutoSize = true;
            this.freezOrRunMsg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.freezOrRunMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.freezOrRunMsg.ForeColor = System.Drawing.SystemColors.Control;
            this.freezOrRunMsg.Location = new System.Drawing.Point(12, 45);
            this.freezOrRunMsg.Name = "freezOrRunMsg";
            this.freezOrRunMsg.Size = new System.Drawing.Size(0, 25);
            this.freezOrRunMsg.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(991, 703);
            this.Controls.Add(this.freezOrRunMsg);
            this.Controls.Add(this.resetGameImg);
            this.Controls.Add(this.playerAnimation);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.HealthProgress);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtLive);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.resetGameImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLive;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.ProgressBar HealthProgress;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.PictureBox playerAnimation;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox resetGameImg;
        private System.Windows.Forms.Label freezOrRunMsg;
    }
}

