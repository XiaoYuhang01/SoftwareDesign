using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebClinet.ServiceReference1;

namespace WebClinet
{
    public partial class FormClient : Form
    {
        WebService1SoapClient mywebService;

        public FormClient()
        {
            InitializeComponent();
            mywebService = new WebService1SoapClient();
        }

        private void button_SI_Click(object sender, EventArgs e)
        {
            richTextBox.Text = mywebService.GetStudentInformation(textBox_SI.Text);
        }

        private void button_AI_Click(object sender, EventArgs e)
        {
            richTextBox.Text = mywebService.GetAdministratorInformation(textBox_AI.Text);
        }

        private void button_FI_Click(object sender, EventArgs e)
        {
            richTextBox.Text = mywebService.GetStudentFares(textBox_FI.Text);
        }
    }
}
