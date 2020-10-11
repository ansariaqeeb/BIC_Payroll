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
    public class PaySlipHead : Result.Result
    {
        #region Properties 
        XDocument xdoc;
        string _IFLAG;
        Int64 _HEADID;
        string _HEADCODE;
        string _DESC;
        int _TRANSACTIONTYPEID;
        string _TRANSACTIONTYPECODE;
        bool _ISAFFECTNATIONALPAY;
        bool _ISAFFECTPAYSLIP;
        bool _PRINTONPS;
        int _TYPEOFINPUTID;
        string _TYPEOFINPUTDESC;
        int _RATEID;
        string _RATEDESC;
        bool _ISACTIVE;
        string _FORMULA;
        bool _IsCalculation;
        

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

        public Int64 HEADID
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

        public int TRANSACTIONTYPEID
        {
            get
            {
                return _TRANSACTIONTYPEID;
            }

            set
            {
                _TRANSACTIONTYPEID = value;
            }
        }

        public string TRANSACTIONTYPECODE
        {
            get
            {
                return _TRANSACTIONTYPECODE;
            }

            set
            {
                _TRANSACTIONTYPECODE = value;
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

        public bool ISAFFECTNATIONALPAY
        {
            get
            {
                return _ISAFFECTNATIONALPAY;
            }

            set
            {
                _ISAFFECTNATIONALPAY = value;
            }
        }

        public bool ISAFFECTPAYSLIP
        {
            get
            {
                return _ISAFFECTPAYSLIP;
            }

            set
            {
                _ISAFFECTPAYSLIP = value;
            }
        }

        public bool PRINTONPS
        {
            get
            {
                return _PRINTONPS;
            }

            set
            {
                _PRINTONPS = value;
            }
        }

        public int TYPEOFINPUTID
        {
            get
            {
                return _TYPEOFINPUTID;
            }

            set
            {
                _TYPEOFINPUTID = value;
            }
        }

        public string TYPEOFINPUTDESC
        {
            get
            {
                return _TYPEOFINPUTDESC;
            }

            set
            {
                _TYPEOFINPUTDESC = value;
            }
        }

        public int RATEID
        {
            get
            {
                return _RATEID;
            }

            set
            {
                _RATEID = value;
            }
        }

        public string RATEDESC
        {
            get
            {
                return _RATEDESC;
            }

            set
            {
                _RATEDESC = value;
            }
        }

        #endregion
        #region Method
        public PaySlipHead()
        {
        }


        public Result.Result Save(PaySlipHead obj, int USERID,int COMPID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.PAYSLIPHEADS_c(obj.IFLAG, obj.HEADID, obj.HEADCODE == null ? "" : obj.HEADCODE, obj.TRANSACTIONTYPEID,obj.FORMULA==null?"":obj.FORMULA,obj.IsCalculation,
                    obj.DESC == null ? "" : obj.DESC, obj.ISACTIVE,obj.ISAFFECTNATIONALPAY,obj.ISAFFECTPAYSLIP,obj.PRINTONPS,obj.TYPEOFINPUTID,obj.RATEID, COMPID, USERID, LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<PaySlipHead> getPaySlipHead(int HEADID, string HEADCODE, string DESC, int COMPID,int TRANSACTIONTYPEID, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.PAYSLIPHEADS_g(HEADID, HEADCODE, DESC, COMPID, TRANSACTIONTYPEID, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<PaySlipHead> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new PaySlipHead
                     {
                         HEADID = s.Field<Int64>("HEADID"),
                         HEADCODE = s.Field<string>("HEADCODE"),
                         DESC = s.Field<string>("DESC"),
                         TRANSACTIONTYPEID = s.Field<int>("TRANSACTIONTYPE"),
                         TRANSACTIONTYPECODE = s.Field<string>("STATUSCODE"),
                         FORMULA = s.Field<string>("FORMULA"),
                         IsCalculation = s.Field<bool>("IsCalculation"),
                         ISAFFECTNATIONALPAY = s.Field<bool>("ISAFFECTNATIONALPAY"),
                         ISAFFECTPAYSLIP = s.Field<bool>("ISAFFECTPAYSLIP"),
                         PRINTONPS = s.Field<bool>("PRINTONPS"),
                         TYPEOFINPUTID = s.Field<int>("TYPEOFINPUTID"),
                         TYPEOFINPUTDESC = s.Field<string>("TYPEOFINPUTDESC"),
                         RATEID = s.Field<int>("RATEID"),
                         RATEDESC = s.Field<string>("RATEDESC"),
                         ISACTIVE = s.Field<bool>("ISACTIVE"),
                     }).ToList() : null;

                return dbresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public object fillPaySlipHead(int HEADID, string HEADCODE, string DESC, int COMPID, int TRANSACTIONTYPEID, int USERID, XElement LOGXML = null)
        {
            try
            {

                xdoc = DBXML.PAYSLIPHEADS_g(HEADID, HEADCODE, DESC, COMPID, TRANSACTIONTYPEID, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                var dbResult = (from row in dt.AsEnumerable()
                                select new
                                {
                                    id = row.Field<Int64>("HEADID"),
                                    text = row.Field<string>("HEADCODE"),
                                    transType = row.Field<string>("STATUSCODE"),
                                    FORMULA = row.Field<string>("FORMULA"),
                                    IsCalculation = row.Field<bool>("IsCalculation")

                                }).ToList();
                return dbResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
