using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Projekt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void clickRegistration_Click(object sender, EventArgs e)
        {
            ChangeWindow change = new ChangeWindow(this,new RegistrationForm());
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            var connection = new DBConnection();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE email = @login AND password = @password",connection.getConnetion());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginFieldLogin.Text; 
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passFieldLogin.Text;

            connection.openConnection();
                mySqlDataAdapter.SelectCommand = command;
                mySqlDataAdapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    loginFieldLogin.Text = "";
                    passFieldLogin.Text = "";
                    var person = SystemDatas.logIn( (string)table.Rows[0][5], Convert.ToString(table.Rows[0][0]) );
                    ChangeWindow change = new ChangeWindow(this,person);    
                }
                else {
                    MessageBox.Show("Password or Email was wrong");
                }
            connection.closeConnection();
           
        }
    }
}

