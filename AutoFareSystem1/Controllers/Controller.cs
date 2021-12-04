using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFareSystem1
{
    public class Controller
    {
        static public Controller controller; 
        public List<Student> Students { get; set; }
        public List<Administrator> Administrators { get; set; }

        Student Lqw = new Student("001", "a", 0, 0);
        Student Cxb = new Student("002", "b" , 0, 0);
        Student Dt = new Student("003", "c", 0, 0);
        Administrator Xyh = new Administrator("000", "管理员1");


        public Controller()
        {
            controller = this;

            Students = new List<Student>();
            Administrators = new List<Administrator>();
            Students.Add(Lqw); 
            Lqw.Password = "100"; 
            Students.Add(Cxb); 
            Cxb.Password = "200"; 
            Students.Add(Dt); 
            Dt.Password = "300"; 
            Administrators.Add(Xyh); 
            Xyh.Password = "000";
        }

        public static Controller GetController()
        {
            if(controller == null)
            {
                controller = new Controller();
            }
            return controller;
        }
    }
}
