using MySql.Data.MySqlClient;
using System;
using System.Collections;
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

            //Если выбран город, то пишем в ClosestTime "город выбран". Менять на "выберите город" при смене города
            if (ChooseWhereToGo.SelectedIndex == -1)
            {
                ClosestTime.Text = "Город не выбран";
            }
        }

            private void ChooseWhereToGo_SelectedIndexChanged(object sender, EventArgs e) 
        {
            //название выбранного города помещаемя в ClosestTime
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
                if(table.Rows[i][1].ToString() == lol)
                {
                    if (list.Contains(table.Rows[i][2]))
                    {
                        list.Remove(table.Rows[i][2]);
                    }
                    else
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

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
