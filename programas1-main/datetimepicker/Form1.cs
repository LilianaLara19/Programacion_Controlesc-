﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            lblfecha.Text = fecha.ToString();
        }

        private void btncalular_Click(object sender, EventArgs e)
        {
            double dias= Convert.ToDouble(txtDias.Text);
            dateTimePicker1.Value = DateTime.Today.AddDays(dias);
        }
    }
}
