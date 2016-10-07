using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;


namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndpointAddress addr = new EndpointAddress("http://localhost:4454/bikeservice/Service.svc");
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<DataSet> fact = new ChannelFactory<DataSet>;



        }
    }
}