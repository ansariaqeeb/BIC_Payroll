using BIC_Payroll.Filters;
using DataModel.LoginModel;
using DataModel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers.PaySpliEmployeeMap
{
    [CustomSessionAttribute]
    public class PaySlipEmpMapController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails();
        Result objRes = new Result();

         
        // GET: PaySlipEmpMap
        public ActionResult PaySlipEmpMapIndex(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Master.EmployeePaySlipMapping obj = new DataModel.Master.EmployeePaySlipMapping();
                List<DataModel.Master.EmployeePaySlipMapping> objList = obj.getEmployeePaySlipMapping(0, Id,Convert.ToInt32(SessLogObj.USERID));
                ViewBag.EMPID = Id;
                return View(objList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet] 
        public ActionResult AddPaySlipMapping(int Id)
        {
            ViewBag.EMPID = Id;
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddPaySlipMapping(DataModel.Master.EmployeePaySlipMapping obj)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                objRes = obj.Save(obj, Convert.ToInt32(SessLogObj.USERID));
                return Json(objRes, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         
        public ActionResult EditPaySlipMapping(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Master.EmployeePaySlipMapping obj = new DataModel.Master.EmployeePaySlipMapping();
                List<DataModel.Master.EmployeePaySlipMapping> modelList = obj.getEmployeePaySlipMapping(Id, 0, Convert.ToInt32(SessLogObj.USERID));
                return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public JsonResult Delete(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Master.EmployeePaySlipMapping obj = new DataModel.Master.EmployeePaySlipMapping();
                obj.IFLAG = "D";
                obj.MID = Id;
                obj.FORMULA ="";
                
                objRes = obj.Save(obj, Convert.ToInt32(SessLogObj.USERID));
                return Json(objRes, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}