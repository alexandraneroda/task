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

        private bool newRowAdding = false;

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
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Command] FROM Devices", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet(); //содержит продублированные данные из основной бд

                sqlDataAdapter.Fill(dataSet, "Devices"); //обновляем данные 

                DevicesDataGridView.DataSource = dataSet.Tables["Devices"];

                for (int i = 0; i < DevicesDataGridView.Rows.Count; i++)
                {
                     DevicesDataGridView[5, 1] = linkCell; 
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
                    DevicesDataGridView[5, 1] = linkCell;
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
                if (e.ColumnIndex == 5)
                {
                    string task = DevicesDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

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
                        int rowIndex = DevicesDataGridView.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Devices"].NewRow();

                        row["№"] = DevicesDataGridView.Rows[rowIndex].Cells["№"].Value;
                        row["Тип"] = DevicesDataGridView.Rows[rowIndex].Cells["Тип"].Value;
                        row["Название"] = DevicesDataGridView.Rows[rowIndex].Cells["Название"].Value;
                        row["Цена"] = DevicesDataGridView.Rows[rowIndex].Cells["Цена"].Value;

                        dataSet.Tables["Devices"].Rows.Add(row);

                        dataSet.Tables["Devices"].Rows.RemoveAt(dataSet.Tables["Devices"].Rows.Count - 1);

                        DevicesDataGridView.Rows.RemoveAt(DevicesDataGridView.Rows.Count - 2);

                        DevicesDataGridView.Rows[e.RowIndex].Cells[5].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "Devices");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;
                         
                        // Ячейкам нужной строки по индексу в dataSet присваиваем значение из ячеек редактируемой строки 

                        dataSet.Tables["Devices"].Rows[r]["№"] = DevicesDataGridView.Rows[r].Cells["№"].Value;
                        dataSet.Tables["Devices"].Rows[r]["Тип"] = DevicesDataGridView.Rows[r].Cells["Тип"].Value;
                        dataSet.Tables["Devices"].Rows[r]["Название"] = DevicesDataGridView.Rows[r].Cells["Название"].Value;
                        dataSet.Tables["Devices"].Rows[r]["Цена"] = DevicesDataGridView.Rows[r].Cells["Цена"].Value;

                        sqlDataAdapter.Update(dataSet, "Devices");

                        DevicesDataGridView.Rows[e.RowIndex].Cells[5].Value = "Delete";
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
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = DevicesDataGridView.Rows.Count - 2; //Для добавления новой строки 

                    DataGridViewRow row = DevicesDataGridView.Rows[lastRow];//Используя ячецку последней строки, создаём экзмепляр класса DataGridView

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    DevicesDataGridView[5, lastRow] = linkCell;

                    row.Cells["Command"].Value = "Insert";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevicesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = DevicesDataGridView.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = DevicesDataGridView.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    DevicesDataGridView[5, rowIndex] = linkCell;

                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevicesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);  
            // Индекс валидируемой ячейки 
            if (DevicesDataGridView.CurrentCell.ColumnIndex == 4)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
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
