using BIC_Payroll.Filters;
using DataModel.LoginModel;
using DataModel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers.Company
{
    [CustomSessionAttribute]
    public class CompanyController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails(); 
        Result objRes = new Result();
         

        [Route("Company/CompanyDtl")]
        public ActionResult Index()
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Company.Company obj = new DataModel.Company.Company();
                List<DataModel.Company.Company> objList = obj.getCompany(0,"","","",Convert.ToInt32(SessLogObj.USERID));
                return View(objList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult CompanyList()
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Company.Company obj = new DataModel.Company.Company();
                List<DataModel.Company.Company> objList = obj.getCompany(0, "", "", "", Convert.ToInt32(SessLogObj.USERID));
                return Json(objList, JsonRequestBehavior.AllowGet); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Company/Add")]
        public ActionResult AddCompany()
        { 
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddCompany(DataModel.Company.Company obj)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                objRes = obj.Save(obj,Convert.ToInt32(SessLogObj.USERID));
                return Json(objRes, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Company/Edit/{id}")]
        public ActionResult EditCompany(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Company.Company obj = new DataModel.Company.Company();
                List<DataModel.Company.Company> modelList = obj.getCompany(Id, "", "", "", Convert.ToInt32(SessLogObj.USERID));
                return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [Route("Company/PayFrequency")]
        public ActionResult GetPayFrequency()
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.Company.Company obj = new DataModel.Company.Company();
                List<DataModel.Company.Company> objList = obj.getPayFrequency(SessLogObj.objComp.COMPID, 0);
                return PartialView((objList != null && objList.Count > 0) ? objList.FirstOrDefault() : null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}