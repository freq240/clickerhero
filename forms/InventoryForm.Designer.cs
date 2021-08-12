
namespace ClickerGame
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.exitButton = new ClickerGame.RoundedButton();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeapon = new System.Windows.Forms.Label();
            this.labelArmor = new System.Windows.Forms.Label();
            this.labelHelmet = new System.Windows.Forms.Label();
            this.pictureBoxW1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxW2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxW3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxA1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxA3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxA2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxH1 = new System.Windows.Forms.PictureBox();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelReduction = new System.Windows.Forms.Label();
            this.labelReductionValue = new System.Windows.Forms.Label();
            this.labelDamageValue = new System.Windows.Forms.Label();
            this.toMenuButton = new ClickerGame.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCM1 = new System.Windows.Forms.Label();
            this.labelCM2 = new System.Windows.Forms.Label();
            this.labelCM3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH1)).BeginInit();
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelName.Location = new System.Drawing.Point(245, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(527, 86);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "INVENTORY";
            // 
            // labelWeapon
            // 
            this.labelWeapon.AutoSize = true;
            this.labelWeapon.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeapon.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelWeapon.Location = new System.Drawing.Point(134, 125);
            this.labelWeapon.Name = "labelWeapon";
            this.labelWeapon.Size = new System.Drawing.Size(210, 50);
            this.labelWeapon.TabIndex = 3;
            this.labelWeapon.Text = "Weapon";
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArmor.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelArmor.Location = new System.Drawing.Point(156, 333);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(182, 50);
            this.labelArmor.TabIndex = 4;
            this.labelArmor.Text = "Armor";
            // 
            // labelHelmet
            // 
            this.labelHelmet.AutoSize = true;
            this.labelHelmet.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelmet.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelHelmet.Location = new System.Drawing.Point(679, 125);
            this.labelHelmet.Name = "labelHelmet";
            this.labelHelmet.Size = new System.Drawing.Size(197, 50);
            this.labelHelmet.TabIndex = 5;
            this.labelHelmet.Text = "Helmet";
            // 
            // pictureBoxW1
            // 
            this.pictureBoxW1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxW1.Image = global::ClickerGame.Properties.Resources.weapon1;
            this.pictureBoxW1.Location = new System.Drawing.Point(21, 188);
            this.pictureBoxW1.Name = "pictureBoxW1";
            this.pictureBoxW1.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxW1.TabIndex = 6;
            this.pictureBoxW1.TabStop = false;
            this.pictureBoxW1.Click += new System.EventHandler(this.pictureBoxW1_Click);
            // 
            // pictureBoxW2
            // 
            this.pictureBoxW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxW2.Image = global::ClickerGame.Properties.Resources.weapon2;
            this.pictureBoxW2.Location = new System.Drawing.Point(172, 188);
            this.pictureBoxW2.Name = "pictureBoxW2";
            this.pictureBoxW2.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxW2.TabIndex = 7;
            this.pictureBoxW2.TabStop = false;
            this.pictureBoxW2.Click += new System.EventHandler(this.pictureBoxW2_Click);
            // 
            // pictureBoxW3
            // 
            this.pictureBoxW3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxW3.Image = global::ClickerGame.Properties.Resources.weapon3;
            this.pictureBoxW3.Location = new System.Drawing.Point(334, 188);
            this.pictureBoxW3.Name = "pictureBoxW3";
            this.pictureBoxW3.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxW3.TabIndex = 8;
            this.pictureBoxW3.TabStop = false;
            this.pictureBoxW3.Click += new System.EventHandler(this.pictureBoxW3_Click);
            // 
            // pictureBoxA1
            // 
            this.pictureBoxA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxA1.Image = global::ClickerGame.Properties.Resources.armor3;
            this.pictureBoxA1.Location = new System.Drawing.Point(31, 386);
            this.pictureBoxA1.Name = "pictureBoxA1";
            this.pictureBoxA1.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxA1.TabIndex = 11;
            this.pictureBoxA1.TabStop = false;
            this.pictureBoxA1.Click += new System.EventHandler(this.pictureBoxA1_Click);
            // 
            // pictureBoxA3
            // 
            this.pictureBoxA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxA3.Image = global::ClickerGame.Properties.Resources.armor2;
            this.pictureBoxA3.Location = new System.Drawing.Point(334, 386);
            this.pictureBoxA3.Name = "pictureBoxA3";
            this.pictureBoxA3.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxA3.TabIndex = 10;
            this.pictureBoxA3.TabStop = false;
            this.pictureBoxA3.Click += new System.EventHandler(this.pictureBoxA3_Click);
            // 
            // pictureBoxA2
            // 
            this.pictureBoxA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxA2.Image = global::ClickerGame.Properties.Resources.armor1;
            this.pictureBoxA2.Location = new System.Drawing.Point(182, 386);
            this.pictureBoxA2.Name = "pictureBoxA2";
            this.pictureBoxA2.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxA2.TabIndex = 9;
            this.pictureBoxA2.TabStop = false;
            this.pictureBoxA2.Click += new System.EventHandler(this.pictureBoxA2_Click);
            // 
            // pictureBoxH3
            // 
            this.pictureBoxH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxH3.Image = global::ClickerGame.Properties.Resources.helmet3;
            this.pictureBoxH3.Location = new System.Drawing.Point(865, 188);
            this.pictureBoxH3.Name = "pictureBoxH3";
            this.pictureBoxH3.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxH3.TabIndex = 14;
            this.pictureBoxH3.TabStop = false;
            this.pictureBoxH3.Click += new System.EventHandler(this.pictureBoxH3_Click);
            // 
            // pictureBoxH2
            // 
            this.pictureBoxH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxH2.Image = global::ClickerGame.Properties.Resources.helmet2;
            this.pictureBoxH2.Location = new System.Drawing.Point(700, 188);
            this.pictureBoxH2.Name = "pictureBoxH2";
            this.pictureBoxH2.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxH2.TabIndex = 13;
            this.pictureBoxH2.TabStop = false;
            this.pictureBoxH2.Click += new System.EventHandler(this.pictureBoxH2_Click);
            // 
            // pictureBoxH1
            // 
            this.pictureBoxH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxH1.Image = global::ClickerGame.Properties.Resources.helmet1;
            this.pictureBoxH1.Location = new System.Drawing.Point(547, 188);
            this.pictureBoxH1.Name = "pictureBoxH1";
            this.pictureBoxH1.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxH1.TabIndex = 12;
            this.pictureBoxH1.TabStop = false;
            this.pictureBoxH1.Click += new System.EventHandler(this.pictureBoxH1_Click);
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamage.ForeColor = System.Drawing.Color.Crimson;
            this.labelDamage.Location = new System.Drawing.Point(76, 545);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(185, 43);
            this.labelDamage.TabIndex = 15;
            this.labelDamage.Text = "Damage";
            // 
            // labelReduction
            // 
            this.labelReduction.AutoSize = true;
            this.labelReduction.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReduction.ForeColor = System.Drawing.Color.Crimson;
            this.labelReduction.Location = new System.Drawing.Point(48, 595);
            this.labelReduction.Name = "labelReduction";
            this.labelReduction.Size = new System.Drawing.Size(238, 43);
            this.labelReduction.TabIndex = 16;
            this.labelReduction.Text = "Reduction";
            this.labelReduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReductionValue
            // 
            this.labelReductionValue.AutoSize = true;
            this.labelReductionValue.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReductionValue.ForeColor = System.Drawing.Color.Crimson;
            this.labelReductionValue.Location = new System.Drawing.Point(310, 595);
            this.labelReductionValue.Name = "labelReductionValue";
            this.labelReductionValue.Size = new System.Drawing.Size(94, 43);
            this.labelReductionValue.TabIndex = 18;
            this.labelReductionValue.Text = "99%";
            this.labelReductionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDamageValue
            // 
            this.labelDamageValue.AutoSize = true;
            this.labelDamageValue.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamageValue.ForeColor = System.Drawing.Color.Crimson;
            this.labelDamageValue.Location = new System.Drawing.Point(306, 545);
            this.labelDamageValue.Name = "labelDamageValue";
            this.labelDamageValue.Size = new System.Drawing.Size(110, 43);
            this.labelDamageValue.TabIndex = 17;
            this.labelDamageValue.Text = "99 ֍";
            // 
            // toMenuButton
            // 
            this.toMenuButton.FlatAppearance.BorderSize = 5;
            this.toMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toMenuButton.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toMenuButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toMenuButton.Location = new System.Drawing.Point(688, 561);
            this.toMenuButton.Name = "toMenuButton";
            this.toMenuButton.Size = new System.Drawing.Size(285, 77);
            this.toMenuButton.TabIndex = 19;
            this.toMenuButton.Text = "to MENU";
            this.toMenuButton.UseVisualStyleBackColor = true;
            this.toMenuButton.Click += new System.EventHandler(this.toMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(492, 351);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 182);
            this.label1.TabIndex = 20;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // labelCM1
            // 
            this.labelCM1.AutoSize = true;
            this.labelCM1.BackColor = System.Drawing.Color.Transparent;
            this.labelCM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCM1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCM1.ForeColor = System.Drawing.Color.Green;
            this.labelCM1.Location = new System.Drawing.Point(405, 311);
            this.labelCM1.Margin = new System.Windows.Forms.Padding(0);
            this.labelCM1.Name = "labelCM1";
            this.labelCM1.Size = new System.Drawing.Size(52, 36);
            this.labelCM1.TabIndex = 21;
            this.labelCM1.Text = "✔";
            // 
            // labelCM2
            // 
            this.labelCM2.AutoSize = true;
            this.labelCM2.BackColor = System.Drawing.Color.Transparent;
            this.labelCM2.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCM2.ForeColor = System.Drawing.Color.Green;
            this.labelCM2.Location = new System.Drawing.Point(933, 311);
            this.labelCM2.Margin = new System.Windows.Forms.Padding(0);
            this.labelCM2.Name = "labelCM2";
            this.labelCM2.Size = new System.Drawing.Size(52, 36);
            this.labelCM2.TabIndex = 22;
            this.labelCM2.Text = "✔";
            // 
            // labelCM3
            // 
            this.labelCM3.AutoSize = true;
            this.labelCM3.BackColor = System.Drawing.Color.Transparent;
            this.labelCM3.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCM3.ForeColor = System.Drawing.Color.Green;
            this.labelCM3.Location = new System.Drawing.Point(405, 509);
            this.labelCM3.Margin = new System.Windows.Forms.Padding(0);
            this.labelCM3.Name = "labelCM3";
            this.labelCM3.Size = new System.Drawing.Size(52, 36);
            this.labelCM3.TabIndex = 23;
            this.labelCM3.Text = "✔";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.labelCM3);
            this.Controls.Add(this.labelCM2);
            this.Controls.Add(this.labelCM1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toMenuButton);
            this.Controls.Add(this.labelReductionValue);
            this.Controls.Add(this.labelDamageValue);
            this.Controls.Add(this.labelReduction);
            this.Controls.Add(this.labelDamage);
            this.Controls.Add(this.pictureBoxH3);
            this.Controls.Add(this.pictureBoxH2);
            this.Controls.Add(this.pictureBoxH1);
            this.Controls.Add(this.pictureBoxA1);
            this.Controls.Add(this.pictureBoxA3);
            this.Controls.Add(this.pictureBoxA2);
            this.Controls.Add(this.pictureBoxW3);
            this.Controls.Add(this.pictureBoxW2);
            this.Controls.Add(this.pictureBoxW1);
            this.Controls.Add(this.labelHelmet);
            this.Controls.Add(this.labelArmor);
            this.Controls.Add(this.labelWeapon);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.exitButton);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxH1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton exitButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeapon;
        private System.Windows.Forms.Label labelArmor;
        private System.Windows.Forms.Label labelHelmet;
        private System.Windows.Forms.PictureBox pictureBoxW1;
        private System.Windows.Forms.PictureBox pictureBoxW2;
        private System.Windows.Forms.PictureBox pictureBoxW3;
        private System.Windows.Forms.PictureBox pictureBoxA1;
        private System.Windows.Forms.PictureBox pictureBoxA3;
        private System.Windows.Forms.PictureBox pictureBoxA2;
        private System.Windows.Forms.PictureBox pictureBoxH3;
        private System.Windows.Forms.PictureBox pictureBoxH2;
        private System.Windows.Forms.PictureBox pictureBoxH1;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelReduction;
        private System.Windows.Forms.Label labelReductionValue;
        private System.Windows.Forms.Label labelDamageValue;
        private RoundedButton toMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCM1;
        private System.Windows.Forms.Label labelCM2;
        private System.Windows.Forms.Label labelCM3;
    }
}