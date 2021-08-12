using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClickerGame
{
    class ClickerDB
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ClickerDB"].ConnectionString);

        public void AddNewAccount(string login, string password)
        {
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand($"INSERT INTO [AUTH] (Login, Password) VALUES (N'{login}', N'{password}')", sqlConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Succesfully registrated!");
                
            }
            else
            {
                MessageBox.Show("Error with database connection!");
            }

            sqlConnection.Close();
        }

        public int CheckAccountAndGetID(string login, string password)
        {
            int id = 0;
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                try
                {
                    SqlCommand command = new SqlCommand($"SELECT Id FROM [Auth] WHERE Login = N'{login}' AND Password = N'{password}'", sqlConnection);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
                catch
                {
                    MessageBox.Show("Error with database connection!");
                }           
            }
            else
            {
                MessageBox.Show("Error with database connection!");
            }

            sqlConnection.Close();

            return id;
        }
        
    }
}
