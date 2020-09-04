using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataModel.Master
{
    public class CompanyMaster
    {
        string dbConnectionString = ConfigurationManager.AppSettings["dbConnectionString"];
       
        #region Properties 
        string _cflag;
        string _serverName;
        string _AuthType;
        string _userName;
        string _PASSWORD;
        string _databaseName;

        int _compId;
        string _compName;

        public int CompId
        {
            get
            {
                return _compId;
            }

            set
            {
                _compId = value;
            }
        }

        public string CompName
        {
            get
            {
                return _compName;
            }

            set
            {
                _compName = value;
            }
        }

        public string ServerName
        {
            get
            {
                return _serverName;
            }

            set
            {
                _serverName = value;
            }
        }

        public string AuthType
        {
            get
            {
                return _AuthType;
            }

            set
            {
                _AuthType = value;
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }

        public string DatabaseName
        {
            get
            {
                return _databaseName;
            }

            set
            {
                _databaseName = value;
            }
        }

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


        public string Cflag
        {
            get
            {
                return _cflag;
            }

            set
            {
                _cflag = value;
            }
        }
        #endregion
    }
}
