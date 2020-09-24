using DataAccess;
using DataModel.Master; 
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataModel.CommonModel
{
    public class CommonLibrary
    {
        XDocument Xdoc;
        DataTable dt;
        string dbConnectionString = ConfigurationManager.AppSettings["dbConnectionString"];
        string evolutionCommonDBConnectionString = ConfigurationManager.AppSettings["evolutionCommonDBConnectionString"];
        string serialNumber = ConfigurationManager.AppSettings["serialNumber"];
        string authCode = ConfigurationManager.AppSettings["authCode"];

        string _conStr;

        public string ConStr
        {
            get
            {
                return _conStr;
            }

            set
            {
                _conStr = value;
            }
        }
        public CommonLibrary(){}
        public CommonLibrary(string conStr)
        { ConStr = conStr;  }

        #region Methods

        public object fillStatusMasterlist(int STATUSID, int TYPEID, string DESC, int USERID, XElement LOGXML = null)
        {
            try
            {
                Xdoc = DBXML.StatusMaster_g(STATUSID, TYPEID, DESC, USERID, LOGXML);
                dt = SqlExe.GetDT(Xdoc);
                var dbResult = (from row in dt.AsEnumerable()
                                select new
                                {
                                    id = row.Field<int>("STATUSID"),
                                    text = row.Field<string>("STATUSCODE")
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
