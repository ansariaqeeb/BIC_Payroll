using BIC_Payroll.Filters;
using DataModel.LoginModel;
using DataModel.Master;
using DataModel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIC_Payroll.Controllers
{
	[CustomSessionAttribute]
	public class FormulaController : Controller
	{
		LoginSessionDetails SessLogObj = new LoginSessionDetails();
		Result objRes = new Result();

		[HttpGet]
		[Route("Formula/Formula/{id}")]
		public ActionResult Index(int Id)
		{
			ViewBag.Id = Id;
			return PartialView();
		}

		public ActionResult GetFormulaVariable(int Id)
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				FormulaVariables obj = new FormulaVariables();
				ViewBag.Id = Id;
				List<FormulaVariables> objList = obj.getVariables(0,Id,"", Convert.ToInt32(SessLogObj.objComp.COMPID), Convert.ToInt32(SessLogObj.USERID));
				return PartialView(objList);
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public ActionResult GetFormulaCalculation(int Id)
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				FormulaCalculation obj = new FormulaCalculation();
				ViewBag.Id = Id;
				List<FormulaCalculation> objList = obj.getFormulaCalculations(0,Id, SessLogObj.objComp.COMPID, SessLogObj.USERID);
				return PartialView(objList);
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		[HttpGet]
		public ActionResult AddFormulaVariable(int Id)
		{
			ViewBag.Id = Id;
			return PartialView();
		}

		[HttpPost]
		public ActionResult AddFormulaVariable(FormulaVariables obj)
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

		public ActionResult EditFormulaVariable(int Id,int HeadId)
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				FormulaVariables obj = new FormulaVariables();
				List<FormulaVariables> modelList = obj.getVariables(Id, Id, "", Convert.ToInt32(SessLogObj.objComp.COMPID), Convert.ToInt32(SessLogObj.USERID));
				return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		[HttpGet]
		public ActionResult AddFormulaCalculation(int Id)
		{
			ViewBag.Id = Id;
			return PartialView();
		}

		[HttpPost]
		public ActionResult AddFormulaCalculation(FormulaCalculation obj)
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

		public ActionResult EditFormulaCalculation(int Id, int HeadId)
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				FormulaCalculation obj = new FormulaCalculation();
				List<FormulaCalculation> modelList = obj.getFormulaCalculations(Id, HeadId, Convert.ToInt32(SessLogObj.objComp.COMPID), Convert.ToInt32(SessLogObj.USERID));
				return PartialView((modelList != null && modelList.Count > 0) ? modelList.FirstOrDefault() : null);
			}
			catch (Exception ex)
			{
				throw;
			}
		}
		public JsonResult FormulaCalculationDelete(int Id)
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				FormulaCalculation obj = new FormulaCalculation();
				obj.IFLAG = "D";
				obj.CALID = Id; 

				objRes = obj.Save(obj, Convert.ToInt32(SessLogObj.USERID), SessLogObj.objComp.COMPID);
				return Json(objRes, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public JsonResult FormulaVariableDelete(int Id)
		{
			try
			{
				SessLogObj = (LoginSessionDetails)HttpContext.Session["SessionInformation"];
				FormulaVariables obj = new FormulaVariables();
				obj.IFLAG = "D";
				obj.VARID = Id;

				objRes = obj.Save(obj, Convert.ToInt32(SessLogObj.USERID), SessLogObj.objComp.COMPID);
				return Json(objRes, JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}