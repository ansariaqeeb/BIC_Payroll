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
    public class RateMaster : Result.Result
    {
        #region Properties 
        XDocument xdoc;
        string _IFLAG;
        int _RATEID;
        string _RATECODE;
        string _DESCRIPTION;
        decimal _RATE;
        Int64 _COMPID;
        bool _ISACTIVE;
        int _BASEFACTORID;
        string _BASEFACTORDESC;

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

        public string RATECODE
        {
            get
            {
                return _RATECODE;
            }

            set
            {
                _RATECODE = value;
            }
        }

        public string DESCRIPTION
        {
            get
            {
                return _DESCRIPTION;
            }

            set
            {
                _DESCRIPTION = value;
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

        public int BASEFACTORID
        {
            get
            {
                return _BASEFACTORID;
            }

            set
            {
                _BASEFACTORID = value;
            }
        }

        public string BASEFACTORDESC
        {
            get
            {
                return _BASEFACTORDESC;
            }

            set
            {
                _BASEFACTORDESC = value;
            }
        }
        #endregion
        #region Methods
        public RateMaster()
        {
        }


        public Result.Result Save(RateMaster obj, int USERID, int COMPID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.RATEMASTER_c(obj.IFLAG, obj.RATEID, obj.RATECODE == null ? "" : obj.RATECODE, obj.DESCRIPTION== null ? "" : obj.DESCRIPTION, obj.RATE,
                     obj.ISACTIVE, COMPID,obj.BASEFACTORID, USERID, LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<RateMaster> getRatemaster(int RATEID, string RATECODE, int COMPID, int BASEFACTORID, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.RATEMASTER_g(RATEID, RATECODE, COMPID, BASEFACTORID, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<RateMaster> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new RateMaster
                     {
                         RATEID = s.Field<int>("RATEID"),
                         RATECODE = s.Field<string>("RATECODE"),
                         DESCRIPTION = s.Field<string>("DESCRIPTION"),
                         RATE = s.Field<decimal>("RATE"),
                         BASEFACTORID = s.Field<int>("BASEFACTORID"),
                         BASEFACTORDESC = s.Field<string>("STATUSCODE"),
                         ISACTIVE = s.Field<bool>("ISACTIVE"),
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
                                    text = row.Field<string>("RATECODE") + " "+ row.Field<string>("DESCRIPTION")


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
