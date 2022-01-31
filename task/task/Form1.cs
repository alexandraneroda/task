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
        private SqlConnection sqlConnection = null;

        private SqlCommandBuilder sqlBuilder = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        private DataGridViewCell linkCell; //Пришлось добавить, так как linkcell не существует в данном контексте

        private readonly string CONFIG_PUTH = $"{Environment.CurrentDirectory}\\config.json";
        public Form1()
        {
            InitializeComponent();

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
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [DELETE] FROM Devices", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet(); //содержит продублированные данные из основной бд

                sqlDataAdapter.Fill(dataSet, "Devices"); //обновляем данные 

                DevicesDataGridView.DataSource = dataSet.Tables["Devices"];

                for (int i = 0; i < DevicesDataGridView.Rows.Count; i++)
                {
                     DevicesDataGridView[4, 1] = linkCell; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Devices"].Clear();

                sqlDataAdapter.Fill(dataSet, "Devices");

                DevicesDataGridView.DataSource = dataSet.Tables["Devices"];

                for (int i = 0; i < DevicesDataGridView.Rows.Count; i++)
                {
                    DevicesDataGridView[4, 1] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\savushkin\task\task\task\Database.mdf;Integrated Security=True");

            sqlConnection.Open();

            LoadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void DevicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) //Обработка любых нажатий на ячейку
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    string task = DevicesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            DevicesDataGridView.Rows.RemoveAt(rowIndex);

                            dataSet.Tables["Devices"].Rows[rowIndex].Delete();

                            sqlDataAdapter.Update(dataSet, "Devices");
                        }
                    }

                    else if (task == "Insert")
                    {

                    }
                    else if (task == "Update")
                    {

                    }

                    ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevicesDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
