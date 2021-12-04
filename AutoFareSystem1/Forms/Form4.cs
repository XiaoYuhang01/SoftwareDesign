using AutoFareSystem1.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFareSystem1.Forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button_webserver_Click(object sender, EventArgs e)
        {
            WebService1SoapClient aa = new WebService1SoapClient();
        }
    }
}
