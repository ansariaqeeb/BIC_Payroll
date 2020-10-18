using BIC_Payroll.Filters;
using DataModel.LoginModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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

                //Form setializing user object and encrypting 
                string userData = JsonConvert.SerializeObject(SessLogObj);
                FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, SessLogObj.USERNAME, DateTime.Now, DateTime.Now.AddDays(1), false, userData);
                string encTicket = FormsAuthentication.Encrypt(authTicket);
                HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                //faCookie.Expires = authTicket.Expiration; // comment for use as non persistence cookie
                Response.Cookies.Add(faCookie);
            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }
    }
}