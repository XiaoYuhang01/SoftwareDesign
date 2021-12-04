using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AutoFareSystem1;

namespace WebApplication1
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string GetStudentInformation(string id)
        {
            Controller controllerExample = new Controller();
            Student currentStudent = Controller.controller.Students.Find(student => student.Id == id);
            string studentInformation = "学生帐号:" + currentStudent.Id  + 
                                                          " 学生姓名:" + currentStudent.Name +
                                                          " 当前需交电费:" + currentStudent.EFareAmount.ToString() +
                                                          " 当前需交水费:" + currentStudent.WFareAmount.ToString(); 
            return studentInformation;
        }

        [WebMethod]
        public string GetStudentFares(string id)
        {
            Controller controllerExample = new Controller();
            Student currentStudent = Controller.controller.Students.Find(student => student.Id == id);
            
            string studentHistroicFares = "";
            foreach(Student.Fare fare in currentStudent.EWFares)
            {
                studentHistroicFares += "缴费次序:" + currentStudent.EWFares.IndexOf(fare) + "电费:" + fare.EFare.ToString() + " 水费:" + fare.WFare.ToString();  
            }
            return studentHistroicFares;
        }

        [WebMethod]
        public string GetAdministratorInformation(string id)
        {
            Controller controllerExample = new Controller();
            Administrator currentAdministrator = Controller.controller.Administrators.Find(Administrator => Administrator.Id == id);
            string AdministratorInformation = "管理员账号:" + currentAdministrator.Id + " 管理员姓名:" + currentAdministrator.Name;
            return AdministratorInformation;
        }

    }
}
