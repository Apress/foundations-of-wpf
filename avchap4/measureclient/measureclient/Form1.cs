using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace measureclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MetricImperialProxy proxy = new MetricImperialProxy())
            {
                double f = proxy.mtof(6);
                MessageBox.Show(f.ToString());
            }
        }
    }
}