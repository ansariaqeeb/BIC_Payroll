using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace DataModel.Master
{
	public class FormulaCalculation : Result.Result
	{
		#region Properties 
		XDocument xdoc;
		string _IFLAG;
		Int64 _HEADID;
		string _HEADCODE;
		string _HEADDESC; 
		Int64 _CALID;
		string _CONDITION;
		string _CALCULATION;
		string _RESULT;
		bool _ISEXIT;
		decimal _TESTVALUE;
		Int64 _COMPID;
		bool _ISACTIVE;

		public string IFLAG
		{
			get
			{
				return _IFLAG;
			}

			set
			{
				_IFLAG = value;
			}
		}

		public long HEADID
		{
			get
			{
				return _HEADID;
			}

			set
			{
				_HEADID = value;
			}
		}

		public string HEADCODE
		{
			get
			{
				return _HEADCODE;
			}

			set
			{
				_HEADCODE = value;
			}
		}

		public string HEADDESC
		{
			get
			{
				return _HEADDESC;
			}

			set
			{
				_HEADDESC = value;
			}
		}

		public long CALID
		{
			get
			{
				return _CALID;
			}

			set
			{
				_CALID = value;
			}
		}

		public string CONDITION
		{
			get
			{
				return _CONDITION;
			}

			set
			{
				_CONDITION = value;
			}
		}

		public string CALCULATION
		{
			get
			{
				return _CALCULATION;
			}

			set
			{
				_CALCULATION = value;
			}
		}

		public string RESULT
		{
			get
			{
				return _RESULT;
			}

			set
			{
				_RESULT = value;
			}
		}

		public bool ISEXIT
		{
			get
			{
				return _ISEXIT;
			}

			set
			{
				_ISEXIT = value;
			}
		}

		public decimal TESTVALUE
		{
			get
			{
				return _TESTVALUE;
			}

			set
			{
				_TESTVALUE = value;
			}
		}
		public long COMPID
		{
			get
			{
				return _COMPID;
			}

			set
			{
				_COMPID = value;
			}
		}

		public bool ISACTIVE
		{
			get
			{
				return _ISACTIVE;
			}

			set
			{
				_ISACTIVE = value;
			}
		}
		#endregion
		#region Method
		public Result.Result Save(FormulaCalculation obj, int USERID, int COMPID, XElement LOGXML = null)
		{
			try
			{
				xdoc = DBXML.FORMULACALCULATION_c(obj.IFLAG, obj.CALID, obj.HEADID, obj.CONDITION == null ? "" : obj.CONDITION,
					 obj.CALCULATION == null ? "" : obj.CALCULATION, obj.ISEXIT,obj.RESULT == null ? "" : obj.RESULT,
					obj.TESTVALUE, obj.ISACTIVE, COMPID, USERID, LOGXML);
				return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		public List<FormulaCalculation> getFormulaCalculations(Int64 CALID,int HEADID, Int64 COMPID, Int64 USERID, XElement LOGXML = null)
		{
			try
			{
				xdoc = DBXML.FORMULACALCULATION_g(CALID, HEADID, COMPID, USERID, LOGXML);
				DataTable dt = SqlExe.GetDT(xdoc);
				List<FormulaCalculation> dbresult = dt != null ?
					(from s in dt.AsEnumerable()
					 select new FormulaCalculation
					 {
						 CALID = s.Field<Int64>("CALID"),
						 HEADID = s.Field<Int64>("HEADID"),
						 HEADCODE = s.Field<string>("HEADCODE"),
						 HEADDESC = s.Field<string>("HEADDESC"),
						 CONDITION = s.Field<string>("CONDITION"),
						 CALCULATION = s.Field<string>("CALCULATION"),
						 ISEXIT = s.Field<bool>("ISEXIT"),
						 RESULT = s.Field<string>("RESULT"),
						 TESTVALUE = s.Field<decimal>("TESTVALUE"),
						 ISACTIVE = s.Field<bool>("ISACTIVE")
					 }).ToList() : null;

				return dbresult;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion
	}
}
