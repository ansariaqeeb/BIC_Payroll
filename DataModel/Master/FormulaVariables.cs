using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace DataModel.Master
{
    public class FormulaVariables : Result.Result
	{
		#region Properties 
		XDocument xdoc;
		string _IFLAG;
		Int64 _HEADID;
		string _HEADCODE;
		string _HEADDESC;
		string _DESC;
		Int64 _VARID;
		string _VARIABLE;
		Int64 _FIELDID;
		string _FIELDCODE;
		string _FIELDDESC;
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

		public string DESC
		{
			get
			{
				return _DESC;
			}

			set
			{
				_DESC = value;
			}
		}

		public long VARID
		{
			get
			{
				return _VARID;
			}

			set
			{
				_VARID = value;
			}
		}

		public string VARIABLE
		{
			get
			{
				return _VARIABLE;
			}

			set
			{
				_VARIABLE = value;
			}
		}

		public long FIELDID
		{
			get
			{
				return _FIELDID;
			}

			set
			{
				_FIELDID = value;
			}
		}

		public string FIELDDESC
		{
			get
			{
				return _FIELDDESC;
			}

			set
			{
				_FIELDDESC = value;
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

		public string FIELDCODE
		{
			get
			{
				return _FIELDCODE;
			}

			set
			{
				_FIELDCODE = value;
			}
		}
		#endregion
		#region Method
		public Result.Result Save(FormulaVariables obj, int USERID, int COMPID, XElement LOGXML = null)
		{
			try
			{
				xdoc = DBXML.FORMULAVRIABLE_c(obj.IFLAG, obj.HEADID, obj.VARID,obj.VARIABLE == null ? "" : obj.VARIABLE,obj.FIELDID,
					obj.TESTVALUE,obj.ISACTIVE, COMPID, USERID, LOGXML);
				return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		public List<FormulaVariables> getVariables(Int64 VARID,int HEADID, string VARIABLE, int COMPID, int USERID, XElement LOGXML = null)
		{
			try
			{
				xdoc = DBXML.FORMULAVRIABLE_g(VARID, HEADID, VARIABLE,COMPID, USERID, LOGXML);
				DataTable dt = SqlExe.GetDT(xdoc);
				List<FormulaVariables> dbresult = dt != null ?
					(from s in dt.AsEnumerable()
					 select new FormulaVariables
					 {
						 VARID = s.Field<Int64>("VARID"),
						 HEADID = s.Field<Int64>("HEADID"),
						 HEADCODE = s.Field<string>("HEADCODE"),
						 HEADDESC = s.Field<string>("HEADDESC"),
						 VARIABLE = s.Field<string>("VARIABLE"),
						 FIELDID = s.Field<Int64>("FIELDID"),
						 FIELDCODE = s.Field<string>("FIELDCODE"),
						 FIELDDESC = s.Field<string>("FIELDDESC"),
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
