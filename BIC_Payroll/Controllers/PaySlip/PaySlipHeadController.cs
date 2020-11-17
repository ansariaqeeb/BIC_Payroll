using BIC_Payroll.Filters;
using DataModel.LoginModel;
using DataModel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers.PaySlip
{
	[CustomSessionAttribute]
	public class PaySlipHeadController : Controller
	{
		LoginSessionDetails SessLogObj = new LoginSessionDetails();
		Result objRes = new Result();

		[Route("PaySlipHead/PaySlipHeadDtl")]
		public ActionResult Index()
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				DataModel.Master.PaySlipHead obj = new DataModel.Master.PaySlipHead();
				List<DataModel.Master.PaySlipHead> objList = obj.getPaySlipHead(0, "","", Convert.ToInt32(SessLogObj.objComp.COMPID),0, Convert.ToInt32(SessLogObj.USERID));
				return View(objList);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		[HttpGet]
		public ActionResult AddPaySlipHead()
		{
			return PartialView();
		}

		[HttpPost]
		public ActionResult AddPaySlipHead(DataModel.Master.PaySlipHead obj)
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

		[Route("PaySlipHead/Edit/{id}")]
		public ActionResult EditPaySlipHead(int Id)
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				DataModel.Master.PaySlipHead obj = new DataModel.Master.PaySlipHead();
				List<DataModel.Master.PaySlipHead> modelList = obj.getPaySlipHead(Id, "","", Convert.ToInt32(SessLogObj.objComp.COMPID), 0, Convert.ToInt32(SessLogObj.USERID));
				return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		
		[HttpGet]
		[Route("PaySlipHead/Formula/{id}")]
		public ActionResult Formula(int Id)
		{
			return PartialView();
		}


		
	}
}