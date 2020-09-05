using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataModel
{
    public class userMaster:Result.Result
    {
        #region properties
        XDocument xdoc;
        int _USERID;
        string _LOGINID;
        string _Email;
        string _MobileNo;
        bool _MobileVerify;
        bool _EmailVerify;
        string _FNAME;
        string _MNAME;
        string _LNAME;
        DateTime _DOB;
        string _ADDRESS;
        string _PASSWORD;
        string _CONFIRMPASSWORD;
        string _SVRKEY;
        DateTime _SVRDATE;
        string _SecondaryEmailID;
        bool _ISACTIVE;
        bool _ISADMIN;
        string _IFLAG;
        public int USERID
        {
            get
            {
                return _USERID;
            }

            set
            {
                _USERID = value;
            }
        }
        [Required(ErrorMessage = "Please Enter Username")]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Minimum 6 characters required")]
        public string LOGINID
        {
            get
            {
                return _LOGINID;
            }

            set
            {
                _LOGINID = value;
            }
        }
        [Required(ErrorMessage = "Please Enter Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return _MobileNo;
            }

            set
            {
                _MobileNo = value;
            }
        }

        public bool MobileVerify
        {
            get
            {
                return _MobileVerify;
            }

            set
            {
                _MobileVerify = value;
            }
        }

        public bool EmailVerify
        {
            get
            {
                return _EmailVerify;
            }

            set
            {
                _EmailVerify = value;
            }
        }
        [Required(ErrorMessage = "Please Enter First Name")]
        public string FNAME
        {
            get
            {
                return _FNAME;
            }

            set
            {
                _FNAME = value;
            }
        }

        public string MNAME
        {
            get
            {
                return _MNAME;
            }

            set
            {
                _MNAME = value;
            }
        }
        [Required(ErrorMessage = "Please Enter Last Name")]
        public string LNAME
        {
            get
            {
                return _LNAME;
            }

            set
            {
                _LNAME = value;
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

        public string ADDRESS
        {
            get
            {
                return _ADDRESS;
            }

            set
            {
                _ADDRESS = value;
            }
        }
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Minimum 6 characters required")]
        [Required(ErrorMessage = "Please Enter Password")]
        public string PASSWORD
        {
            get
            {
                return _PASSWORD;
            }

            set
            {
                _PASSWORD = value;
            }
        }

        public string SVRKEY
        {
            get
            {
                return _SVRKEY;
            }

            set
            {
                _SVRKEY = value;
            }
        }

        public DateTime SVRDATE
        {
            get
            {
                return _SVRDATE;
            }

            set
            {
                _SVRDATE = value;
            }
        }

        public string SecondaryEmailID
        {
            get
            {
                return _SecondaryEmailID;
            }

            set
            {
                _SecondaryEmailID = value;
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

        public bool ISADMIN
        {
            get
            {
                return _ISADMIN;
            }

            set
            {
                _ISADMIN = value;
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
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Minimum 6 characters required")]
        [Required(ErrorMessage = "Please Enter confirm Password")]
        [CompareAttribute("PASSWORD", ErrorMessage = "Password doesn't match.")]

        public string CONFIRMPASSWORD
        {
            get
            {
                return _CONFIRMPASSWORD;
            }

            set
            {
                _CONFIRMPASSWORD = value;
            }
        }
        #endregion
        #region Methods
        public userMaster()
        {
        }

        public Result.Result Save(userMaster obj, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.userMaster_C(obj.IFLAG, obj.USERID, obj.LOGINID, obj.Email, obj.MobileNo, obj.MobileVerify, obj.EmailVerify, obj.FNAME == null ? "" : obj.FNAME,
                    obj.MNAME==null?"":obj.MNAME,obj.LNAME==null ?"":obj.LNAME,obj.DOB,obj.ADDRESS==null?"":obj.ADDRESS,obj.PASSWORD,obj.SVRKEY,obj.SVRDATE,
                    obj.SecondaryEmailID==null ?"":obj.SecondaryEmailID, obj.ISACTIVE,obj.ISADMIN, LOGXML);
                return ReadBIErrors(Convert.ToString(SqlExe.GetXml(xdoc)));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<userMaster> getUserList(int USERID,string LoginId,string DESC, XElement LOGXML = null)
        {
            try
            {
                xdoc = DBXML.UserMaster_g(0,USERID,LoginId,DESC, LOGXML);
                DataTable dt = SqlExe.GetDT(xdoc);
                List<userMaster> dbresult = dt != null ?
                    (from s in dt.AsEnumerable()
                     select new userMaster
                     {
                         USERID = s.Field<int>("USERID"),
                         LOGINID = s.Field<string>("LOGINID"),
                         Email = s.Field<string>("Email"),
                         MobileNo = s.Field<string>("MobileNo"),
                         MobileVerify = s.Field<bool>("MobileVerify"),
                         EmailVerify = s.Field<bool>("EmailVerify"),
                         FNAME = s.Field<string>("FNAME"),
                         MNAME = s.Field<string>("MNAME"),
                         LNAME = s.Field<string>("LNAME"),
                         DOB = s.Field<DateTime>("DOB"),
                         ADDRESS = s.Field<string>("ADDRESS"),
                         PASSWORD = s.Field<string>("PASSWORD"),
                         SVRKEY = s.Field<string>("SVRKEY"),
                         SVRDATE = s.Field<DateTime>("SVRDATE"),
                         SecondaryEmailID = s.Field<string>("SecondaryEmailID"),
                         ISACTIVE = s.Field<bool>("ISACTIVE"),
                         ISADMIN = s.Field<bool>("ISADMIN")
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
