﻿using MySql.Data.MySqlClient;
using Sitecore.FakeDb;
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
    public partial class Form1 : Form
    {
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

    }
}
