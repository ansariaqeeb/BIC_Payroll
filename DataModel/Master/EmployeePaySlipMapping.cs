using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataModel.Master
{
    public class EmployeePaySlipMapping : Result.Result
    {
        #region Properties 
        XDocument xdoc;
        string _IFLAG;
        Int64 _MID;
        Int64 _HEADID;
        string _HEADCODE;
        string _HEADDESC;
        int _TRANSACTIONTYPE;
        string _STATUSCODE;
        string _STATUSDESC;
        Int64 _EMPID;
        int _CALSEQUENCE;
        decimal _AMOUNT;
        string _FORMULA;
        bool _IsCalculation;
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

        public long MID
        {
            get
            {
                return _MID;
            }

            set
            {
                _MID = value;
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

        public int TRANSACTIONTYPE
        {
            get
            {
                return _TRANSACTIONTYPE;
            }

            set
            {
                _TRANSACTIONTYPE = value;
            }
        }

        public string STATUSCODE
        {
            get
            {
                return _STATUSCODE;
            }

            set
            {
                _STATUSCODE = value;
            }
        }

        public string STATUSDESC
        {
            get
            {
                return _STATUSDESC;
            }

            set
            {
                _STATUSDESC = value;
            }
        }

        public Int64 EMPID
        {
            get
            {
                return _EMPID;
            }

            set
            {
                _EMPID = value;
            }
        }

        public int CALSEQUENCE
        {
            get
            {
                return _CALSEQUENCE;
            }

            set
            {
                _CALSEQUENCE = value;
            }
        }

        public decimal AMOUNT
        {
            get
            {
                return _AMOUNT;
            }

            set
            {
                _AMOUNT = value;
            }
        }

        public string FORMULA
        {
            get
            {
                return _FORMULA;
            }

            set
            {
                _FORMULA = value;
            }
        }

        public bool IsCalculation
        {
            get
            {
                return _IsCalculation;
            }

            set
            {
                _IsCalculation = value;
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
        public EmployeePaySlipMapping()
        {
        }


        public Result.Result Save(EmployeePaySlipMapping obj, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.EMPLOYEEPAYMAPPING_c(obj.IFLAG, obj.MID,obj.HEADID,obj.EMPID,obj.CALSEQUENCE,obj.AMOUNT,obj.IsCalculation, 
                    obj.FORMULA == null ?"":obj.FORMULA,obj.ISACTIVE, USERID, LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<EmployeePaySlipMapping> getEmployeePaySlipMapping(int MID,int EMPID, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.EMPLOYEEPAYMAPPING_g(MID, EMPID, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<EmployeePaySlipMapping> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new EmployeePaySlipMapping
                     {
                         MID = s.Field<Int64>("MID"),
                         HEADID = s.Field<Int64>("HEADID"),
                         HEADCODE = s.Field<string>("HEADCODE"),
                         HEADDESC = s.Field<string>("HEADDESC"),
                         TRANSACTIONTYPE = s.Field<int>("TRANSACTIONTYPE"),
                         STATUSCODE = s.Field<string>("STATUSCODE"),
                         STATUSDESC = s.Field<string>("STATUSDESC"),
                         EMPID = s.Field<Int64>("EMPID"),
                         CALSEQUENCE = s.Field<int>("CALSEQUENCE"),
                         AMOUNT = s.Field<decimal>("AMOUNT"),
                         IsCalculation = s.Field<bool>("IsCalculation"),
                         FORMULA = s.Field<string>("FORMULA"), 
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
