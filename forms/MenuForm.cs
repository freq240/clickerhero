using System;

namespace ClickerGame
{
    public partial class MenuForm : FormWithShadow
    {
        public MenuForm() : base()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            this.Hide();
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            this.Hide();
            PlayForm playForm = new PlayForm();
            playForm.Show();
        }


    }
}
