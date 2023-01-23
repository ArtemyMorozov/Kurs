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
            //int id;
            DataBase db = new DataBase();

            db.getConnection();
            String city = "SELECT * FROM schedule";

            MySqlCommand command = new MySqlCommand(city, db.getConnection());
            DataTable table = new DataTable();


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            ChooseWhereToGo.DisplayMember = "whereToGO";// столбец для отображения
            ChooseWhereToGo.DataSource = table;
            ChooseWhereToGo.SelectedIndex = -1;
            
            
            date.DisplayMember = "id";
            date.DataSource = table;
            date.SelectedIndex = -1;
            date.ValueMember = "id";
        }

        private void ChooseWhereToGo_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }
    }
}
