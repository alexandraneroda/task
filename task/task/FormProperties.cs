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
    public partial class FormProperties : Form
    {
        Form1 frmpr;
        public FormProperties(Form1 fp)
        {
            InitializeComponent();

            this.frmpr = fp;
        }
        public FormProperties()
        {
            InitializeComponent();
        }

        private void AddPrButton_Click(object sender, EventArgs e)
        {
            //SendKeys.Send(TextBoxN.Text, TextBoxPro.Text, TextBoxMean.Text);

            //SendKeys.Send("{ENTER}");
            frmpr.ProDevicesDataGredView.Rows.Add(TextBoxN.Text, TextBoxPro.Text, TextBoxMean.Text);
        }
    }
}
