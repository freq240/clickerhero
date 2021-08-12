using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class PlayForm : FormWithShadow
    {
        public PlayForm()
        {
            InitializeComponent();
        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            labelDamage.Text = $"Damage {Hero.HeroDamage}";
            labelReduction.Text = $"Reduction {Hero.HeroReduction}";
            labelLevel.Text = $"Level {Hero.HeroLevel}";
        }

        private void callBossButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            this.Hide();
            BossArenaForm bossArenaForm = new BossArenaForm();
            bossArenaForm.Show();
        }
    }
}
