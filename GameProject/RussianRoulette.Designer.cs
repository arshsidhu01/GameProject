namespace GameProject
{
    partial class RussianRoulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RussianRoulette));
            this.btnBulleteLoad = new System.Windows.Forms.Button();
            this.btnChamber = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.btnPlatStart = new System.Windows.Forms.Button();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBoxGun = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeadInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBulleteLoad
            // 
            this.btnBulleteLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBulleteLoad.BackgroundImage")));
            this.btnBulleteLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulleteLoad.Image = global::GameProject.Properties.Resources.icons8_bullet_50;
            this.btnBulleteLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBulleteLoad.Location = new System.Drawing.Point(517, 175);
            this.btnBulleteLoad.Name = "btnBulleteLoad";
            this.btnBulleteLoad.Size = new System.Drawing.Size(176, 64);
            this.btnBulleteLoad.TabIndex = 0;
            this.btnBulleteLoad.Text = "Load Bullet";
            this.btnBulleteLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBulleteLoad.UseVisualStyleBackColor = true;
            this.btnBulleteLoad.Click += new System.EventHandler(this.btnBulleteLoad_Click);
            // 
            // btnChamber
            // 
            this.btnChamber.BackgroundImage = global::GameProject.Properties.Resources._1;
            this.btnChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamber.Image = global::GameProject.Properties.Resources.chamber;
            this.btnChamber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamber.Location = new System.Drawing.Point(517, 254);
            this.btnChamber.Name = "btnChamber";
            this.btnChamber.Size = new System.Drawing.Size(176, 64);
            this.btnChamber.TabIndex = 1;
            this.btnChamber.Text = "Spin Chamber";
            this.btnChamber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChamber.UseVisualStyleBackColor = true;
            this.btnChamber.Click += new System.EventHandler(this.btnChamber_Click);
            // 
            // btnShot
            // 
            this.btnShot.BackgroundImage = global::GameProject.Properties.Resources._1;
            this.btnShot.Enabled = false;
            this.btnShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShot.ForeColor = System.Drawing.Color.Red;
            this.btnShot.Location = new System.Drawing.Point(344, 256);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(122, 36);
            this.btnShot.TabIndex = 2;
            this.btnShot.Text = "Gun Fire";
            this.btnShot.UseVisualStyleBackColor = true;
            this.btnShot.Click += new System.EventHandler(this.btnShot_Click);
            // 
            // btnPlatStart
            // 
            this.btnPlatStart.BackgroundImage = global::GameProject.Properties.Resources._1;
            this.btnPlatStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatStart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPlatStart.Image = global::GameProject.Properties.Resources.update_arrows;
            this.btnPlatStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlatStart.Location = new System.Drawing.Point(344, 321);
            this.btnPlatStart.Name = "btnPlatStart";
            this.btnPlatStart.Size = new System.Drawing.Size(122, 40);
            this.btnPlatStart.TabIndex = 3;
            this.btnPlatStart.Text = "Play Agian";
            this.btnPlatStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlatStart.UseVisualStyleBackColor = true;
            this.btnPlatStart.Click += new System.EventHandler(this.btnPlatStart_Click);
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.BackColor = System.Drawing.Color.Transparent;
            this.lblGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameResult.ForeColor = System.Drawing.Color.Red;
            this.lblGameResult.Location = new System.Drawing.Point(362, 103);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(132, 26);
            this.lblGameResult.TabIndex = 4;
            this.lblGameResult.Text = "Load Bullet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Win/Lose :";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.BackColor = System.Drawing.Color.Transparent;
            this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.Location = new System.Drawing.Point(612, 144);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(34, 20);
            this.lblWinLose.TabIndex = 6;
            this.lblWinLose.Text = "0/0";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::GameProject.Properties.Resources._1;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::GameProject.Properties.Resources.sign_in__1_1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(604, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxGun
            // 
            this.pictureBoxGun.Image = global::GameProject.Properties.Resources.chamber;
            this.pictureBoxGun.Location = new System.Drawing.Point(344, 175);
            this.pictureBoxGun.Name = "pictureBoxGun";
            this.pictureBoxGun.Size = new System.Drawing.Size(122, 75);
            this.pictureBoxGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGun.TabIndex = 8;
            this.pictureBoxGun.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameProject.Properties.Resources.manPic;
            this.pictureBox1.Location = new System.Drawing.Point(176, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblDeadInfo
            // 
            this.lblDeadInfo.AutoSize = true;
            this.lblDeadInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDeadInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadInfo.ForeColor = System.Drawing.Color.Red;
            this.lblDeadInfo.Location = new System.Drawing.Point(171, 374);
            this.lblDeadInfo.Name = "lblDeadInfo";
            this.lblDeadInfo.Size = new System.Drawing.Size(0, 26);
            this.lblDeadInfo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(198, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Russian Roulette Game";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GameProject.Properties.Resources._11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 49);
            this.panel1.TabIndex = 12;
            // 
            // RussianRoulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDeadInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxGun);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.btnPlatStart);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.btnChamber);
            this.Controls.Add(this.btnBulleteLoad);
            this.DoubleBuffered = true;
            this.Name = "RussianRoulette";
            this.Text = "RussianRoulette";
            this.Load += new System.EventHandler(this.RussianRoulette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBulleteLoad;
        private System.Windows.Forms.Button btnChamber;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnPlatStart;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBoxGun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDeadInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}