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

        #endregion
        #region Method
        public PaySlipHead()
        {
        }


        public Result.Result Save(PaySlipHead obj, int USERID,int COMPID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.PAYSLIPHEADS_c(obj.IFLAG, obj.HEADID, obj.HEADCODE == null ? "" : obj.HEADCODE, obj.TRANSACTIONTYPEID,
                    obj.DESC == null ? "" : obj.DESC, obj.ISACTIVE, COMPID, USERID, LOGXML);
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
                         ISACTIVE = s.Field<bool>("ISACTIVE"),
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
