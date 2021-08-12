
namespace ClickerGame
{
    partial class PlayForm
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
            this.toMenuButton = new ClickerGame.RoundedButton();
            this.exitButton = new ClickerGame.RoundedButton();
            this.labelName = new System.Windows.Forms.Label();
            this.callBossButton = new ClickerGame.RoundedButton();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelReduction = new System.Windows.Forms.Label();
            this.pictureBoxArena1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxArena2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxReductionIco = new System.Windows.Forms.PictureBox();
            this.pictureBoxAttackIco = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseBossButton = new ClickerGame.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArena1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArena2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReductionIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackIco)).BeginInit();
            this.SuspendLayout();
            // 
            // toMenuButton
            // 
            this.toMenuButton.FlatAppearance.BorderSize = 5;
            this.toMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toMenuButton.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMenuButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toMenuButton.Location = new System.Drawing.Point(688, 567);
            this.toMenuButton.Name = "toMenuButton";
            this.toMenuButton.Size = new System.Drawing.Size(285, 77);
            this.toMenuButton.TabIndex = 20;
            this.toMenuButton.Text = "to MENU";
            this.toMenuButton.UseVisualStyleBackColor = true;
            this.toMenuButton.Click += new System.EventHandler(this.toMenuButton_Click);
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
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Purple;
            this.labelName.Location = new System.Drawing.Point(246, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(524, 86);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "BOSS ROOM";
            // 
            // callBossButton
            // 
            this.callBossButton.FlatAppearance.BorderSize = 10;
            this.callBossButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.callBossButton.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callBossButton.ForeColor = System.Drawing.Color.Red;
            this.callBossButton.Location = new System.Drawing.Point(244, 371);
            this.callBossButton.Name = "callBossButton";
            this.callBossButton.Size = new System.Drawing.Size(526, 172);
            this.callBossButton.TabIndex = 23;
            this.callBossButton.Text = "CALL THE BOSS";
            this.callBossButton.UseVisualStyleBackColor = true;
            this.callBossButton.Click += new System.EventHandler(this.callBossButton_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.Purple;
            this.labelLevel.Location = new System.Drawing.Point(415, 101);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(170, 48);
            this.labelLevel.TabIndex = 24;
            this.labelLevel.Text = "Level 1";
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamage.ForeColor = System.Drawing.Color.Red;
            this.labelDamage.Location = new System.Drawing.Point(401, 222);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(248, 43);
            this.labelDamage.TabIndex = 26;
            this.labelDamage.Text = "Damage 99";
            // 
            // labelReduction
            // 
            this.labelReduction.AutoSize = true;
            this.labelReduction.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReduction.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelReduction.Location = new System.Drawing.Point(383, 272);
            this.labelReduction.Name = "labelReduction";
            this.labelReduction.Size = new System.Drawing.Size(301, 43);
            this.labelReduction.TabIndex = 28;
            this.labelReduction.Text = "Reduction 99";
            // 
            // pictureBoxArena1
            // 
            this.pictureBoxArena1.Image = global::ClickerGame.Properties.Resources.arena;
            this.pictureBoxArena1.Location = new System.Drawing.Point(30, 118);
            this.pictureBoxArena1.Name = "pictureBoxArena1";
            this.pictureBoxArena1.Size = new System.Drawing.Size(285, 215);
            this.pictureBoxArena1.TabIndex = 30;
            this.pictureBoxArena1.TabStop = false;
            // 
            // pictureBoxArena2
            // 
            this.pictureBoxArena2.Image = global::ClickerGame.Properties.Resources.arena;
            this.pictureBoxArena2.Location = new System.Drawing.Point(688, 118);
            this.pictureBoxArena2.Name = "pictureBoxArena2";
            this.pictureBoxArena2.Size = new System.Drawing.Size(285, 215);
            this.pictureBoxArena2.TabIndex = 29;
            this.pictureBoxArena2.TabStop = false;
            // 
            // pictureBoxReductionIco
            // 
            this.pictureBoxReductionIco.Image = global::ClickerGame.Properties.Resources.reductionIcon;
            this.pictureBoxReductionIco.Location = new System.Drawing.Point(336, 267);
            this.pictureBoxReductionIco.Name = "pictureBoxReductionIco";
            this.pictureBoxReductionIco.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxReductionIco.TabIndex = 27;
            this.pictureBoxReductionIco.TabStop = false;
            // 
            // pictureBoxAttackIco
            // 
            this.pictureBoxAttackIco.Image = global::ClickerGame.Properties.Resources.damageIcon;
            this.pictureBoxAttackIco.Location = new System.Drawing.Point(336, 216);
            this.pictureBoxAttackIco.Name = "pictureBoxAttackIco";
            this.pictureBoxAttackIco.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAttackIco.TabIndex = 25;
            this.pictureBoxAttackIco.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(368, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 43);
            this.label1.TabIndex = 31;
            this.label1.Text = "Your stats:";
            // 
            // chooseBossButton
            // 
            this.chooseBossButton.FlatAppearance.BorderSize = 5;
            this.chooseBossButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseBossButton.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseBossButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chooseBossButton.Location = new System.Drawing.Point(30, 567);
            this.chooseBossButton.Name = "chooseBossButton";
            this.chooseBossButton.Size = new System.Drawing.Size(285, 77);
            this.chooseBossButton.TabIndex = 32;
            this.chooseBossButton.Text = "CHOOSE BOSS";
            this.chooseBossButton.UseVisualStyleBackColor = true;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.chooseBossButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxArena1);
            this.Controls.Add(this.pictureBoxArena2);
            this.Controls.Add(this.labelReduction);
            this.Controls.Add(this.pictureBoxReductionIco);
            this.Controls.Add(this.labelDamage);
            this.Controls.Add(this.pictureBoxAttackIco);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.callBossButton);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.toMenuButton);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArena1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArena2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReductionIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton toMenuButton;
        private RoundedButton exitButton;
        private System.Windows.Forms.Label labelName;
        private RoundedButton callBossButton;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.PictureBox pictureBoxAttackIco;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelReduction;
        private System.Windows.Forms.PictureBox pictureBoxReductionIco;
        private System.Windows.Forms.PictureBox pictureBoxArena2;
        private System.Windows.Forms.PictureBox pictureBoxArena1;
        private System.Windows.Forms.Label label1;
        private RoundedButton chooseBossButton;
    }
}