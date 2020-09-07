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

        static public XDocument bookAppointment_C(string flag, int mid, string bookingNo, string perBookingNo, string custCode, string custName, string docCode,
            string docName, string petCode, DateTime bookDateTime, string duration, string rerequestedService, string bookingStatus,
            int branchId, int userId, XElement TRANSXML, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("mId", mid),
           new XAttribute("bookingNo", bookingNo),
           new XAttribute("perBookingNo", perBookingNo),
           new XAttribute("custCode", custCode),
           new XAttribute("custName", custName),
           new XAttribute("docCode", docCode),
           new XAttribute("docName", docName),
           new XAttribute("petCode", petCode),
           new XAttribute("bookDateTime", bookDateTime),
           new XAttribute("duration", duration),
           new XAttribute("requestedService", rerequestedService),
           new XAttribute("bookingStatus", bookingStatus),
           new XAttribute("branchId", branchId),
           new XAttribute("userId", userId)
           ));
            MAINXML.Add(TRANSXML);
            XDocument CreateXml = CommonXML("bookAppointment_C", MAINXML, LOGXML);
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
            string SecondaryEmailID, bool ISACTIVE, bool ISADMIN, XElement LOGXML)
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
           new XAttribute("ISADMIN", ISADMIN)
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
        
        #endregion

    }

}
