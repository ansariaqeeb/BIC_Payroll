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
    public class Employee : Result.Result
    {
        #region Properties 
        XDocument xdoc;
        string _IFLAG;
        Int64 _EMPID;
        string _EMPCODE;
        string _NTITLE;
        string _FIRSTNAME;
        string _MIDDLENAME;
        string _LASTNAME;
        string _NICKNAME;
        DateTime _STARTDATE;
        DateTime _DOB;
        string _NATIONALID;
        string _PASSPORTNO;
        string _COUNTRYOFISSUE;
        string _GENDER;
        string _MARITALSTATUS;
        string _DEPENDENT;
        string _YEARSOFSERVICE;
        string _ADDR1COMPLEXNAME;
        string _ADDR1STREETNO;
        string _ADDR1STREETNAME;
        string _ADDR1POSTALCODE; 
        string _ADDR1COUNTRYNAME;  
        string _ADDR1STATENAME; 
        string _ADDR1CITYNAME;
        bool _ADDR2SAMEASADDR1;
        string _ADDR2COMPLEXNAME;
        string _ADDR2STREETNO;
        string _ADDR2STREETNAME;
        string _ADDR2POSTALCODE; 
        string _ADDR2COUNTRYNAME;  
        string _ADDR2STATENAME; 
        string _ADDR2CITYNAME;
        string _WORKPHONE;
        string _HOMEPHONE;
        string _CELLNO;
        string _FAXNO;
        string _SPOUSENAME;
        string _SPOUSENO;
        string _EMAILID;
        decimal _DAILYRATE;
        decimal _WEEKLYRATE;
        decimal _MONTHLYRATE;
        decimal _HOURLYRATE;
        decimal _PREVIUSYEARLYPAY;
        DateTime _LASTINCREAMENTDATE;
        DateTime _TERMINATIONDATE;
        decimal _AVGHOURPERDAY;
        decimal _HOURPERWEEK;
        decimal _DAYSPERMONTH;
        string _WEEKDAYS;
        decimal _ANNUALSTANDARDLEAVE;
        decimal _ANNUALSICKLEAVE;
        decimal _ANNUALOPTIONALLEAVE;
        bool _ISACTIVE;
        int _COMPID;
        string _COMPCODE;
        string _COMPNAME;

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

        public string NICKNAME
        {
            get
            {
                return _NICKNAME;
            }

            set
            {
                _NICKNAME = value;
            }
        }

        public DateTime STARTDATE
        {
            get
            {
                return _STARTDATE;
            }

            set
            {
                _STARTDATE = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return _DOB;
            }

            set
            {
                _DOB = value;
            }
        }

        public string NATIONALID
        {
            get
            {
                return _NATIONALID;
            }

            set
            {
                _NATIONALID = value;
            }
        }

        public string PASSPORTNO
        {
            get
            {
                return _PASSPORTNO;
            }

            set
            {
                _PASSPORTNO = value;
            }
        }

        public string COUNTRYOFISSUE
        {
            get
            {
                return _COUNTRYOFISSUE;
            }

            set
            {
                _COUNTRYOFISSUE = value;
            }
        }

        public string GENDER
        {
            get
            {
                return _GENDER;
            }

            set
            {
                _GENDER = value;
            }
        }

        public string MARITALSTATUS
        {
            get
            {
                return _MARITALSTATUS;
            }

            set
            {
                _MARITALSTATUS = value;
            }
        }

        public string DEPENDENT
        {
            get
            {
                return _DEPENDENT;
            }

            set
            {
                _DEPENDENT = value;
            }
        }

        public string YEARSOFSERVICE
        {
            get
            {
                return _YEARSOFSERVICE;
            }

            set
            {
                _YEARSOFSERVICE = value;
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

        public string WORKPHONE
        {
            get
            {
                return _WORKPHONE;
            }

            set
            {
                _WORKPHONE = value;
            }
        }

        public string HOMEPHONE
        {
            get
            {
                return _HOMEPHONE;
            }

            set
            {
                _HOMEPHONE = value;
            }
        }

        public string CELLNO
        {
            get
            {
                return _CELLNO;
            }

            set
            {
                _CELLNO = value;
            }
        }

        public string FAXNO
        {
            get
            {
                return _FAXNO;
            }

            set
            {
                _FAXNO = value;
            }
        }

        public string SPOUSENAME
        {
            get
            {
                return _SPOUSENAME;
            }

            set
            {
                _SPOUSENAME = value;
            }
        }

        public string SPOUSENO
        {
            get
            {
                return _SPOUSENO;
            }

            set
            {
                _SPOUSENO = value;
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

        public decimal DAILYRATE
        {
            get
            {
                return _DAILYRATE;
            }

            set
            {
                _DAILYRATE = value;
            }
        }

        public decimal WEEKLYRATE
        {
            get
            {
                return _WEEKLYRATE;
            }

            set
            {
                _WEEKLYRATE = value;
            }
        }

        public decimal MONTHLYRATE
        {
            get
            {
                return _MONTHLYRATE;
            }

            set
            {
                _MONTHLYRATE = value;
            }
        }

        public decimal HOURLYRATE
        {
            get
            {
                return _HOURLYRATE;
            }

            set
            {
                _HOURLYRATE = value;
            }
        }

        public decimal PREVIUSYEARLYPAY
        {
            get
            {
                return _PREVIUSYEARLYPAY;
            }

            set
            {
                _PREVIUSYEARLYPAY = value;
            }
        }

        public DateTime LASTINCREAMENTDATE
        {
            get
            {
                return _LASTINCREAMENTDATE;
            }

            set
            {
                _LASTINCREAMENTDATE = value;
            }
        }

        public DateTime TERMINATIONDATE
        {
            get
            {
                return _TERMINATIONDATE;
            }

            set
            {
                _TERMINATIONDATE = value;
            }
        }

        public decimal AVGHOURPERDAY
        {
            get
            {
                return _AVGHOURPERDAY;
            }

            set
            {
                _AVGHOURPERDAY = value;
            }
        }

        public decimal HOURPERWEEK
        {
            get
            {
                return _HOURPERWEEK;
            }

            set
            {
                _HOURPERWEEK = value;
            }
        }

        public decimal DAYSPERMONTH
        {
            get
            {
                return _DAYSPERMONTH;
            }

            set
            {
                _DAYSPERMONTH = value;
            }
        }

        public string WEEKDAYS
        {
            get
            {
                return _WEEKDAYS;
            }

            set
            {
                _WEEKDAYS = value;
            }
        }

        public decimal ANNUALSTANDARDLEAVE
        {
            get
            {
                return _ANNUALSTANDARDLEAVE;
            }

            set
            {
                _ANNUALSTANDARDLEAVE = value;
            }
        }

        public decimal ANNUALSICKLEAVE
        {
            get
            {
                return _ANNUALSICKLEAVE;
            }

            set
            {
                _ANNUALSICKLEAVE = value;
            }
        }

        public decimal ANNUALOPTIONALLEAVE
        {
            get
            {
                return _ANNUALOPTIONALLEAVE;
            }

            set
            {
                _ANNUALOPTIONALLEAVE = value;
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
        #endregion

        #region Methods
        public Employee()
        {
        }


        public Result.Result Save(Employee obj,int COMPID, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.EMPLOYEE_c(
                    obj.IFLAG, 
                    obj.EMPID, 
                    obj.EMPCODE == null ? "" : obj.EMPCODE, 
                    obj.NTITLE == null ? "" : obj.NTITLE,
                    obj.FIRSTNAME == null ? "" : obj.FIRSTNAME,
                    obj.MIDDLENAME == null ? "" : obj.MIDDLENAME,
                    obj.LASTNAME == null ? "" : obj.LASTNAME,
                    obj.NICKNAME == null ? "" : obj.NICKNAME,
                    obj.STARTDATE,
                    obj.DOB,
                    obj.NATIONALID == null ? "" : obj.NATIONALID,
                    obj.PASSPORTNO == null ? "" : obj.PASSPORTNO,
                    obj.COUNTRYOFISSUE == null ? "" : obj.COUNTRYOFISSUE,
                    obj.GENDER == null ? "" : obj.GENDER,
                    obj.MARITALSTATUS == null ? "" : obj.MARITALSTATUS,
                    obj.DEPENDENT == null ? "" : obj.DEPENDENT,
                    obj.YEARSOFSERVICE == null ? "" : obj.YEARSOFSERVICE,
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
                    obj.WORKPHONE == null ? "" : obj.WORKPHONE,
                    obj.HOMEPHONE == null ? "" : obj.HOMEPHONE,
                    obj.CELLNO == null ? "" : obj.CELLNO,
                    obj.FAXNO == null ? "" : obj.FAXNO,
                    obj.SPOUSENAME == null ? "" : obj.SPOUSENAME,
                    obj.SPOUSENO == null ? "" : obj.SPOUSENO,
                    obj.EMAILID == null ? "" : obj.EMAILID,
                    obj.DAILYRATE,
                    obj.WEEKLYRATE,
                    obj.MONTHLYRATE,
                    obj.HOURLYRATE,
                    obj.PREVIUSYEARLYPAY,
                    obj.LASTINCREAMENTDATE,
                    obj.TERMINATIONDATE,
                    obj.AVGHOURPERDAY,
                    obj.HOURPERWEEK,
                    obj.DAYSPERMONTH,
                    obj.WEEKDAYS == null ? "" : obj.WEEKDAYS,
                    obj.ANNUALSTANDARDLEAVE,
                    obj.ANNUALSICKLEAVE, 
                    obj.ANNUALOPTIONALLEAVE,
                    COMPID, 
                    obj.ISACTIVE, 
                    USERID, 
                    LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Employee> getEmployee(int EMPID, string EMPCODE,int COMPID, string DESC, int USERID, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.EMPLOYEE_g(EMPID, EMPCODE, COMPID, DESC, USERID, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<Employee> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new Employee
                     {
                         EMPID = s.Field<Int64>("EMPID"),
                         COMPID = s.Field<int>("COMPID"),
                         EMPCODE = s.Field<string>("EMPCODE"),
                         NTITLE = s.Field<string>("TITLE"),
                         FIRSTNAME = s.Field<string>("FIRSTNAME"),
                         MIDDLENAME = s.Field<string>("MIDDLENAME"),
                         LASTNAME = s.Field<string>("LASTNAME"),
                         NICKNAME = s.Field<string>("NICKNAME"),
                         STARTDATE = s.Field<DateTime>("STARTDATE"),
                         DOB = s.Field<DateTime>("DOB"),
                         NATIONALID = s.Field<string>("NATIONALID"),
                         PASSPORTNO = s.Field<string>("PASSPORTNO"),
                         COUNTRYOFISSUE = s.Field<string>("COUNTRYOFISSUE"),
                         GENDER = s.Field<string>("GENDER"),
                         MARITALSTATUS = s.Field<string>("MARITALSTATUS"),
                         DEPENDENT = s.Field<string>("DEPENDENT"),
                         YEARSOFSERVICE = s.Field<string>("YEARSOFSERVICE"),
                         ADDR1COMPLEXNAME = s.Field<string>("ADDR1COMPLEXNAME"),
                         ADDR1STREETNO = s.Field<string>("ADDR1STREETNO"),
                         ADDR1STREETNAME = s.Field<string>("ADDR1STREETNAME"),
                         ADDR1POSTALCODE = s.Field<string>("ADDR1POSTALCODE"),
                         ADDR1COUNTRYNAME = s.Field<string>("ADDR1COUNTRYNAME"),
                         ADDR1STATENAME = s.Field<string>("ADDR1STATENAME"),
                         ADDR1CITYNAME = s.Field<string>("ADDR1CITYNAME"),
                         ADDR2COMPLEXNAME = s.Field<string>("ADDR2COMPLEXNAME"),
                         ADDR2STREETNO = s.Field<string>("ADDR2STREETNO"),
                         ADDR2STREETNAME = s.Field<string>("ADDR2STREETNAME"),
                         ADDR2POSTALCODE = s.Field<string>("ADDR2POSTALCODE"),
                         ADDR2COUNTRYNAME = s.Field<string>("ADDR2COUNTRYNAME"),
                         ADDR2STATENAME = s.Field<string>("ADDR2STATENAME"),
                         ADDR2CITYNAME = s.Field<string>("ADDR2CITYNAME"),
                         WORKPHONE = s.Field<string>("WORKPHONE"),
                         HOMEPHONE = s.Field<string>("HOMEPHONE"),
                         CELLNO = s.Field<string>("CELLNO"),
                         FAXNO = s.Field<string>("FAXNO"),
                         SPOUSENAME = s.Field<string>("SPOUSENAME"),
                         SPOUSENO = s.Field<string>("SPOUSENO"),
                         EMAILID = s.Field<string>("EMAILID"),
                         DAILYRATE = s.Field<decimal>("DAILYRATE"),
                         WEEKLYRATE = s.Field<decimal>("WEEKLYRATE"),
                         MONTHLYRATE = s.Field<decimal>("MONTHLYRATE"),
                         HOURLYRATE = s.Field<decimal>("HOURLYRATE"),
                         PREVIUSYEARLYPAY = s.Field<decimal>("PREVIUSYEARLYPAY"),
                         LASTINCREAMENTDATE = s.Field<DateTime>("LASTINCREAMENTDATE"),
                         TERMINATIONDATE = s.Field<DateTime>("TERMINATIONDATE"),
                         AVGHOURPERDAY = s.Field<decimal>("AVGHOURPERDAY"),
                         HOURPERWEEK = s.Field<decimal>("HOURPERWEEK"),
                         DAYSPERMONTH = s.Field<decimal>("DAYSPERMONTH"),
                         WEEKDAYS = s.Field<string>("WEEKDAYS"),
                         ANNUALSTANDARDLEAVE = s.Field<decimal>("ANNUALSTANDARDLEAVE"),
                         ANNUALSICKLEAVE = s.Field<decimal>("ANNUALSICKLEAVE"),
                         ANNUALOPTIONALLEAVE = s.Field<decimal>("ANNUALOPTIONALLEAVE"),
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
