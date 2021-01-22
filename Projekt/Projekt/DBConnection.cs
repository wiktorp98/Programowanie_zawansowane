using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Projekt
{
    class DBConnection
    {
        MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=warehouse");
        public void openConnection() {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed) {
                mySqlConnection.Open();
            }
        }
        public void closeConnection() {
            if (mySqlConnection.State == System.Data.ConnectionState.Open) {
                mySqlConnection.Close();
            }
        }
        public MySqlConnection getConnetion() {
            return mySqlConnection;
        }

    }
}
