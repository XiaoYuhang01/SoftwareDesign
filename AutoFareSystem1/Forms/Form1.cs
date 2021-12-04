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
    public partial class Form1 : Form
    {
        public static Form1 MainForm;
        public Form2 AdministratorForm;

        public Form1()
        {
            InitializeComponent();
            MainForm = this;
        }

        public void UpdateForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Student student in Controller.GetController().Students)
            {
                if(textBox1.Text == null)
                {
                    label4.Text = "请输入账号"; return;
                }
                if(textBox1.Text == student.Id)
                {
                    if (textBox2.Text == student.Password)
                    {
                        //label4.Text = student.Name + ", 欢迎您"; return;
                        Form3 user = new Form3();
                        Form3.currentStudentId = textBox1.Text;
                        user.Show();
                        this.Hide();
                    }
                    else
                    {
                        label4.Text = "密码错误"; return;
                    }
                }
            }
            label4.Text = "此学生账号不存在";return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Administrator administrator in Controller.GetController().Administrators)
            {
                if (textBox1.Text == administrator.Id)
                {
                    if (textBox2.Text == administrator.Password)
                    {
                        AdministratorForm = new Form2();
                        AdministratorForm.Show();
                        this.Hide();
                        AdministratorForm.label1.Text = administrator.Name + ", 欢迎您";
                        label4.Text = administrator.Name + ", 欢迎您"; return;
                    }
                    else
                    {
                        label4.Text = "密码错误"; return;
                    }
                }
            }
            label4.Text = "此管理员账号不存在";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
