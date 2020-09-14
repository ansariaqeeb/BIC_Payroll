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
        public ActionResult Edit(int Id)
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
        //public ActionResult EditAppointment(int mid)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //        List<DataModel.Transaction.bookAppointment> modelList = obj.getAppointment(mid, "", "", "", SessLogObj.objDb.BranchId, 0);
        //        return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public ActionResult ViewAppointment(int mid)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //        List<DataModel.Transaction.bookAppointment> modelList = obj.getAppointment(mid, "", "", "", SessLogObj.objDb.BranchId, 0);
        //        return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public ActionResult BillAppointment(int mid)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //        List<DataModel.Transaction.bookAppointment> modelList = obj.getAppointment(mid, "", "", "", SessLogObj.objDb.BranchId, 0);
        //        return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public ActionResult AppointmentView(int mid)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //        List<DataModel.Transaction.bookAppointment> modelList = obj.getAppointment(mid, "", "", "", SessLogObj.objDb.BranchId, 0);
        //        return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public JsonResult Delete(int MID, string invc = "")
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //        obj.IFlag = "D";
        //        obj.Mid = MID;
        //        obj.BookDateTime = DateTime.Now;
        //        obj.BookingNo = "";
        //        obj.CustCode = "";
        //        obj.CustName = "";
        //        obj.DocCod = "";
        //        obj.DocName = "";
        //        obj.PetCode = "";

        //        objRes = obj.Save(obj, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);
        //        return Json(objRes, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public JsonResult Cancel(int MID, string invc = "")
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //        obj.IFlag = "1";
        //        obj.Mid = MID;
        //        obj.BookDateTime = DateTime.Now;
        //        obj.BookingNo = "";
        //        obj.CustCode = "";
        //        obj.CustName = "";
        //        obj.DocCod = "";
        //        obj.DocName = "";
        //        obj.PetCode = "";

        //        objRes = obj.Save(obj, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);
        //        return Json(objRes, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public ActionResult FillCalendar(string desc)
        //{
        //    SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //    DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();

        //    var data = obj.FillCalendar(0, desc, desc, desc, SessLogObj.objDb.BranchId, 0);
        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult EditAppointmentTrans(DataModel.Transaction.AppointmentTrans obj)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        objRes = obj.Save(obj, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);
        //        return Json(objRes, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //[HttpPost]
        //public ActionResult UpdateAppointmentBill(DataModel.Transaction.bookAppointment obj)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        objRes = obj.SaveBillDtl(obj, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);
        //        if (objRes.ResultId > 0 && obj.IFlag != "4")
        //        {
        //            int result = 0;
        //            EvolutionSDK objsdk = EvolutionSDKInstance(SessLogObj);
        //            result = objsdk.PostDetails(obj.Mid, SessLogObj.objDb.BranchId, SessLogObj.objAgent.ID);

        //            DataModel.Transaction.bookAppointment objr = new DataModel.Transaction.bookAppointment();
        //            objr.IFlag = obj.IFlag == "1" ? "3" : "2";
        //            objr.Mid = obj.Mid;
        //            objr.BookDateTime = DateTime.Now;
        //            objr.BookingNo = "";
        //            objr.CustCode = "";
        //            objr.CustName = "";
        //            objr.DocCod = "";
        //            objr.DocName = "";
        //            objr.PetCode = "";
        //            objRes = objr.Save(objr, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);


        //        }
        //        else if (objRes.ResultId > 0 && obj.IFlag == "4")
        //        {
        //            DataModel.Transaction.bookAppointment objr = new DataModel.Transaction.bookAppointment();
        //            objr.IFlag = "2";
        //            objr.Mid = obj.Mid;
        //            objr.BookDateTime = DateTime.Now;
        //            objr.BookingNo = "";
        //            objr.CustCode = "";
        //            objr.CustName = "";
        //            objr.DocCod = "";
        //            objr.DocName = "";
        //            objr.PetCode = "";
        //            objRes = objr.Save(objr, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);
        //        }
        //        return Json(objRes, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public JsonResult Complete(int MID)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //        obj.IFlag = "2";
        //        obj.Mid = MID;
        //        obj.BookDateTime = DateTime.Now;
        //        obj.BookingNo = "";
        //        obj.CustCode = "";
        //        obj.CustName = "";
        //        obj.DocCod = "";
        //        obj.DocName = "";
        //        obj.PetCode = "";

        //        objRes = obj.Save(obj, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);
        //        return Json(objRes, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
        //public JsonResult PostDtl(int MID)
        //{
        //    try
        //    {
        //        SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
        //        int result = 0;
        //        EvolutionSDK objsdk = EvolutionSDKInstance(SessLogObj);
        //        result = objsdk.PostDetails(MID, SessLogObj.objDb.BranchId, SessLogObj.objAgent.ID);

        //        if (result == 1)
        //        {
        //            DataModel.Transaction.bookAppointment obj = new DataModel.Transaction.bookAppointment();
        //            obj.IFlag = "3";
        //            obj.Mid = MID;
        //            obj.BookDateTime = DateTime.Now;
        //            obj.BookingNo = "";
        //            obj.CustCode = "";
        //            obj.CustName = "";
        //            obj.DocCod = "";
        //            obj.DocName = "";
        //            obj.PetCode = "";
        //            objRes = obj.Save(obj, SessLogObj.objDb, SessLogObj.objLoginM.UserId, SessLogObj.objDb.BranchId);

        //        }
        //        else
        //        {
        //            objRes.Message = "Having problem in posting data. Either sage is having issue or you don't have any treatment to post at this point.";
        //            objRes.ResultId = 0;
        //            objRes.Title = "Posting Error";
        //            objRes.Type = "E";
        //        }
        //        return Json(objRes, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
    }
}