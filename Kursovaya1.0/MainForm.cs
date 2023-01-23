﻿using MySql.Data.MySqlClient;
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
            
        }

        private void ChooseWhereToGo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            db.getConnection();
            String city = "SELECT * FROM schedule";

            MySqlCommand command = new MySqlCommand(city, db.getConnection());
            DataTable table = new DataTable();


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            string dest = ChooseWhereToGo.Text;
            //создать Массив для сравнения значений из БД
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (dest == table.Rows[i][1].ToString())
                {
                    list.Add(table.Rows[i][2].ToString());
                }
            }

            date.DataSource = list;
            date.SelectedIndex = -1;
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
            DataBase db = new DataBase();

            db.getConnection();
            String city = "SELECT * FROM schedule";

            MySqlCommand command = new MySqlCommand(city, db.getConnection());
            DataTable table = new DataTable();


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (data == table.Rows[i][1].ToString())
                {
                    list.Add(table.Rows[i][2].ToString());
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
