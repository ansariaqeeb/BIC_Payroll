using BIC_Payroll.Filters;
using DataModel.LoginModel;
using DataModel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers.Employee
{
    [CustomSessionAttribute]
    public class EmployeeController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails();
        Result objRes = new Result();
        
        [Route("Employee/EmployeeDtl")]
        public ActionResult Index()
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Master.Employee obj = new DataModel.Master.Employee();
                List<DataModel.Master.Employee> objList = obj.getEmployee(0, "", Convert.ToInt32(SessLogObj.objComp.COMPID), "", Convert.ToInt32(SessLogObj.USERID));
                return View(objList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddEmployee(DataModel.Master.Employee obj)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                objRes = obj.Save(obj, SessLogObj.objComp.COMPID, Convert.ToInt32(SessLogObj.USERID));
                return Json(objRes, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Employee/Edit/{id}")]
        public ActionResult EditEmployee(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Master.Employee obj = new DataModel.Master.Employee();
                List<DataModel.Master.Employee> modelList = obj.getEmployee(Id, "", Convert.ToInt32(SessLogObj.objComp.COMPID), "", Convert.ToInt32(SessLogObj.USERID));
                return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}