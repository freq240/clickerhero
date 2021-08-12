using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ClickerGame.forms
{
    public partial class RegForm : FormWithShadow
    {
        ClickerDB db = new ClickerDB();
        public RegForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {       
            db.AddNewAccount(loginTextBox.Text, passwordTextBox.Text);

            SlowTransition(5);
            this.Hide();
            LogForm logForm = new LogForm();
            logForm.Show();
        }
    }
}
