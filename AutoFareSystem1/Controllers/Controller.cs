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

        Student Lqw = new Student("001", "a");
        Student Cxb = new Student("002", "b");
        Student Dt = new Student("003", "c");
        Administrator Xyh = new Administrator("000", "管理员1");

        ElctronicFare LqwEF = new ElctronicFare(0);
        ElctronicFare CxbEF = new ElctronicFare(10.4);
        ElctronicFare DtEF = new ElctronicFare(101.3);

        WaterFare LqwWF = new WaterFare(0);
        WaterFare CxbWF = new WaterFare(45);
        WaterFare DtWF = new WaterFare(3.1);

        public Controller()
        {
            controller = this;

            Students = new List<Student>();
            Administrators = new List<Administrator>();
            Students.Add(Lqw); 
            Lqw.Password = "100"; Lqw.EFare = LqwEF; Lqw.WFare = LqwWF; Lqw.IfUseOk = (LqwEF.Amount + LqwWF.Amount) == 0;
            Students.Add(Cxb); 
            Cxb.Password = "200"; Cxb.EFare = CxbEF; Cxb.WFare = CxbWF; Cxb.IfUseOk = (CxbEF.Amount + CxbWF.Amount) == 0;
            Students.Add(Dt); 
            Dt.Password = "300"; Dt.EFare = DtEF; Dt.WFare = DtWF; Dt.IfUseOk = (DtEF.Amount + DtWF.Amount) == 0;
            Administrators.Add(Xyh); 
            Xyh.Password = "000";
        }
    }
}
