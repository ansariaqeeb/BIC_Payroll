using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataModel
{
    static public class DBXML
    {
        //Xml for login and user authentication
        static public XDocument userAuthentication_g(int flag, string loginId, string password, int controlNo, int posId, int orgStructId, string compName, string compUser, string compIpAdress, string browserName, string browServer, string ips, string isDomainValid, string email)
        {
            //USERAUTHENTICATION_g    
            XElement logXml = loginXml(compName, compUser, compIpAdress, browserName, browServer, ips, isDomainValid, email);

            XElement MAINXML = new XElement("SPXML",
               new XElement("SPDETAILS",
               new XAttribute("flag", flag),
               new XAttribute("loginId", loginId),
               new XAttribute("password", password),
               new XAttribute("controlNo", controlNo),
               new XAttribute("posId", posId),
               new XAttribute("orgStructId", orgStructId)
               ));
            XDocument CreateXml = CommonXML("userAuthentication_g", MAINXML, logXml);
            return CreateXml;
        }
        /// <summary>
        /// Common xml function for all sp should be call in all functions
        /// </summary>
        /// <param name="spName">Store procedure Name</param>
        /// <param name="spDetails">Store Procedure required parameters</param>
        /// <param name="logInfo">log xml for user details</param>
        /// <returns></returns>
        static XDocument CommonXML(string spName, XElement spDetails, XElement logInfo)
        {
            XElement createXml = new XElement("XMLFILE");
            createXml.Add(spDetails);
            createXml.Add(logInfo);

            XDocument retXml = new XDocument(
              new XDeclaration("1.0", "utf-8", ""),
              new XElement("BIC",
              new XElement("procName", spName),
              new XElement("pXMLFILE", Convert.ToString(createXml)),
              new XElement("pERRORXML", "")
               ));
            return retXml;
        }
        /// <summary>
        /// Xml for maintaning user log information 
        /// </summary>
        /// <param name="compName">User computer name</param>
        /// <param name="compUser">User name on that computer</param>
        /// <param name="compIpAddress">computer ip address</param>
        /// <param name="browserName">browser name</param>
        /// <param name="browServer">browser server</param>
        /// <param name="ips"></param>
        /// <param name="isDomainValid">valid domain or not</param>
        /// <param name="email">email</param>
        /// <param name="userId">user id</param>
        /// <returns></returns>
        static public XElement loginXml(string compName, string compUser, string compIpAddress, string browserName, string browServer, string ips, string isDomainValid, string email, int userId = 0)
        {
            XElement createXml = new XElement("loginLog");
            createXml.SetAttributeValue("compName", compName);
            createXml.SetAttributeValue("compUser", compUser);
            createXml.SetAttributeValue("compIpAddress", compIpAddress);
            createXml.SetAttributeValue("browserName", browserName);
            createXml.SetAttributeValue("browServer", browServer);
            createXml.SetAttributeValue("ips", ips);
            createXml.SetAttributeValue("isDomainValid", isDomainValid == null ? "" : isDomainValid);
            createXml.SetAttributeValue("email", email == null ? "" : email);
            createXml.SetAttributeValue("userId", userId);
            return createXml;
        }

        #region C section

        static public XDocument COMPANY_c(string FLAG, int COMPID, string COMPCODE, string COMPNAME, string ADDR1COMPLEXNAME, string ADDR1STREETNO, 
            string ADDR1STREETNAME, string ADDR1POSTALCODE, string ADDR1COUNTRYNAME, string ADDR1STATENAME, string ADDR1CITYNAME, bool ADDR2SAMEASADDR1,
            string ADDR2COMPLEXNAME, string ADDR2STREETNO, string ADDR2STREETNAME, string ADDR2POSTALCODE, string ADDR2COUNTRYNAME, string ADDR2STATENAME,
            string ADDR2CITYNAME, string PRIMARYPHONE, string SECONDARYPHONE, string FAX, string EMAILID, string WEBSITE,DateTime ESTABLISHEDIN,
            int MANPOWERWORKING,string REGNO,bool ISACTIVE, int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("COMPID", COMPID),
           new XAttribute("COMPCODE", COMPCODE),
           new XAttribute("COMPNAME", COMPNAME),
           new XAttribute("ADDR1COMPLEXNAME", ADDR1COMPLEXNAME),
           new XAttribute("ADDR1STREETNO", ADDR1STREETNO),
           new XAttribute("ADDR1STREETNAME", ADDR1STREETNAME),
           new XAttribute("ADDR1POSTALCODE", ADDR1POSTALCODE),
           new XAttribute("ADDR1COUNTRYNAME", ADDR1COUNTRYNAME),
           new XAttribute("ADDR1STATENAME", ADDR1STATENAME),
           new XAttribute("ADDR1CITYNAME", ADDR1CITYNAME),
           new XAttribute("ADDR2SAMEASADDR1", ADDR2SAMEASADDR1),
           new XAttribute("ADDR2COMPLEXNAME", ADDR2COMPLEXNAME),
           new XAttribute("ADDR2STREETNO", ADDR2STREETNO),
           new XAttribute("ADDR2STREETNAME", ADDR2STREETNAME),
           new XAttribute("ADDR2POSTALCODE", ADDR2POSTALCODE),
           new XAttribute("ADDR2COUNTRYNAME", ADDR2COUNTRYNAME),
           new XAttribute("ADDR2STATENAME", ADDR2STATENAME),
           new XAttribute("ADDR2CITYNAME", ADDR2CITYNAME),
           new XAttribute("PRIMARYPHONE", PRIMARYPHONE),
           new XAttribute("SECONDARYPHONE", SECONDARYPHONE),
           new XAttribute("FAX", FAX),
           new XAttribute("EMAILID", EMAILID),
           new XAttribute("WEBSITE", WEBSITE),
           new XAttribute("ESTABLISHEDIN", ESTABLISHEDIN),
           new XAttribute("REGNO", REGNO),
           new XAttribute("ISACTIVE", ISACTIVE),
           new XAttribute("USERID", USERID)  
           )); 
            XDocument CreateXml = CommonXML("COMPANY_c", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument EMPLOYEE_c(string FLAG,int EMPID,string EMPCODE, string TITLE ,string FIRSTNAME,string MIDDLENAME ,string LASTNAME,string NICKNAME,
                    DateTime STARTDATE, DateTime DOB,string NATIONALID,string PASSPORTNO,string COUNTRYOFISSUE ,string GENDER,string MARITALSTATUS,string DEPENDENT,
                    string YEARSOFSERVICE,string ADDR1COMPLEXNAME,string ADDR1STREETNO ,string ADDR1STREETNAME,string ADDR1POSTALCODE,string ADDR1COUNTRYNAME ,
                    string ADDR1STATENAME,string ADDR1CITYNAME,bool ADDR2SAMEASADDR1,string ADDR2COMPLEXNAME,string ADDR2STREETNO ,string ADDR2STREETNAME,
                    string ADDR2POSTALCODE ,string ADDR2COUNTRYNAME,string ADDR2STATENAME ,string ADDR2CITYNAME ,string WORKPHONE ,string HOMEPHONE,string CELLNO ,
                    string FAXNO ,string SPOUSENAME ,string SPOUSENO,string EMAILID, decimal DAILYRATE,decimal WEEKLYRATE,decimal MONTHLYRATE,decimal HOURLYRATE,
                    decimal PREVIUSYEARLYPAY,DateTime LASTINCREAMENTDATE,DateTime TERMINATIONDATE,decimal AVGHOURPERDAY, decimal HOURPERWEEK,decimal DAYSPERMONTH,
                    string WEEKDAYS,decimal ANNUALSTANDARDLEAVE, decimal ANNUALSICKLEAVE,decimal ANNUALOPTIONALLEAVE,int COMPID,bool ISACTIVE,int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("EMPID", EMPID),
           new XAttribute("EMPCODE", EMPCODE),
           new XAttribute("TITLE", TITLE),
           new XAttribute("FIRSTNAME", FIRSTNAME),
           new XAttribute("MIDDLENAME", MIDDLENAME),
           new XAttribute("MIDDLENAME", MIDDLENAME),
           new XAttribute("LASTNAME", LASTNAME),
           new XAttribute("NICKNAME", NICKNAME),
           new XAttribute("STARTDATE", STARTDATE),
           new XAttribute("DOB", DOB),
           new XAttribute("NATIONALID", NATIONALID),
           new XAttribute("PASSPORTNO", PASSPORTNO),
           new XAttribute("COUNTRYOFISSUE", COUNTRYOFISSUE),
           new XAttribute("GENDER", GENDER),
           new XAttribute("MARITALSTATUS", MARITALSTATUS),
           new XAttribute("DEPENDENT", DEPENDENT),
           new XAttribute("YEARSOFSERVICE", YEARSOFSERVICE),
           new XAttribute("ADDR1COMPLEXNAME", ADDR1COMPLEXNAME),
           new XAttribute("ADDR1STREETNO", ADDR1STREETNO),
           new XAttribute("ADDR1STREETNAME", ADDR1STREETNAME),
           new XAttribute("ADDR1POSTALCODE", ADDR1POSTALCODE),
           new XAttribute("ADDR1COUNTRYNAME", ADDR1COUNTRYNAME),
           new XAttribute("ADDR1STATENAME", ADDR1STATENAME),
           new XAttribute("ADDR1CITYNAME", ADDR1CITYNAME),
           new XAttribute("ADDR2SAMEASADDR1", ADDR2SAMEASADDR1),
           new XAttribute("ADDR2COMPLEXNAME", ADDR2COMPLEXNAME),
           new XAttribute("ADDR2STREETNO", ADDR2STREETNO),
           new XAttribute("ADDR2STREETNAME", ADDR2STREETNAME),
           new XAttribute("ADDR2POSTALCODE", ADDR2POSTALCODE),
           new XAttribute("ADDR2STATENAME", ADDR2STATENAME),
           new XAttribute("ADDR2CITYNAME", ADDR2CITYNAME),
           new XAttribute("WORKPHONE", WORKPHONE),
           new XAttribute("HOMEPHONE", HOMEPHONE),
           new XAttribute("CELLNO", CELLNO),
           new XAttribute("FAXNO", FAXNO),

           new XAttribute("SPOUSENAME", SPOUSENAME),
           new XAttribute("SPOUSENO", SPOUSENO),
           new XAttribute("EMAILID", EMAILID),
           new XAttribute("DAILYRATE", DAILYRATE),
           new XAttribute("WEEKLYRATE", WEEKLYRATE),
           new XAttribute("MONTHLYRATE", MONTHLYRATE),
           new XAttribute("HOURLYRATE", HOURLYRATE),
           new XAttribute("PREVIUSYEARLYPAY", PREVIUSYEARLYPAY),
           new XAttribute("LASTINCREAMENTDATE", LASTINCREAMENTDATE),
           new XAttribute("TERMINATIONDATE", TERMINATIONDATE),
           new XAttribute("AVGHOURPERDAY", AVGHOURPERDAY),
           new XAttribute("HOURPERWEEK", HOURPERWEEK),
           new XAttribute("DAYSPERMONTH", DAYSPERMONTH),
           new XAttribute("WEEKDAYS", WEEKDAYS),
           new XAttribute("ANNUALSTANDARDLEAVE", ANNUALSTANDARDLEAVE),
           new XAttribute("ANNUALSICKLEAVE", ANNUALSICKLEAVE),
           new XAttribute("ANNUALOPTIONALLEAVE", ANNUALOPTIONALLEAVE),
           new XAttribute("COMPID", COMPID),
           new XAttribute("ISACTIVE", ISACTIVE),
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("EMPLOYEE_c", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument COUNTRYMAST_c(string FLAG, int COUNTRYID, string COUNTRYCODE, string SHORTNAME, string COUNTRYNAME,bool ISACTIVE, int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("COUNTRYID", COUNTRYID),
           new XAttribute("COUNTRYCODE", COUNTRYCODE),
           new XAttribute("SHORTNAME", SHORTNAME),
           new XAttribute("COUNTRYNAME", COUNTRYNAME), 
           new XAttribute("ISACTIVE", ISACTIVE),
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("COUNTRYMAST_c", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument STATEMAST_c(string FLAG, int STATEID, string STATECODE, string SHORTNAME, string STATENAME,int COUNTRYID, bool ISACTIVE, int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("STATEID", STATEID),
           new XAttribute("COUNTRYID", COUNTRYID),
           new XAttribute("STATECODE", STATECODE),
           new XAttribute("SHORTNAME", SHORTNAME),
           new XAttribute("STATENAME", STATENAME),
           new XAttribute("ISACTIVE", ISACTIVE),
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("STATEMAST_c", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument FilesMaster_c(string flag, int Id, int RMid, string NameFile, string DisplayName,string contentType, string Extension, string FileSize, int userId)
        {
            XElement MAINXML = new XElement("SPXML",
                   new XElement("SPDETAILS",
                   new XAttribute("flag", flag),
                   new XAttribute("Id", Id),
                   new XAttribute("RMid", RMid),
                   new XAttribute("NameFile", NameFile),
                   new XAttribute("DisplayName", DisplayName),
                   new XAttribute("contentType", contentType),
                   new XAttribute("Extension", Extension),
                   new XAttribute("FileSize", FileSize),
                   new XAttribute("userId", userId)
                   ));
            XElement CreateXml = new XElement("XMLFILE");
            CreateXml.Add(MAINXML);

            XDocument RetXml = new XDocument(
              new XDeclaration("1.0", "utf-8", ""),
              new XElement("BIC",
              new XElement("XsdName", ""),
              new XElement("procName", "FilesMaster_c"),
              new XElement("pXMLFILE", Convert.ToString(CreateXml)),
              new XElement("pERRORXML", ""),
              new XElement("pFILESDATA", "")
               ));
            return RetXml;
        }

        static public XDocument DiagnosisFiles_c(string flag, int Rid,int RTid,int RMid,int ItemId, string NameFile, string DisplayName, string contentType, string Extension, string FileSize, int userId)
        {
            XElement MAINXML = new XElement("SPXML",
                   new XElement("SPDETAILS",
                   new XAttribute("flag", flag),
                   new XAttribute("Rid", Rid),
                   new XAttribute("RTid", RTid),
                   new XAttribute("RMid", RMid),
                   new XAttribute("NameFile", NameFile),
                   new XAttribute("DisplayName", DisplayName),
                   new XAttribute("contentType", contentType),
                   new XAttribute("Extension", Extension),
                   new XAttribute("FileSize", FileSize),
                   new XAttribute("userId", userId)
                   ));
            XElement CreateXml = new XElement("XMLFILE");
            CreateXml.Add(MAINXML);

            XDocument RetXml = new XDocument(
              new XDeclaration("1.0", "utf-8", ""),
              new XElement("BIC",
              new XElement("XsdName", ""),
              new XElement("procName", "DiagnosisFiles_c"),
              new XElement("pXMLFILE", Convert.ToString(CreateXml)),
              new XElement("pERRORXML", ""),
              new XElement("pFILESDATA", "")
               ));
            return RetXml;
        }

        static public XDocument LK_AppointmentTrans(int FLAG, int USERID, int PAGENO, XElement FilterXml, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("USERID", USERID),
           new XAttribute("PAGENO", PAGENO)
           ));
            MAINXML.Add(FilterXml);
            XDocument CreateXml = CommonXML("LK_AppointmentTrans", MAINXML, LOGXML);
            return CreateXml;
        }
        static public XDocument LK_Appointment(int FLAG, int MENUID, int MID, int USERID, int PAGENO, XElement FilterXml, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("MENUID", MENUID),
           new XAttribute("MID", MID),
           new XAttribute("USERID", USERID),
           new XAttribute("PAGENO", PAGENO)
           ));
            MAINXML.Add(FilterXml);
            XDocument CreateXml = CommonXML("LK_Appointment", MAINXML, LOGXML);
            return CreateXml;
        }
        

        static public XDocument USERMAST_c(string FLAG, int USERID, string LOGINID, string Email, string MobileNo, bool MobileVerify, 
            bool EmailVerify,string FNAME,string MNAME,string LNAME, DateTime DOB, string ADDRESS, string PASSWORD, string SVRKEY, DateTime SVRDATE, 
            string SecondaryEmailID, bool ISACTIVE, bool ISADMIN,int COUNTRYID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("USERID", USERID),
           new XAttribute("LOGINID", LOGINID),
           new XAttribute("Email", Email),
           new XAttribute("MobileNo", MobileNo),
           new XAttribute("MobileVerify", MobileVerify),
           new XAttribute("EmailVerify", EmailVerify),
           new XAttribute("FNAME", FNAME),
           new XAttribute("MNAME", MNAME),
           new XAttribute("LNAME", LNAME),
           new XAttribute("DOB", DOB),
           new XAttribute("ADDRESS", ADDRESS),
           new XAttribute("PASSWORD", PASSWORD),
           new XAttribute("SVRKEY", SVRKEY),
           new XAttribute("SVRDATE", SVRDATE),
           new XAttribute("SecondaryEmailID", SecondaryEmailID),
           new XAttribute("ISACTIVE", ISACTIVE),
           new XAttribute("ISADMIN", ISADMIN),
           new XAttribute("COUNTRYID", COUNTRYID)
           ));
            XDocument CreateXml = CommonXML("USERMAST_c", MAINXML, LOGXML);
            return CreateXml;
        }

        #endregion


        #region G Saction
        
        static public XDocument STATUSMASTER_h(int TYPEID, int STATUSID, string DESC, int Flag, XElement LOGXML, string CONDITION)
        {
            XElement MAINXML = new XElement("SPXML",
            new XElement("SPDETAILS",
            new XAttribute("TYPEID", TYPEID),
            new XAttribute("FLAG", Flag),
            new XAttribute("STATUSID", STATUSID),
            new XAttribute("CONDITION", CONDITION),
            new XAttribute("DESC", DESC)));
            XDocument CreateXml = CommonXML("STATUSMASTER_h", MAINXML, LOGXML);//NO
            return CreateXml;
        }
        
        static public XDocument USERMAST_g(int FLAG,string LOGINID,string PASSWORD, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG), 
           new XAttribute("LOGINID", LOGINID),
           new XAttribute("PASSWORD", PASSWORD)
           ));
            XDocument CreateXml = CommonXML("USERMAST_g", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument COMPANY_g(int COMPID, string COMPCODE, string COMPNAME,string DESC,int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("COMPID", COMPID),
           new XAttribute("COMPCODE", COMPCODE),
           new XAttribute("COMPNAME", COMPNAME),
           new XAttribute("DESC", DESC),
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("COMPANY_g", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument EMPLOYEE_g(int EMPID, string EMPCODE,int COMPID, string DESC, int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("EMPID", EMPID),
           new XAttribute("EMPCODE", EMPCODE),
           new XAttribute("DESC", DESC),
           new XAttribute("COMPID", COMPID),
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("EMPLOYEE_g", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument COUNTRYMAST_g(int COUNTRYID, string COUNTRYNAME, string COUNTRYCODE, int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("COUNTRYID", COUNTRYID),
           new XAttribute("COUNTRYNAME", COUNTRYNAME),
           new XAttribute("COUNTRYCODE", COUNTRYCODE), 
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("COUNTRYMAST_g", MAINXML, LOGXML);
            return CreateXml;
        }


        static public XDocument STATEMAST_g(int STATEID,int COUNTRYID, string STATEYNAME, string STATECODE, int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("STATEID", STATEID),
           new XAttribute("COUNTRYID", COUNTRYID),
           new XAttribute("STATEYNAME", STATEYNAME),
           new XAttribute("STATECODE", STATECODE),
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("STATEMAST_g", MAINXML, LOGXML);
            return CreateXml;
        }

        #endregion

    }

}
