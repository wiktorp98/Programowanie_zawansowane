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

namespace Projekt
{
    public partial class RegistrationForm : Form
    {
        ChangeWindow change;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void clickLogIn_Click(object sender, EventArgs e)
        {
            change = new ChangeWindow(this,new LoginForm());
        }


        private void createRegistration_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            DBConnection connection = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users`( `name`, `surname`, `email`, `password`, `position`) VALUES (@name,@surname,@email,@password,'C')",connection.getConnetion());

            if (VerificationDatas.verificationEmail(emailRegistration.Text))
            {
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailRegistration.Text;
            }
            else {
                errors.Add("Email is not correct");
            }

            if (VerificationDatas.verificationName(nameRegistration.Text))
            {
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameRegistration.Text;
            }
            else
            {
                errors.Add("Length of name has to be longer than 2");
            }

            if (VerificationDatas.verificationSurname(surnameRegistration.Text))
            {
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameRegistration.Text;
            }
            else
            {
                errors.Add("Length of surname has to be longer than 2");
            }

            if (VerificationDatas.verificationPassword(passRegistration.Text))
            {
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passRegistration.Text;
            }
            else
            {
                errors.Add("Length of password has to be longer than 11");
            }

            if (errors.Count > 0) {
                string errorsString = "";
                foreach (string error in errors) {
                    errorsString += error + '\n';
                }
                MessageBox.Show(errorsString);
            }
            connection.openConnection();
                if (errors.Count > 0)
                {
                    MessageBox.Show("Account wasn't create");
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account was create");
                    }
                    else
                    {
                        MessageBox.Show("Account wasn't create");
                    }
                }
            connection.closeConnection();
        }

    }
}
