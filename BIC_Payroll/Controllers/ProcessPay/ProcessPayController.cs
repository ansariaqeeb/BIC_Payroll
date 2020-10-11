using BIC_Payroll.Filters;
using DataModel.LoginModel;
using DataModel.Result;
using DataModel.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers.ProcessPay
{
    [CustomSessionAttribute]
    public class ProcessPayController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails();
        Result objRes = new Result();
        // GET: ProcessPay
        [Route("ProcessPay/ProcessPayDtl")]
        public ActionResult ProcessPayIndex()
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

        [Route("ProcessPay/LoadPayslip/{id}")]
        public ActionResult GetEmpPaySlip(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                ProcessPayslip obj = new ProcessPayslip();
                List<ProcessPayslip> modelList = obj.getEmpCurrentPaySlip(Convert.ToInt64(Id), Convert.ToInt64(SessLogObj.objComp.COMPID),Convert.ToInt32(SessLogObj.USERID));
                return PartialView((modelList != null && modelList.Count > 0) ? modelList: null);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult EmpPaySlip(List<ProcessPayslip> objList)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                ProcessPayslip obj = new ProcessPayslip();
                objRes = obj.Save(objList, SessLogObj.objComp.COMPID, Convert.ToInt32(SessLogObj.USERID));
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}