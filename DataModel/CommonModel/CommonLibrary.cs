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
         
        public object FillCONTROLNO(int CONTROLENO, string DESC, int Flag, XElement LOGXML = null)
        { 
            Xdoc = DBXML.ST_SYSCONTROLENO_h(CONTROLENO, DESC, Flag, LOGXML);
            dt = SqlExev2.GetDT(Xdoc, ConStr);
            var dbResult = (from row in dt.AsEnumerable()
                            select new
                            {
                                id = row.Field<int>("idYear"),
                                STARTDATE = row.Field<DateTime>("STARTDATE"), 
                                text = row.Field<string>("cYearDescription")
                            }).ToList();
            return dbResult;
        }

        public object fillPetList(string name, string code, string custCode, int branchId, XElement LOGXML = null)
        {
            try
            {
                Xdoc = DBXML.petMaster_g(1,0, name, code, custCode, branchId, 0, LOGXML);
                dt = SqlExe.GetDT(Xdoc);
                var dbResult = (from row in dt.AsEnumerable()
                                select new
                                {
                                    id = row.Field<string>("code"), 
                                    text = row.Field<string>("code")
                                }).ToList();
                return dbResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object fillSpeciesList(int id, string desc, XElement LOGXML = null)
        {
            try
            {
                Xdoc = DBXML.Species_g(0,id,desc, 0, LOGXML);
                dt = SqlExe.GetDT(Xdoc);
                var dbResult = (from row in dt.AsEnumerable()
                                select new
                                {
                                    id = row.Field<string>("Species"),
                                    text = row.Field<string>("Species"),
                                    EXTID = row.Field<Int32>("Id")
                                }).ToList();
                return dbResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object fillBreedList(int id,int rid, string desc, XElement LOGXML = null)
        {
            try
            {
                Xdoc = DBXML.Breed_g(0, id,rid, desc, 0, LOGXML);
                dt = SqlExe.GetDT(Xdoc);
                var dbResult = (from row in dt.AsEnumerable()
                                select new
                                {
                                    id = row.Field<string>("BreedName"),
                                    text = row.Field<string>("BreedName")
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
