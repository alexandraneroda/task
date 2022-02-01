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


        public Form1()
        {
            InitializeComponent();
            devicesTable = new DevicesTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this); 
            frm3.Show();
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            DevicesDataGridView.Rows.Clear();
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            FormProperties frmpr = new FormProperties(this);
            frmpr.Show();
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            ProDevicesDataGredView.Rows.Clear();
        }

        private void LoadData()
        {
            DevicesDataGridView.DataSource = devicesTable.Devices;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void DevicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) //Обработка любых нажатий на ячейку
        {

        }

        private void DevicesDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
    
        }

        private void DevicesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void DevicesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        
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
