using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya1._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ChooseWhereToGo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String city = ChooseWhereToGo.Items[ChooseWhereToGo.SelectedIndex].ToString();

            DataBase db = new DataBase();
            
            DataSet ds = new DataSet();

            //DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `schedule` WHERE `whereToGo` = @wTG AND `departudeDate` = @dD AND 'tranferDate' = @tD AND 'arrivalDate' = @aD AND 'availableSeats' = @aS AND 'cost' = @co", db.getConnection());
            //command.Parameters.Add("@wTG", MySqlDbType.VarChar).Value = city;

            //adapter.SelectCommand = command;
            adapter.Fill(ds);

            int i = 0;
            for (i = 0; i < ds.Tables["schedule"].Rows.Count; i++) // перебираем все строки
            {
                // выводим в комбобокс
                ChooseWhereToGo.Items.Add(ds.Tables["schedule"].Rows[i]["whereToGo"].ToString());
            }
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
