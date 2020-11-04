using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataModel.Company
{
    public class Company : Result.Result
    {
        #region Properties 
        XDocument xdoc;
        int _COMPID;
        string _COMPCODE;
        string _COMPNAME;
        string _ADDR1COMPLEXNAME;
        string _ADDR1STREETNO;
        string _ADDR1STREETNAME;
        string _ADDR1POSTALCODE;
        int _ADDR1COUNTRYID;
        string _ADDR1COUNTRYNAME;
        string _ADDR1COUNTRYCODE;
        int _ADDR1STATEID;
        string _ADDR1STATECODE;
        string _ADDR1STATENAME;
        int _ADDR1CITYID;
        string _ADDR1CITYCODE;
        string _ADDR1CITYNAME;
        bool _ADDR2SAMEASADDR1;
        string _ADDR2COMPLEXNAME;
        string _ADDR2STREETNO;
        string _ADDR2STREETNAME;
        string _ADDR2POSTALCODE;
        int _ADDR2COUNTRYID;
        string _ADDR2COUNTRYNAME;
        string _ADDR2COUNTRYCODE;
        int _ADDR2STATEID;
        string _ADDR2STATECODE;
        string _ADDR2STATENAME;
        int _ADDR2CITYID;
        string _ADDR2CITYCODE;
        string _ADDR2CITYNAME;
        string _PRIMARYPHONE;
        string _SECONDARYPHONE;
        string _FAX;
        string _EMAILID;
        string _WEBSITE;
        DateTime _ESTABLISHEDIN;
        int _MANPOWERWORKING;
        string _REGNO;
        bool _ISACTIVE;
        string _IFLAG;
        string _CONTACTPERSONNAME;
        string _CPEMAIL;
        string _CPPHONENO;
        bool _PROCESSMONTHLY;
        int _STARTINGMONTH;
        DateTime _FIRSTMONTHENDDATE;
        int _MONTHSINTAXYEAR;
        List<FREQUENCYPERIODTRANS> _PayFreqTransList;
        int _MID;
        bool _ISCLOSED;
        int _MONTHID;
        string _MONTHENDDATE;

        public int COMPID
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

        public string COMPCODE
        {
            get
            {
                return _COMPCODE;
            }

            set
            {
                _COMPCODE = value;
            }
        }

        public string COMPNAME
        {
            get
            {
                return _COMPNAME;
            }

            set
            {
                _COMPNAME = value;
            }
        }

        public string ADDR1COMPLEXNAME
        {
            get
            {
                return _ADDR1COMPLEXNAME;
            }

            set
            {
                _ADDR1COMPLEXNAME = value;
            }
        }

        public string ADDR1STREETNO
        {
            get
            {
                return _ADDR1STREETNO;
            }

            set
            {
                _ADDR1STREETNO = value;
            }
        }

        public string ADDR1STREETNAME
        {
            get
            {
                return _ADDR1STREETNAME;
            }

            set
            {
                _ADDR1STREETNAME = value;
            }
        }

        public string ADDR1POSTALCODE
        {
            get
            {
                return _ADDR1POSTALCODE;
            }

            set
            {
                _ADDR1POSTALCODE = value;
            }
        }

        public int ADDR1COUNTRYID
        {
            get
            {
                return _ADDR1COUNTRYID;
            }

            set
            {
                _ADDR1COUNTRYID = value;
            }
        }

        public int ADDR1STATEID
        {
            get
            {
                return _ADDR1STATEID;
            }

            set
            {
                _ADDR1STATEID = value;
            }
        }

        public int ADDR1CITYID
        {
            get
            {
                return _ADDR1CITYID;
            }

            set
            {
                _ADDR1CITYID = value;
            }
        }

        public bool ADDR2SAMEASADDR1
        {
            get
            {
                return _ADDR2SAMEASADDR1;
            }

            set
            {
                _ADDR2SAMEASADDR1 = value;
            }
        }

        public string ADDR2COMPLEXNAME
        {
            get
            {
                return _ADDR2COMPLEXNAME;
            }

            set
            {
                _ADDR2COMPLEXNAME = value;
            }
        }

        public string ADDR2STREETNO
        {
            get
            {
                return _ADDR2STREETNO;
            }

            set
            {
                _ADDR2STREETNO = value;
            }
        }

        public string ADDR2STREETNAME
        {
            get
            {
                return _ADDR2STREETNAME;
            }

            set
            {
                _ADDR2STREETNAME = value;
            }
        }

        public string ADDR2POSTALCODE
        {
            get
            {
                return _ADDR2POSTALCODE;
            }

            set
            {
                _ADDR2POSTALCODE = value;
            }
        }

        public int ADDR2COUNTRYID
        {
            get
            {
                return _ADDR2COUNTRYID;
            }

            set
            {
                _ADDR2COUNTRYID = value;
            }
        }

        public int ADDR2STATEID
        {
            get
            {
                return _ADDR2STATEID;
            }

            set
            {
                _ADDR2STATEID = value;
            }
        }

        public int ADDR2CITYID
        {
            get
            {
                return _ADDR2CITYID;
            }

            set
            {
                _ADDR2CITYID = value;
            }
        }

        public string PRIMARYPHONE
        {
            get
            {
                return _PRIMARYPHONE;
            }

            set
            {
                _PRIMARYPHONE = value;
            }
        }

        public string SECONDARYPHONE
        {
            get
            {
                return _SECONDARYPHONE;
            }

            set
            {
                _SECONDARYPHONE = value;
            }
        }

        public string FAX
        {
            get
            {
                return _FAX;
            }

            set
            {
                _FAX = value;
            }
        }

        public string EMAILID
        {
            get
            {
                return _EMAILID;
            }

            set
            {
                _EMAILID = value;
            }
        }

        public string WEBSITE
        {
            get
            {
                return _WEBSITE;
            }

            set
            {
                _WEBSITE = value;
            }
        }

        public DateTime ESTABLISHEDIN
        {
            get
            {
                return _ESTABLISHEDIN;
            }

            set
            {
                _ESTABLISHEDIN = value;
            }
        }

        public int MANPOWERWORKING
        {
            get
            {
                return _MANPOWERWORKING;
            }

            set
            {
                _MANPOWERWORKING = value;
            }
        }

        public string REGNO
        {
            get
            {
                return _REGNO;
            }

            set
            {
                _REGNO = value;
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

        public string ADDR1COUNTRYNAME
        {
            get
            {
                return _ADDR1COUNTRYNAME;
            }

            set
            {
                _ADDR1COUNTRYNAME = value;
            }
        }

        public string ADDR1COUNTRYCODE
        {
            get
            {
                return _ADDR1COUNTRYCODE;
            }

            set
            {
                _ADDR1COUNTRYCODE = value;
            }
        }

        public string ADDR1STATECODE
        {
            get
            {
                return _ADDR1STATECODE;
            }

            set
            {
                _ADDR1STATECODE = value;
            }
        }

        public string ADDR1STATENAME
        {
            get
            {
                return _ADDR1STATENAME;
            }

            set
            {
                _ADDR1STATENAME = value;
            }
        }

        public string ADDR1CITYCODE
        {
            get
            {
                return _ADDR1CITYCODE;
            }

            set
            {
                _ADDR1CITYCODE = value;
            }
        }

        public string ADDR1CITYNAME
        {
            get
            {
                return _ADDR1CITYNAME;
            }

            set
            {
                _ADDR1CITYNAME = value;
            }
        }

        public string ADDR2COUNTRYNAME
        {
            get
            {
                return _ADDR2COUNTRYNAME;
            }

            set
            {
                _ADDR2COUNTRYNAME = value;
            }
        }

        public string ADDR2COUNTRYCODE
        {
            get
            {
                return _ADDR2COUNTRYCODE;
            }

            set
            {
                _ADDR2COUNTRYCODE = value;
            }
        }

        public string ADDR2STATECODE
        {
            get
            {
                return _ADDR2STATECODE;
            }

            set
            {
                _ADDR2STATECODE = value;
            }
        }

        public string ADDR2STATENAME
        {
            get
            {
                return _ADDR2STATENAME;
            }

            set
            {
                _ADDR2STATENAME = value;
            }
        }

        public string ADDR2CITYCODE
        {
            get
            {
                return _ADDR2CITYCODE;
            }

            set
            {
                _ADDR2CITYCODE = value;
            }
        }

        public string ADDR2CITYNAME
        {
            get
            {
                return _ADDR2CITYNAME;
            }

            set
            {
                _ADDR2CITYNAME = value;
            }
        }

        public string CONTACTPERSONNAME
        {
            get
            {
                return _CONTACTPERSONNAME;
            }

            set
            {
                _CONTACTPERSONNAME = value;
            }
        }

        public string CPEMAIL
        {
            get
            {
                return _CPEMAIL;
            }

            set
            {
                _CPEMAIL = value;
            }
        }

        public string CPPHONENO
        {
            get
            {
                return _CPPHONENO;
            }

            set
            {
                _CPPHONENO = value;
            }
        }

        public bool PROCESSMONTHLY
        {
            get
            {
                return _PROCESSMONTHLY;
            }

            set
            {
                _PROCESSMONTHLY = value;
            }
        }

        public int STARTINGMONTH
        {
            get
            {
                return _STARTINGMONTH;
            }

            set
            {
                _STARTINGMONTH = value;
            }
        }

        public DateTime FIRSTMONTHENDDATE
        {
            get
            {
                return _FIRSTMONTHENDDATE;
            }

            set
            {
                _FIRSTMONTHENDDATE = value;
            }
        }

        public int MONTHSINTAXYEAR
        {
            get
            {
                return _MONTHSINTAXYEAR;
            }

            set
            {
                _MONTHSINTAXYEAR = value;
            }
        }

        public List<FREQUENCYPERIODTRANS> PayFreqTransList
        {
            get
            {
                return _PayFreqTransList;
            }

            set
            {
                _PayFreqTransList = value;
            }
        }

        public int MID
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

        public int MONTHID
        {
            get
            {
                return _MONTHID;
            }

            set
            {
                _MONTHID = value;
            }
        }

        public string MONTHENDDATE
        {
            get
            {
                return _MONTHENDDATE;
            }

            set
            {
                _MONTHENDDATE = value;
            }
        }
        #endregion
        #region Method
        public Company()
        {
        }


        public Result.Result Save(Company obj, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.COMPANY_c(obj.IFLAG, obj.COMPID, obj.COMPCODE == null ? "" : obj.COMPCODE, obj.COMPNAME == null ? "" : obj.COMPNAME,
                    obj.ADDR1COMPLEXNAME == null ? "" : obj.ADDR1COMPLEXNAME,
                    obj.ADDR1STREETNO == null ? "" : obj.ADDR1STREETNO,
                    obj.ADDR1STREETNAME == null ? "" : obj.ADDR1STREETNAME,
                    obj.ADDR1POSTALCODE == null ? "" : obj.ADDR1POSTALCODE,
                    obj.ADDR1COUNTRYNAME == null ? "" : obj.ADDR1COUNTRYNAME,
                    obj.ADDR1STATENAME == null ? "" : obj.ADDR1STATENAME,
                    obj.ADDR1CITYNAME == null ? "" : obj.ADDR1CITYNAME,
                    obj.ADDR2SAMEASADDR1,
                    obj.ADDR2COMPLEXNAME == null ? "" : obj.ADDR2COMPLEXNAME,
                    obj.ADDR2STREETNO == null ? "" : obj.ADDR2STREETNO,
                    obj.ADDR2STREETNAME == null ? "" : obj.ADDR2STREETNAME,
                    obj.ADDR2POSTALCODE == null ? "" : obj.ADDR2POSTALCODE,
                    obj.ADDR2COUNTRYNAME == null ? "" : obj.ADDR2COUNTRYNAME,
                    obj.ADDR2STATENAME == null ? "" : obj.ADDR2STATENAME,
                    obj.ADDR2CITYNAME == null ? "" : obj.ADDR2CITYNAME,
                    obj.PRIMARYPHONE == null ? "" : obj.PRIMARYPHONE,
                    obj.SECONDARYPHONE == null ? "" : obj.SECONDARYPHONE,
                    obj.FAX == null ? "" : obj.FAX,
                    obj.EMAILID == null ? "" : obj.EMAILID,
                    obj.WEBSITE == null ? "" : obj.WEBSITE,
                    obj.ESTABLISHEDIN, obj.MANPOWERWORKING, obj.REGNO == null ? "" : obj.REGNO,
                    obj.ISACTIVE,
                    obj.PROCESSMONTHLY,
                    obj.STARTINGMONTH,
                    obj.MONTHSINTAXYEAR,
                    obj.FIRSTMONTHENDDATE, 
                    USERID, LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Company> getCompany(int COMPID, string COMPCODE, string COMPNAME, string DESC, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.COMPANY_g(COMPID, COMPCODE, COMPNAME, DESC, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<Company> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new Company
                     {
                         COMPID = s.Field<int>("COMPID"),
                         COMPCODE = s.Field<string>("COMPCODE"),
                         COMPNAME = s.Field<string>("COMPNAME"),
                         ADDR1COMPLEXNAME = s.Field<string>("ADDR1COMPLEXNAME"),
                         ADDR1STREETNO = s.Field<string>("ADDR1STREETNO"),
                         ADDR1STREETNAME = s.Field<string>("ADDR1STREETNAME"),
                         ADDR1POSTALCODE = s.Field<string>("ADDR1POSTALCODE"), 
                         ADDR1COUNTRYNAME = s.Field<string>("ADDR1COUNTRYNAME"), 
                         ADDR1STATENAME = s.Field<string>("ADDR1STATENAME"),  
                         ADDR1CITYNAME = s.Field<string>("ADDR1CITYNAME"),
                         ADDR2SAMEASADDR1 = s.Field<bool>("ADDR2SAMEASADDR1"),
                         ADDR2COMPLEXNAME = s.Field<string>("ADDR2COMPLEXNAME"),
                         ADDR2STREETNO = s.Field<string>("ADDR2STREETNO"),
                         ADDR2STREETNAME = s.Field<string>("ADDR2STREETNAME"),
                         ADDR2POSTALCODE = s.Field<string>("ADDR2POSTALCODE"), 
                         ADDR2COUNTRYNAME = s.Field<string>("ADDR2COUNTRYNAME"), 
                         ADDR2STATENAME = s.Field<string>("ADDR2STATENAME"), 
                         ADDR2CITYNAME = s.Field<string>("ADDR2CITYNAME"),
                         PRIMARYPHONE = s.Field<string>("PRIMARYPHONE"),
                         SECONDARYPHONE = s.Field<string>("SECONDARYPHONE"),
                         FAX = s.Field<string>("FAX"),
                         EMAILID = s.Field<string>("EMAILID"),
                         WEBSITE = s.Field<string>("WEBSITE"),
                         ESTABLISHEDIN = s.Field<DateTime>("ESTABLISHEDIN"),
                         MANPOWERWORKING = s.Field<int>("MANPOWERWORKING"),
                         REGNO = s.Field<string>("REGNO"),
                         PROCESSMONTHLY = s.Field<bool>("PROCESSMONTHLY"),
                         MONTHSINTAXYEAR = s.Field<int>("MONTHSINTAXYEAR"),
                         FIRSTMONTHENDDATE = s.Field<DateTime>("FIRSTMONTHENDDATE"),
                         STARTINGMONTH = s.Field<int>("STARTINGMONTH"),
                         ISACTIVE = s.Field<bool>("ISACTIVE"),
                         MONTHID = s.Field<int>("MONTHID"),
                         MONTHENDDATE = s.Field<DateTime>("MONTHENDDATE").ToString("dd-MMM-yyyy"),
                     }).ToList() : null;

                return dbresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Company> getPayFrequency(int COMPID, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.PAYFREQUENCY_g(COMPID, 0, 0, "", USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<Company> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new Company
                     {
                         MID = s.Field<int>("MID"),
                         PROCESSMONTHLY = s.Field<bool>("PROCESSMONTHLY"),
                         STARTINGMONTH = s.Field<int>("STARTINGMONTH"),
                         FIRSTMONTHENDDATE = s.Field<DateTime>("FIRSTMONTHENDDATE"),
                         MONTHSINTAXYEAR = s.Field<int>("MONTHSINTAXYEAR"),
                         COMPID = s.Field<int>("COMPID"), 
                         ISACTIVE = s.Field<bool>("MISACTIVE"),
                         ISCLOSED = s.Field<bool>("MISCLOSED"),
                         PayFreqTransList = s.Field<string>("TRANSDETAILS") != null ?
                         (from m in XDocument.Parse(s.Field<string>("TRANSDETAILS")).Elements("TRANSACTION").Elements("TRANS")
                          select new FREQUENCYPERIODTRANS
                          { 
                              TID = m.Attributes("TID").FirstOrDefault().Value == null ? 0 : Convert.ToInt32(m.Attributes("TID").FirstOrDefault().Value),
                              MONTHID = m.Attributes("MONTHID").FirstOrDefault().Value == null ? 0 : Convert.ToInt32(m.Attributes("MONTHID").FirstOrDefault().Value),
                              MONTHENDDATE = Convert.ToDateTime(m.Attributes("MONTHENDDATE").FirstOrDefault().Value),
                              STATUS = m.Attributes("STATUS").FirstOrDefault().Value == null ? "" : Convert.ToString(m.Attributes("STATUS").FirstOrDefault().Value),
                              ISACTIVE = Convert.ToInt32(m.Attributes("ISACTIVE").FirstOrDefault().Value) == 0 ? false : true,
                              ISCLOSED = Convert.ToInt32(m.Attributes("ISCLOSED").FirstOrDefault().Value) == 0 ? false : true,
                              ISCURRENT = Convert.ToInt32(m.Attributes("ISCURRENT").FirstOrDefault().Value) == 0 ? false : true,
                          }).ToList() : null,
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

    public class FREQUENCYPERIODTRANS
    {
        #region Properties
        int _TID;
        int _RMID;
        int _MONTHID;
        DateTime _MONTHENDDATE;
        string _STATUS;
        bool _ISACTIVE;
        bool _ISCLOSED;
        bool _ISCURRENT;

        public int TID
        {
            get
            {
                return _TID;
            }

            set
            {
                _TID = value;
            }
        }

        public int RMID
        {
            get
            {
                return _RMID;
            }

            set
            {
                _RMID = value;
            }
        }

        public int MONTHID
        {
            get
            {
                return _MONTHID;
            }

            set
            {
                _MONTHID = value;
            }
        }

        public DateTime MONTHENDDATE
        {
            get
            {
                return _MONTHENDDATE;
            }

            set
            {
                _MONTHENDDATE = value;
            }
        }

        public string STATUS
        {
            get
            {
                return _STATUS;
            }

            set
            {
                _STATUS = value;
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

        public bool ISCURRENT
        {
            get
            {
                return _ISCURRENT;
            }

            set
            {
                _ISCURRENT = value;
            }
        }
        #endregion
    }
}
