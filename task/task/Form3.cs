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
    public partial class Form3 : Form
    {
        Form1 fgrid;
        public Form3(Form1 fg)

        {
            InitializeComponent();

            this.fgrid = fg;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            fgrid.DevicesDataGridView.Rows.Add(NumberTextBox.Text, TypeTextBox.Text, NameTextBox.Text, CostTextBox.Text);
        }
    }
}
