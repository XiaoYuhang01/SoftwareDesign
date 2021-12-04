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
    public partial class Form3 : Form
    {
        public static string currentStudentId;
        public static Student currentStudent;

        public Form3()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
            Form1.MainForm.UpdateForm();
            Form1.MainForm.Show();
        }

        private void charge_btn_Click(object sender, EventArgs e)
        {
            FareSave();
            currentStudent.EFare.Amount = 0;
            currentStudent.WFare.Amount = 0;
            delay.Text = "缴费完成！";
            bindingSource1.ResetBindings(true);
        }

        private void user_Load(object sender, EventArgs e)
        {
            currentStudent = Controller.controller.Students.Find(s=>s.Id == currentStudentId);
            bindingSource1.DataSource = currentStudent;
            dataGridView2.Columns.Add("id", "序号");
            dataGridView2.Columns.Add("EFare", "电费");
            dataGridView2.Columns.Add("WFare", "水费");
            
        }

        private void btn_elec_Click(object sender, EventArgs e)
        {
            currentStudent.EFare.Amount += 5.0;
            if(currentStudent.IfUseOk != false)
            {
                currentStudent.IfUseOk = false;
            }
            bindingSource1.ResetBindings(true);
        }

        private void btn_water_Click(object sender, EventArgs e)
        {
            currentStudent.WFare.Amount += 5.0;
            if (currentStudent.IfUseOk != false)
            {
                currentStudent.IfUseOk = false;
            }
            bindingSource1.ResetBindings(true);
        }

        public void FareSave()
        {
            dataGridView2.Rows.Clear();
            Student.Fare currentFare = new Student.Fare();
            currentFare.EFare = currentStudent.EFareAmount;
            currentFare.WFare = currentStudent.WFareAmount;
            currentStudent.EWFares.Add(currentFare);
            /*foreach (Student.Fare ewfare in currentStudent.EWFares)
            {
                dataGridView2.Rows.Add(currentStudent.EWFares.IndexOf(ewfare), ewfare.EFare, ewfare.WFare);
            }*/
            for(int i = 0; i < currentStudent.EWFares.Count(); i++)
            {
                dataGridView2.Rows.Add(i + 1, currentStudent.EWFares[i].EFare, currentStudent.EWFares[i].WFare);
            }
        }
    }
}
