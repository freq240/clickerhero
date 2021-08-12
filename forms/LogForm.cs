using ClickerGame.forms;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ClickerGame
{
    public partial class LogForm : FormWithShadow
    {
        ClickerDB db = new ClickerDB();
        public LogForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            
            if (db.CheckAccountAndGetID(loginTextBox.Text, passwordTextBox.Text) != 0)
            {
                Hero.ID = db.CheckAccountAndGetID(loginTextBox.Text, passwordTextBox.Text);

                SlowTransition(5);
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.Show();

                
            }
            else
            {
                MessageBox.Show("Wrong login or password!");
            }
            
            
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SlowTransition(5);
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.Show();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
