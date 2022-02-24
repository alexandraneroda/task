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
using MySql.Data.MySqlClient;
using Sitecore.FakeDb;


namespace task
{
    public partial class Form1 : Form
    {

        private bool newRowAdding = false;
        private readonly string CONFIG_PUTH = $"{Environment.CurrentDirectory}\\config.json";
        private static DevicesTable devicesTable;
        AddForm addForm;


        public Form1()
        {
            InitializeComponent();
            devicesTable = new DevicesTable();
        }

        DataTable table = new DataTable();
        int rowIndex;
        private void LoadData()
        {
            DevicesDataGridView.DataSource = devicesTable.Devices;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           //DevicesDataGridView.Rows.Add(Name.Text, Type.Text, Price.Text);

            addForm = new AddForm();    
            addForm.Show();

        }

        private void AddRow(string name, string type, string price)
        {
            String[] row = {name, type, price};

           
        }

       

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем не является ли вводимы символ управляющим
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;   
            }
        }
    }
}
