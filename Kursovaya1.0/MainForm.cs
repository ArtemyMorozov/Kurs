using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
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
            //int id;
            DataBase db = new DataBase();

            db.getConnection();
            String city = "SELECT * FROM schedule";

            MySqlCommand command = new MySqlCommand(city, db.getConnection());
            DataTable table = new DataTable();


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            //создать Массив для сравнения значений из БД
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (list.Contains(table.Rows[i][1].ToString()))
                {
                    list.Remove(table.Rows[i][1].ToString());
                }
                else
                    list.Add(table.Rows[i][1].ToString());
            }

            ChooseWhereToGo.DataSource = list;
            ChooseWhereToGo.SelectedIndex = -1;

            if (ChooseWhereToGo.SelectedIndex == -1)
            {
                ClosestTime.Text = "Город не выбран";
            }

            FreeSeats.Text = "Не выбрано время";
        }

        private void ChooseWhereToGo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lol = ChooseWhereToGo.Text;
            DataBase db = new DataBase();

            db.getConnection();
            String Time = "SELECT * FROM schedule";

            MySqlCommand command = new MySqlCommand(Time, db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            //создать массив типа DateTime для сравнения даты и времени из бд
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][1].ToString() == lol)
                {
                    list.Add(table.Rows[i][2]);
                }
            }

            //найти в списке ближайшее время
            DateTime now = DateTime.Now;
            DateTime closest = DateTime.MaxValue;
            foreach (DateTime dt in list)
            {
                if (dt > now && dt < closest)
                {
                    closest = dt;
                }
            }

            //вывести ближайшее время в ClosestTime
            ClosestTime.Text = closest.ToString("f");
            
            string dest = ChooseWhereToGo.Text;
            ArrayList list2 = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (dest == table.Rows[i][1].ToString())
                {
                    list2.Add(table.Rows[i][2].ToString());
                }
            }

            date.DataSource = list2;
            date.SelectedIndex = -1;

            int seats;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (dest == table.Rows[i][2].ToString())
                {
                    seats = Convert.ToInt32(table.Rows[i][5]);
                    FreeSeats.Text = seats.ToString();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = date.Text;
            int seats;
            DataBase db = new DataBase();

            db.getConnection();
            String city = "SELECT * FROM schedule";

            MySqlCommand command = new MySqlCommand(city, db.getConnection());
            DataTable table = new DataTable();


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (data == table.Rows[i][2].ToString())
                {
                    seats = Convert.ToInt32(table.Rows[i][5]);
                    FreeSeats.Text = seats.ToString();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
