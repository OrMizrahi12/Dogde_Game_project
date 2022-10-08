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
            this.player = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLive
            // 
            this.txtLive.AutoSize = true;
            this.txtLive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
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
            this.txtKills.Location = new System.Drawing.Point(265, 9);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(78, 25);
            this.txtKills.TabIndex = 2;
            this.txtKills.Text = "Kills: 0";
            // 
            // HealthProgress
            // 
            this.HealthProgress.Location = new System.Drawing.Point(643, 11);
            this.HealthProgress.Name = "HealthProgress";
            this.HealthProgress.Size = new System.Drawing.Size(124, 23);
            this.HealthProgress.TabIndex = 3;
            this.HealthProgress.Value = 100;
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHealth.Location = new System.Drawing.Point(563, 9);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(74, 25);
            this.txtHealth.TabIndex = 4;
            this.txtHealth.Text = "Health";
            // 
            // player
            // 
            this.player.ErrorImage = global::DogdeGame.Properties.Resources.playerLeft;
            this.player.Image = global::DogdeGame.Properties.Resources.playerLeft;
            this.player.Location = new System.Drawing.Point(120, 236);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(171, 104);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.HealthProgress);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtLive);
            this.Name = "Form1";
            this.Text = "Dogde";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLive;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.ProgressBar HealthProgress;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
    }
}

