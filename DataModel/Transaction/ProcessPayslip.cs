using DataAccess;
using DataModel.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataModel.Transaction
{
    public class ProcessPayslip : Result.Result
    {
        #region Properties 
        XDocument xdoc;
        string _IFLAG;
        Int64 _MAPPINGID;
        Int64 _HEADID;
        string _HEADCODE;
        string _HEADDESC;
        Int64 _EMPID;
        int _CALSEQUENCE;
        decimal _MAPAMOUNT;
        int _TRANSACTIONTYPE;
        string _TRANSACTIONTYPEDESC;
        bool _IsCalculation;
        bool _ISAFFECTNATIONALPAY;
        bool _ISAFFECTPAYSLIP;
        bool _PRINTONPS;
        int _TYPEOFINPUTID;
        string _TYPEOFINPUTDESC;
        int _RATEID;
        string _RATEDESC;
        int _PERIODID;
        int _PERIODTRANS;
        Int64 _PROCESSID;
        decimal _QTY;
        decimal _RATE;
        decimal _AMOUNT;
        bool _ISOVERRIDE;
        string _REFERENCE;
        string _EMPCODE;
        string _NTITLE;
        string _FIRSTNAME;
        string _MIDDLENAME;
        string _LASTNAME;
        bool _ISPROCESSED;
        bool _ISCLOSED;
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

        public long MAPPINGID
        {
            get
            {
                return _MAPPINGID;
            }

            set
            {
                _MAPPINGID = value;
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

        public long EMPID
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

        public decimal MAPAMOUNT
        {
            get
            {
                return _MAPAMOUNT;
            }

            set
            {
                _MAPAMOUNT = value;
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

        public string TRANSACTIONTYPEDESC
        {
            get
            {
                return _TRANSACTIONTYPEDESC;
            }

            set
            {
                _TRANSACTIONTYPEDESC = value;
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

        public int PERIODID
        {
            get
            {
                return _PERIODID;
            }

            set
            {
                _PERIODID = value;
            }
        }

        public int PERIODTRANS
        {
            get
            {
                return _PERIODTRANS;
            }

            set
            {
                _PERIODTRANS = value;
            }
        }

        public long PROCESSID
        {
            get
            {
                return _PROCESSID;
            }

            set
            {
                _PROCESSID = value;
            }
        }

        public decimal QTY
        {
            get
            {
                return _QTY;
            }

            set
            {
                _QTY = value;
            }
        }

        public decimal RATE
        {
            get
            {
                return _RATE;
            }

            set
            {
                _RATE = value;
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

        public bool ISOVERRIDE
        {
            get
            {
                return _ISOVERRIDE;
            }

            set
            {
                _ISOVERRIDE = value;
            }
        }

        public string REFERENCE
        {
            get
            {
                return _REFERENCE;
            }

            set
            {
                _REFERENCE = value;
            }
        }

        public string EMPCODE
        {
            get
            {
                return _EMPCODE;
            }

            set
            {
                _EMPCODE = value;
            }
        }

        public string NTITLE
        {
            get
            {
                return _NTITLE;
            }

            set
            {
                _NTITLE = value;
            }
        }

        public string FIRSTNAME
        {
            get
            {
                return _FIRSTNAME;
            }

            set
            {
                _FIRSTNAME = value;
            }
        }

        public string MIDDLENAME
        {
            get
            {
                return _MIDDLENAME;
            }

            set
            {
                _MIDDLENAME = value;
            }
        }

        public string LASTNAME
        {
            get
            {
                return _LASTNAME;
            }

            set
            {
                _LASTNAME = value;
            }
        }

        public bool ISPROCESSED
        {
            get
            {
                return _ISPROCESSED;
            }

            set
            {
                _ISPROCESSED = value;
            }
        }

        public bool ISCLOSED
        {
            get
            {
                return _ISCLOSED;
            }

            set
            {
                _ISCLOSED = value;
            }
        }


        #endregion
        #region Methods
        public ProcessPayslip()
        {
        }


        public Result.Result Save(List<ProcessPayslip> objList, int USERID, int COMPID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.PROCESSPAYSLIP_c("I",  COMPID, CreateTransXMl(objList), USERID, LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
        public XElement CreateTransXMl(List<ProcessPayslip> objList)
        {
            XElement xmlTrans = new XElement("TRANSLIST",
                objList == null ? null : objList.Select(x => new XElement("TRANS",
                 new XAttribute("PROCESSID", x.PROCESSID),
                 new XAttribute("QTY", x.QTY),
                 new XAttribute("AMOUNT", x.AMOUNT),
                 new XAttribute("ISOVERRIDE", x.ISOVERRIDE),
                 new XAttribute("REFERENCE", x.REFERENCE == null ? "" : x.REFERENCE),
                 new XAttribute("EMPID", x.EMPID),
                 new XAttribute("HEADID", x.HEADID),
                 new XAttribute("RATE", x.RATE),
                 new XAttribute("PERIODID", x.PERIODID),
                 new XAttribute("PERIODTRANS", x.PERIODTRANS))));

            return xmlTrans;
        }
        public List<ProcessPayslip> getEmpCurrentPaySlip(Int64 EMPID,Int64 COMPID, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.PROCESSPAYSLIP_g(EMPID, COMPID, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<ProcessPayslip> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new ProcessPayslip
                     {
                         EMPCODE = s.Field<string>("EMPCODE"),
                         FIRSTNAME = s.Field<string>("FIRSTNAME"),
                         LASTNAME = s.Field<string>("LASTNAME"), 
                         MAPPINGID = s.Field<Int64>("MAPPINGID"),
                         HEADID = s.Field<Int64>("HEADID"),
                         EMPID = s.Field<Int64>("EMPID"),
                         CALSEQUENCE = s.Field<int>("CALSEQUENCE"),
                         MAPAMOUNT = s.Field<decimal>("MAPAMOUNT"),
                         HEADCODE = s.Field<string>("HEADCODE"),
                         HEADDESC = s.Field<string>("HEADDESC"),
                         TRANSACTIONTYPE = s.Field<int>("TRANSACTIONTYPE"),
                         TRANSACTIONTYPEDESC = s.Field<string>("TRANSACTIONTYPEDESC"),
                         IsCalculation = s.Field<bool>("IsCalculation"),
                         ISAFFECTNATIONALPAY = s.Field<bool>("ISAFFECTNATIONALPAY"),
                         ISAFFECTPAYSLIP = s.Field<bool>("ISAFFECTPAYSLIP"),
                         PRINTONPS = s.Field<bool>("PRINTONPS"),
                         TYPEOFINPUTID = s.Field<int>("TYPEOFINPUTID"),
                         TYPEOFINPUTDESC = s.Field<string>("TYPEOFINPUTDESC"),
                         RATEID = s.Field<int>("RATEID"),
                         RATEDESC = s.Field<string>("RATEDESC"),
                         PERIODID = s.Field<int>("PERIODID"),
                         PERIODTRANS = s.Field<int>("PERIODTRANS"),
                         PROCESSID = s.Field<Int64>("PROCESSID"),
                         QTY = s.Field<decimal>("QTY"),
                         RATE = s.Field<decimal>("RATE"),
                         AMOUNT = s.Field<decimal>("AMOUNT"),
                         ISOVERRIDE = s.Field<bool>("ISOVERRIDE"),
                         REFERENCE = s.Field<string>("REFERENCE"),
                         ISPROCESSED = s.Field<bool>("ISPROCESSED"),
                         ISCLOSED = s.Field<bool>("ISCLOSED")
                     }).ToList() : null;

                return dbresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object fillRateMaster(int RATEID, string RATECODE, int COMPID, int BASEFACTORID, int USERID, XElement LOGXML = null)
        {
            try
            {

                xdoc = DBXML.RATEMASTER_g(RATEID, RATECODE, COMPID, BASEFACTORID, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                var dbResult = (from row in dt.AsEnumerable()
                                select new
                                {
                                    id = row.Field<int>("RATEID"),
                                    text = row.Field<string>("RATECODE") + " " + row.Field<string>("DESCRIPTION")


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
