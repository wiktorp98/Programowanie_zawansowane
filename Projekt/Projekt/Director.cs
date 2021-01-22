using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class Director : Worker, IDirector
    {

        public bool inviteWorker(string email) {
            DBConnection connection = new DBConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(" SELECT * FROM users WHERE email = @email and position = 'C' ", connection.getConnetion());

            if (VerificationDatas.verificationEmail(email))
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            else
                MessageBox.Show("Nie poprawny email");
            adapter.SelectCommand = command;
            adapter.Fill(table);

            connection.openConnection();
            if (table.Rows.Count > 0)
            {
                command = new MySqlCommand("UPDATE users SET position = 'W' WHERE email = @email", connection.getConnetion());
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                if (command.ExecuteNonQuery() == 1) {
                    return true;
                }
                    
            }
            connection.closeConnection();
            return false;
        }

        public Person[] showWorkers()
        {
            List<Person> workers = new List<Person>();
            //Get datas from DataBase
            var connection = new DBConnection();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE position = 'W'", connection.getConnetion());
            connection.openConnection();
            mySqlDataAdapter.SelectCommand = command;
            mySqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int a = 0; a < table.Rows.Count; a++)
                {
                    workers.Add(new Person() { name = (string)table.Rows[a][1], surname = (string)table.Rows[a][2], email = (string)table.Rows[a][3] });
                }

            }
            connection.closeConnection();
            return workers.ToArray();
        }
    }
}
