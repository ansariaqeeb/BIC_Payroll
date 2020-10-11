using BIC_Payroll.Filters;
using DataModel.LoginModel;
using DataModel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers
{
    [CustomSessionAttribute]
    public class RateController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails();
        Result objRes = new Result();

        [Route("Rate/RateDtl")]
        public ActionResult RateIndex()
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Master.RateMaster obj = new DataModel.Master.RateMaster();
                List<DataModel.Master.RateMaster> objList = obj.getRatemaster(0, "", Convert.ToInt32(SessLogObj.objComp.COMPID), 0, Convert.ToInt32(SessLogObj.USERID));
                return View(objList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public ActionResult AddRate()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddRate(DataModel.Master.RateMaster obj)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                objRes = obj.Save(obj, Convert.ToInt32(SessLogObj.USERID), SessLogObj.objComp.COMPID);
                return Json(objRes, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Rate/Edit/{id}")]
        public ActionResult EditRate(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Master.RateMaster obj = new DataModel.Master.RateMaster();
                List<DataModel.Master.RateMaster> modelList = obj.getRatemaster(Id, "", Convert.ToInt32(SessLogObj.objComp.COMPID), 0, Convert.ToInt32(SessLogObj.USERID));
                return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}