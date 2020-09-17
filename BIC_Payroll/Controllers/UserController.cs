using DataModel.LoginModel;
using DataModel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers
{
    public class UserController : Controller
    {
        LoginSessionDetails SessLogObj = new LoginSessionDetails();
        Result objRes = new Result();


        [Route("User/UserDtl")]
        public ActionResult UserIndex()
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.userMaster obj = new DataModel.userMaster();
                List<DataModel.userMaster> objList = obj.getLKUserList(Convert.ToInt32(SessLogObj.USERID));
                return View(objList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        [Route("User/Add")]
        public ActionResult AddUser()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddUser(DataModel.userMaster obj)
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

        [Route("User/Edit/{id}")]
        public ActionResult EditUser(int Id)
        {
            try
            {
                SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
                DataModel.userMaster obj = new DataModel.userMaster();
                List<DataModel.userMaster> modelList = obj.getUserList(Id, "","");
                return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null); 
            }
            catch (Exception ex)
            { 
                throw;
            }
        }

    }
}