using BIC_Payroll.Filters;
using DataModel.LoginModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers
{
    [CustomSessionAttribute]
    public class HomeController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails();
     
        // GET: Home
        public ActionResult Index(int Id)
        {
            SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
            try
            {
                DataModel.Company.Company obj = new DataModel.Company.Company();
                List<DataModel.Company.Company> objList = obj.getCompany(Id, "", "", "", Convert.ToInt32(SessLogObj.USERID));
                SessLogObj.objComp = objList != null ? objList.FirstOrDefault() : null;
                Session["SessionInformation"] = SessLogObj;
            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }
    }
}