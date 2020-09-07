using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataModel.LoginModel
{
    public class LoginSessionDetails
    {
        public Int64 USERID { get; set; }
        public string SVRKEY { get; set; }
        public DateTime SVRDATE { get; set; }
        public string LOGINID { get; set; }
        public string USERNAME { get; set; } 
        public int COMPID { get; set; }
        public string Email { get; set; }
        public string FNAME { get; set; }
        public string LNAME { get; set; }
        public string MNAME { get; set; }
        public bool ISACTIVE { get; set; }
        public bool ISADMIN { get; set; } 
        public LoginModels objLoginM { get; set; }
    }
}
