using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class AddForm : Form
    {
        private static DevicesTable devicesTable;
        public AddForm()

        {

            InitializeComponent();
            devicesTable = new DevicesTable();
            
        }

        DataTable table = new DataTable();
        private void NametxtBox_TextChanged(object sender, EventArgs e)
        {
            new DevicesTable().Name = Convert.ToString(NameTextBox.Text);
        }

        private void TypetextBox_TextChanged(object sender, EventArgs e)
        {
            new DevicesTable().Type = Convert.ToString(TypeTextBox.Text);
        }

        private void PricetextBox3_TextChanged(object sender, EventArgs e)
        {
            new DevicesTable().Price = Convert.ToInt32(PriceTextBox.Text);
        }
        private void AddDevButton_Click(object sender, EventArgs e)
        {
           // DevicesTable.
        }
    }
}
