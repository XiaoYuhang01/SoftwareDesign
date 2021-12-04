using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFareSystem1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            bindingSource1.DataSource = Controller.controller.Students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1.MainForm.UpdateForm();
            Form1.MainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student currentStudent = (Student)dataGridView1.CurrentRow.DataBoundItem;
            if(currentStudent.EFareAmount + currentStudent.WFareAmount == 0 && !currentStudent.IfUseOk)
            {
                currentStudent.IfUseOk = true;
                bindingSource1.ResetBindings(true);
                label2.Text = "服务已恢复";
                return;
            }
            if(currentStudent.IfUseOk)
            {
                label2.Text = "使用权限已开启，无需恢复";
                return;
            }
            if(currentStudent.EFareAmount +currentStudent.WFareAmount > 0)
            {
                label2.Text = currentStudent.Name + "尚未缴费，无法恢复";
                return;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
