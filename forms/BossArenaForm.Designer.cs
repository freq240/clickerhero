
namespace ClickerGame
{
    partial class BossArenaForm
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
            this.exitButton = new ClickerGame.RoundedButton();
            this.toBossRoom = new ClickerGame.RoundedButton();
            this.labelBossName = new System.Windows.Forms.Label();
            this.labelBossHP = new System.Windows.Forms.Label();
            this.labelBossStatLevel = new System.Windows.Forms.Label();
            this.labelBossStatHP = new System.Windows.Forms.Label();
            this.labelBossStatReduction = new System.Windows.Forms.Label();
            this.pictureBoxReductionIco = new System.Windows.Forms.PictureBox();
            this.pictureBoxHPico = new System.Windows.Forms.PictureBox();
            this.pictureBoxBoss = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReductionIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHPico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Crimson;
            this.exitButton.Location = new System.Drawing.Point(940, 15);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // toBossRoom
            // 
            this.toBossRoom.FlatAppearance.BorderSize = 5;
            this.toBossRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toBossRoom.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBossRoom.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toBossRoom.Location = new System.Drawing.Point(790, 585);
            this.toBossRoom.Name = "toBossRoom";
            this.toBossRoom.Size = new System.Drawing.Size(200, 78);
            this.toBossRoom.TabIndex = 21;
            this.toBossRoom.Text = "Ohhhh-noo! BACK!";
            this.toBossRoom.UseVisualStyleBackColor = true;
            this.toBossRoom.Click += new System.EventHandler(this.toBossRoom_Click);
            // 
            // labelBossName
            // 
            this.labelBossName.AutoSize = true;
            this.labelBossName.Font = new System.Drawing.Font("Ravie", 40F);
            this.labelBossName.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelBossName.Location = new System.Drawing.Point(294, 9);
            this.labelBossName.Name = "labelBossName";
            this.labelBossName.Size = new System.Drawing.Size(440, 73);
            this.labelBossName.TabIndex = 22;
            this.labelBossName.Text = "NAME BOSS";
            // 
            // labelBossHP
            // 
            this.labelBossHP.AutoSize = true;
            this.labelBossHP.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBossHP.ForeColor = System.Drawing.Color.Red;
            this.labelBossHP.Location = new System.Drawing.Point(416, 116);
            this.labelBossHP.Name = "labelBossHP";
            this.labelBossHP.Size = new System.Drawing.Size(194, 50);
            this.labelBossHP.TabIndex = 24;
            this.labelBossHP.Text = "3000hp";
            // 
            // labelBossStatLevel
            // 
            this.labelBossStatLevel.AutoSize = true;
            this.labelBossStatLevel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBossStatLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBossStatLevel.Location = new System.Drawing.Point(410, 74);
            this.labelBossStatLevel.Name = "labelBossStatLevel";
            this.labelBossStatLevel.Size = new System.Drawing.Size(199, 34);
            this.labelBossStatLevel.TabIndex = 26;
            this.labelBossStatLevel.Text = "Boss level 2";
            // 
            // labelBossStatHP
            // 
            this.labelBossStatHP.AutoSize = true;
            this.labelBossStatHP.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBossStatHP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBossStatHP.Location = new System.Drawing.Point(68, 608);
            this.labelBossStatHP.Name = "labelBossStatHP";
            this.labelBossStatHP.Size = new System.Drawing.Size(239, 34);
            this.labelBossStatHP.TabIndex = 27;
            this.labelBossStatHP.Text = "Boss hp : 3000";
            // 
            // labelBossStatReduction
            // 
            this.labelBossStatReduction.AutoSize = true;
            this.labelBossStatReduction.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBossStatReduction.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBossStatReduction.Location = new System.Drawing.Point(383, 608);
            this.labelBossStatReduction.Name = "labelBossStatReduction";
            this.labelBossStatReduction.Size = new System.Drawing.Size(376, 34);
            this.labelBossStatReduction.TabIndex = 28;
            this.labelBossStatReduction.Text = "Boss regeneration : 25";
            // 
            // pictureBoxReductionIco
            // 
            this.pictureBoxReductionIco.Image = global::ClickerGame.Properties.Resources.reductionIcon;
            this.pictureBoxReductionIco.Location = new System.Drawing.Point(337, 601);
            this.pictureBoxReductionIco.Name = "pictureBoxReductionIco";
            this.pictureBoxReductionIco.Size = new System.Drawing.Size(51, 50);
            this.pictureBoxReductionIco.TabIndex = 30;
            this.pictureBoxReductionIco.TabStop = false;
            // 
            // pictureBoxHPico
            // 
            this.pictureBoxHPico.Image = global::ClickerGame.Properties.Resources.HPico;
            this.pictureBoxHPico.Location = new System.Drawing.Point(23, 600);
            this.pictureBoxHPico.Name = "pictureBoxHPico";
            this.pictureBoxHPico.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxHPico.TabIndex = 29;
            this.pictureBoxHPico.TabStop = false;
            // 
            // pictureBoxBoss
            // 
            this.pictureBoxBoss.Image = global::ClickerGame.Properties.Resources.boss1;
            this.pictureBoxBoss.Location = new System.Drawing.Point(157, 169);
            this.pictureBoxBoss.Name = "pictureBoxBoss";
            this.pictureBoxBoss.Size = new System.Drawing.Size(700, 410);
            this.pictureBoxBoss.TabIndex = 0;
            this.pictureBoxBoss.TabStop = false;
            this.pictureBoxBoss.Click += new System.EventHandler(this.pictureBoxBoss_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BossArenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.pictureBoxReductionIco);
            this.Controls.Add(this.pictureBoxHPico);
            this.Controls.Add(this.labelBossStatReduction);
            this.Controls.Add(this.labelBossStatHP);
            this.Controls.Add(this.labelBossStatLevel);
            this.Controls.Add(this.labelBossHP);
            this.Controls.Add(this.labelBossName);
            this.Controls.Add(this.toBossRoom);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBoxBoss);
            this.Name = "BossArenaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BossArenaForm";
            this.Load += new System.EventHandler(this.BossArenaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReductionIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHPico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBoss;
        private RoundedButton exitButton;
        private RoundedButton toBossRoom;
        private System.Windows.Forms.Label labelBossName;
        private System.Windows.Forms.Label labelBossHP;
        private System.Windows.Forms.Label labelBossStatLevel;
        private System.Windows.Forms.Label labelBossStatHP;
        private System.Windows.Forms.Label labelBossStatReduction;
        private System.Windows.Forms.PictureBox pictureBoxHPico;
        private System.Windows.Forms.PictureBox pictureBoxReductionIco;
        private System.Windows.Forms.Timer timer;
    }
}