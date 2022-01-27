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

            KeyPreview = true;

            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.Enter) AddPrButton_Click(AddPrButton, null); };
        }
        public FormProperties()
        {
            InitializeComponent();
        }

        private void AddPrButton_Click(object sender, EventArgs e)
        {
            frmpr.ProDevicesDataGredView.Rows.Add(TextBoxN.Text, TextBoxPro.Text, TextBoxMean.Text);
        }

    }
}
