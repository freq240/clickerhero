using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClickerGame
{
    public partial class BossArenaForm : FormWithShadow
    {
        Boss myBoss;
        int maxBossHP;
        public BossArenaForm()
        {
            InitializeComponent();
            SetSomeLevel();
            timer.Start();
            //RegenTheBoss();
        }

        private void SetSomeLevel()
        {
            switch (Hero.HeroLevel)
            {
                case 1:
                    myBoss = new MartyrBoss();
                    myBoss.HealthPoint = 500;
                    myBoss.Regeneration = 10;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss1;
                    labelBossName.Left = 187;
                    labelBossName.Top = -3;
                    break;
                case 2:
                    myBoss = new ScreamerBoss();
                    myBoss.HealthPoint = 750;
                    myBoss.Regeneration = 10;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss2;
                    labelBossName.Left = 144;
                    labelBossName.Top = -3;
                    break;
                case 3:
                    myBoss = new FearmongerBoss();
                    myBoss.HealthPoint = 1000;
                    myBoss.Regeneration = 15;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss3;
                    labelBossName.Left = 100;
                    labelBossName.Top = -3;
                    break;
                case 4:
                    myBoss = new ManipulatorBoss();
                    myBoss.HealthPoint = 1200;
                    myBoss.Regeneration = 20;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss4;
                    labelBossName.Left = 100;
                    labelBossName.Top = -3;
                    break;
                case 5:
                    myBoss = new BumblerBoss();
                    myBoss.Regeneration = 20;
                    myBoss.HealthPoint = 1500;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss5;
                    labelBossName.Left = 173;
                    labelBossName.Top = -3;
                    break;
                case 6:
                    myBoss = new CluelessBoss();
                    myBoss.HealthPoint = 2500;
                    myBoss.Regeneration = 25;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss6;
                    labelBossName.Left = 180;
                    labelBossName.Top = -3;
                    break;
                case 7:
                    myBoss = new OldSchoolerBoss();
                    myBoss.HealthPoint = 2500;
                    myBoss.Regeneration = 25;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss7;
                    labelBossName.Left = 200;
                    labelBossName.Top = -3;
                    break;
                case 8:
                    myBoss = new GodBoss();
                    myBoss.HealthPoint = 4000;
                    myBoss.Regeneration = 35;
                    labelBossName.Text = myBoss.Name;
                    pictureBoxBoss.Image = Properties.Resources.boss8;
                    labelBossName.Left = 261;
                    labelBossName.Top = -3;
                    break;

                default:
                    break;
            }
            maxBossHP = myBoss.HealthPoint;

            labelBossStatHP.Text = $"Boss HP : {myBoss.HealthPoint}";
            labelBossStatReduction.Text = $"Boss regeneration : {myBoss.Regeneration}";
            labelBossStatLevel.Text = $"Boss level {myBoss.Level}";

            
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }
        private void toBossRoom_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            this.Hide();
            PlayForm playForm = new PlayForm();
            playForm.Show();
        }


        private void pictureBoxBoss_Click(object sender, EventArgs e)
        {
            myBoss.HealthPoint -= Hero.HeroDamage;
            if (myBoss.HealthPoint <= 0)
            {
                if (Hero.HeroLevel != 8)
                {
                    Hero.HeroLevel++;
                }
                timer.Stop();
                SlowTransition(5);
                this.Hide();
                PlayForm playForm = new PlayForm();
                playForm.Show();
            }
            else
            {
                labelBossHP.Text = myBoss.HealthPoint.ToString() + "hp";
            }
            
        }

        private void BossArenaForm_Load(object sender, EventArgs e)
        {
            labelBossHP.Text = myBoss.HealthPoint.ToString() + "hp";
            // Regeneration HP of boss by Hero reduction stat formule
            myBoss.Regeneration = (myBoss.Regeneration * (100 - Hero.HeroReduction))/100;

            labelBossStatReduction.Text = $"Boss regeneration : {myBoss.Regeneration}";
        }

        async void RegenTheBoss()
        {
            await Task.Run(() =>
            {
                while (myBoss.HealthPoint > 0)
                {
                    myBoss.HealthPoint += myBoss.Regeneration; 
                    Thread.Sleep(1000);
                }
            }
            );
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelBossHP.Text = myBoss.HealthPoint.ToString() + "hp";

            if (myBoss.HealthPoint <= maxBossHP)
            {
                if (myBoss.HealthPoint + myBoss.Regeneration <= maxBossHP)
                {
                    myBoss.HealthPoint += myBoss.Regeneration;
                }
            }
        }
    }
}
