using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1._0
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=sql11.freesqldatabase.com;port=3306;username=sql11592104;password=nAh975wzgx;database=sql11592104");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
