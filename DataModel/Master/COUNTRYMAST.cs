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
    public class COUNTRYMAST : Result.Result
    {
        #region Properties 
        XDocument xdoc;
        int _COUNTRYID;
        string _COUNTRYCODE;
        string _SHORTNAME;
        string COUNTRYNAME;
        bool _ISACTIVE;
        string _IFLAG;

        public int COUNTRYID
        {
            get
            {
                return _COUNTRYID;
            }

            set
            {
                _COUNTRYID = value;
            }
        }

        public string COUNTRYCODE
        {
            get
            {
                return _COUNTRYCODE;
            }

            set
            {
                _COUNTRYCODE = value;
            }
        }

        public string SHORTNAME
        {
            get
            {
                return _SHORTNAME;
            }

            set
            {
                _SHORTNAME = value;
            }
        }

        public string COUNTRYNAME1
        {
            get
            {
                return COUNTRYNAME;
            }

            set
            {
                COUNTRYNAME = value;
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
        #endregion
        #region Methods
        public COUNTRYMAST()
        {
        }


        public Result.Result Save(COUNTRYMAST obj, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.COUNTRYMAST_c(obj.IFLAG,obj.COUNTRYID,obj.COUNTRYCODE,obj.SHORTNAME,obj.COUNTRYNAME1,obj.ISACTIVE, USERID, LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<COUNTRYMAST> getCountry(int COUNTRYID, string COUNTRCODE, string COUNTRNAME, string DESC, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.COUNTRYMAST_g(COUNTRYID, COUNTRCODE, COUNTRNAME, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<COUNTRYMAST> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new COUNTRYMAST
                     {
                         COUNTRYID = s.Field<int>("COUNTRYID"),
                         COUNTRYNAME = s.Field<string>("COUNTRYNAME"),
                         COUNTRYCODE = s.Field<string>("COUNTRYCODE"),
                         SHORTNAME = s.Field<string>("SHORTNAME"),
                         ISACTIVE = s.Field<bool>("ISACTIVE")
                     }).ToList() : null;

                return dbresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 

        public object fillCountryList(int COUNTRYID, string COUNTRCODE, string COUNTRNAME, string DESC, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.COUNTRYMAST_g(COUNTRYID, COUNTRCODE, COUNTRNAME, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                var dbResult = (from row in dt.AsEnumerable()
                                select new
                                {
                                    id = row.Field<int>("COUNTRYID"),
                                    text = row.Field<string>("COUNTRYNAME")
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
