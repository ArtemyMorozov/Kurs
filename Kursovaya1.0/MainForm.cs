using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        private DataBase db;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new DataBase();
            db.getConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            //создать Массив для сравнения значений из БД
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (!list.Contains(table.Rows[i][1].ToString()))
                {
                    list.Add(table.Rows[i][1].ToString());
                }
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            //создать массив типа DateTime для сравнения даты и времени из бд
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][1].ToString() == lol)
                {
                    if (!list.Contains(table.Rows[i][2]))
                    {
                        list.Add(table.Rows[i][2]);
                    }
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

        private void date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = date.Text;

            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            string transfer = "";
            int seats;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (data == table.Rows[i][2].ToString())
                {
                    transfer = table.Rows[i][3].ToString();
                    seats = Convert.ToInt32(table.Rows[i][5]);
                    FreeSeats.Text = seats.ToString();
                }
            }
            TransferTextDate.Text = transfer.ToString();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            if (ChooseWhereToGo.Text == " " || ChooseWhereToGo.Text == "")
            {
                MessageBox.Show("Не выбран пункт назначения!");
                return;
            }
            else if (date.Text == "" || date.Text == " ")
            {
                MessageBox.Show("Не выбрана дата!");
                return;
            }
            else if (TicketsAmmount.Text == "" || TicketsAmmount.Text == " " || TicketsAmmount.Text == "0")
            {
                MessageBox.Show("Не указано количество билетов!");
                return;
            }
            else
            {
                DataTable table = new DataTable();

                MySqlCommand com = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                db.openConnection();
                adapter.Fill(table);

                int n = Convert.ToInt32(TicketsAmmount.Text);
                int m = Convert.ToInt32(FreeSeats.Text);

                string data = date.Text;
                int number = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (data == table.Rows[i][2].ToString())
                    {
                        number = i + 1;
                        break;
                    }
                }
                
                int minus = m - n;
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand("UPDATE schedule SET availableSeats = @availableSeats WHERE id = @id", db.getConnection());
                command.Parameters.AddWithValue("@availableSeats", Convert.ToInt32(minus));
                command.Parameters.AddWithValue("@id", number);
                // выполняем запрос
                command.ExecuteNonQuery();
                MessageBox.Show("Билет оформлен успешно!");
                ChooseWhereToGo.Text = "";
                date.Text = "";
                TicketsAmmount.Clear();
                ClosestTime.Clear();
                FreeSeats.Clear();
                PriceText.Clear();
                TransferTextDate.Clear();
            }
        }
        
        private void TicketsAmmount_TextChanged(object sender, EventArgs e)
        {
            String city = "SELECT * FROM schedule";
            MySqlCommand command = new MySqlCommand(city, db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            int n;
            string data = date.Text;
            string price = "0";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (data == table.Rows[i][2].ToString())
                {
                    price = table.Rows[i][6].ToString();
                }
            }
            n = Convert.ToInt32(price);
            if (TicketsAmmount.Text != "")
            {
                int m;
                if (!int.TryParse(TicketsAmmount.Text, out m))
                {
                    MessageBox.Show("Введите число");
                    TicketsAmmount.Text = "0";
                }
                else if (m < 0)
                {
                    MessageBox.Show("Введите положительное число");
                    TicketsAmmount.Text = "0";
                }
                else
                {
                    int sum = m * n;
                    PriceText.Text = sum.ToString();
                }
            }
            else
                PriceText.Text = "0";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
