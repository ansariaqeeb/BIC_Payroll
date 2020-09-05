﻿using System;
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

        static public XDocument bookAppointmentBill_C(string flag, int mid, int branchId, int userId, XElement TRANSXML, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("mId", mid),
           new XAttribute("branchId", branchId),
           new XAttribute("userId", userId)
           ));
            MAINXML.Add(TRANSXML);
            XDocument CreateXml = CommonXML("bookAppointmentBill_C", MAINXML, LOGXML);
            return CreateXml;
        }
        static public XDocument TransferDetails_C(string flag, int mid, string fromCustCode, string fromCustName, string toCustCode, string toCustName, string petCode, string remark, int branchId, int userId, XElement TRANSXML, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("mId", mid),
           new XAttribute("fromCustCode", fromCustCode),
           new XAttribute("fromCustName", fromCustName),
           new XAttribute("toCustCode", toCustCode),
           new XAttribute("toCustName", toCustName),
           new XAttribute("petCode", petCode),
           new XAttribute("remark", remark),
           new XAttribute("branchId", branchId),
           new XAttribute("userId", userId)
           ));
            MAINXML.Add(TRANSXML);
            XDocument CreateXml = CommonXML("TransferDetails_C", MAINXML, LOGXML);
            return CreateXml;
        }
        static public XDocument bookAppointmentTrans_C(string flag, int tid, string observation, string diagnosis, int branchId, int userId, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("Tid", tid),
           new XAttribute("observation", observation),
           new XAttribute("diagnosis", diagnosis),
           new XAttribute("branchId", branchId),
           new XAttribute("userId", userId)
           ));
            XDocument CreateXml = CommonXML("bookAppointmentTrans_C", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument TreatmentKitTrans_C(string flag, int RTid, int Rid, string serviceItemId, string serviceItem, string serviceItemDesc, string uomDesc, decimal qty, string remark, bool isActive, int branchId, int userId, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("Rid", Rid),
           new XAttribute("RTid", RTid),
           new XAttribute("serviceItemId", serviceItemId),
           new XAttribute("serviceItem", serviceItem),
           new XAttribute("serviceItemDesc", serviceItemDesc),
           new XAttribute("uomDesc", uomDesc),
           new XAttribute("qty", qty),
           new XAttribute("remark", remark),
           new XAttribute("isActive", isActive),
           new XAttribute("userId", userId)
           ));
            XDocument CreateXml = CommonXML("TreatmentKitTrans_C", MAINXML, LOGXML);
            return CreateXml;
        }
        static public XDocument TreatmentKit_C(string flag, int tid, string code, string desciption, bool isActive, int branchId, int userId, XElement TRANSXML, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("Tid", tid),
           new XAttribute("Code", code),
           new XAttribute("Description", desciption),
           new XAttribute("branchId", branchId),
           new XAttribute("isActive", isActive),
           new XAttribute("userId", userId)
           ));
            MAINXML.Add(TRANSXML);
            XDocument CreateXml = CommonXML("TreatmentKit_C", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument treatmentServiceFromKit_C(string flag, int RTid, int RMid, string serviceItem, int userId, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("RTid", RTid),
           new XAttribute("RMid", RMid),
           new XAttribute("serviceItem", serviceItem),
           new XAttribute("userId", userId)
           ));

            XDocument CreateXml = CommonXML("treatmentServiceFromKit_C", MAINXML, LOGXML);
            return CreateXml;
        }
        static public XDocument treatmentService_C(string flag, int Rid, int RTid, int RMid, int serviceItemId, string serviceItem, string serviceItemDesc, string uomDesc, decimal qty
            , decimal rate, decimal tax, string taxCode, decimal amount, decimal taxAmount, decimal exclusiveAmount, decimal inclusiveAmount, string remark, bool isActive,
            int userId, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("Rid", Rid),
           new XAttribute("RTid", RTid),
           new XAttribute("RMid", RMid),
           new XAttribute("serviceItemId", serviceItemId),
           new XAttribute("serviceItem", serviceItem),
           new XAttribute("serviceItemDesc", serviceItemDesc),
           new XAttribute("uomDesc", uomDesc),
           new XAttribute("qty", qty),
           new XAttribute("rate", rate),
           new XAttribute("tax", tax),
           new XAttribute("taxCode", taxCode),
           new XAttribute("amount", amount),
           new XAttribute("taxAmount", taxAmount),
           new XAttribute("exclusiveAmount", exclusiveAmount),
           new XAttribute("inclusiveAmount", inclusiveAmount),
           new XAttribute("remark", remark),
           new XAttribute("isActive", isActive),
           new XAttribute("userId", userId)
           ));

            XDocument CreateXml = CommonXML("treatmentService_C", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument DiagnosisDtl_C(string flag, int Rid, int RTid, int RMid, int ItemId, string ItemCode, string ItemDesc, 
            string diagnosisRemark,string diagnosticRemark, bool isActive,int userId, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("Rid", Rid),
           new XAttribute("RTid", RTid),
           new XAttribute("RMid", RMid),
           new XAttribute("ItemId", ItemId),
           new XAttribute("ItemCode", ItemCode),
           new XAttribute("ItemDesc", ItemDesc),
           new XAttribute("diagnosisRemark", diagnosisRemark),
           new XAttribute("diagnosticRemark", diagnosticRemark),
           new XAttribute("isActive", isActive),
           new XAttribute("userId", userId)
           ));

            XDocument CreateXml = CommonXML("DiagnosisDtl_C", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument PrescriptionService_C(string flag, int Pid, int RTid, int RMid, string prescriptionItem, string prescriptionDesc, string uomDesc,
            decimal totalQty, decimal noOfDays, string morBeforeQty, string morAfterQty, string noonBeforeQty, string noonAfterQty, string nightBeforeQty,
            string nightAfterQty, string remark, bool isActive, int userId, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("Pid", Pid),
           new XAttribute("RTid", RTid),
           new XAttribute("RMid", RMid),
           new XAttribute("prescriptionItem", prescriptionItem),
           new XAttribute("prescriptionDesc", prescriptionDesc),
           new XAttribute("uomDesc", uomDesc),
           new XAttribute("totalQty", totalQty),
           new XAttribute("noOfDays", noOfDays),
           new XAttribute("morBeforeQty", morBeforeQty),
           new XAttribute("morAfterQty", morAfterQty),
           new XAttribute("noonBeforeQty", noonBeforeQty),
           new XAttribute("noonAfterQty", noonAfterQty),
           new XAttribute("nightBeforeQty", nightBeforeQty),
           new XAttribute("nightAfterQty", nightAfterQty),
           new XAttribute("remark", remark),
           new XAttribute("isActive", isActive),
           new XAttribute("userId", userId)
           ));

            XDocument CreateXml = CommonXML("PrescriptionService_C", MAINXML, LOGXML);
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
        static public XDocument LK_AppointmentHistory(int FLAG, int MENUID, int MID, int USERID, int PAGENO, XElement FilterXml, XElement LOGXML)
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
            XDocument CreateXml = CommonXML("LK_AppointmentHistory", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument LK_Transfer(int FLAG, int MENUID, int MID, int USERID, int PAGENO, XElement FilterXml, XElement LOGXML)
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
            XDocument CreateXml = CommonXML("LK_Transfer", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument dbConfig_C(string flag, int dbConfigId, string dbName, string sqlDBAuthType, string dbServerName, string dbUserId, string dbPassword,
            string dbDatabaseName,string sqlDBCommAuthType, string dbCommServerName, string dbCommDatabaseName, string dbCommUserId, string dbCommPassword, 
            string serialNumber, string authCode, bool isActive,string adminGroup,string receptionistGroup,string doctorGroup,string cashierGroup,string InvcPrefix,
            string treatmentItemCriterea,string diagnosticItemCriterea,int USERID, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("flag", flag),
           new XAttribute("dbConfigId", dbConfigId),
           new XAttribute("dbName", dbName ?? ""),
           new XAttribute("dbServerName", dbServerName ?? ""),
           new XAttribute("sqlDBAuthType", sqlDBAuthType ?? ""),
           new XAttribute("dbUserId", dbUserId ?? ""),
           new XAttribute("dbPassword", dbPassword ?? ""),
           new XAttribute("dbDatabaseName", dbDatabaseName ?? ""),
           new XAttribute("dbCommServerName", dbCommServerName ?? ""),
           new XAttribute("sqlDBCommAuthType", sqlDBCommAuthType ?? ""),
           new XAttribute("dbCommDatabaseName", dbCommDatabaseName ?? ""),
           new XAttribute("dbCommUserId", dbCommUserId ?? ""),
           new XAttribute("dbCommPassword", dbCommPassword ?? ""),
           new XAttribute("serialNumber", serialNumber ?? ""),
           new XAttribute("authCode", authCode ?? ""),
           new XAttribute("isActive", isActive),
           new XAttribute("adminGroup", adminGroup ?? ""),
           new XAttribute("receptionistGroup", receptionistGroup ?? ""),
           new XAttribute("doctorGroup", doctorGroup ?? ""),
           new XAttribute("cashierGroup", cashierGroup ?? ""),
           new XAttribute("InvcPrefix", InvcPrefix ?? ""),
           new XAttribute("treatmentItemCriterea", treatmentItemCriterea ?? ""),
           new XAttribute("diagnosticItemCriterea", diagnosticItemCriterea ?? ""),
           new XAttribute("USERID", USERID)
           ));
            XDocument CreateXml = CommonXML("dbConfig_C", MAINXML, LOGXML);
            return CreateXml;
        }

        static public XDocument userMaster_C(string FLAG, int USERID, string LOGINID, string Email, string MobileNo, bool MobileVerify, 
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
            XDocument CreateXml = CommonXML("userMaster_C", MAINXML, LOGXML);
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
        
        static public XDocument UserMaster_g(int FLAG, int USERID, string LOGINID,string DESC, XElement LOGXML)
        {
            XElement MAINXML = new XElement("SPXML",
           new XElement("SPDETAILS",
           new XAttribute("FLAG", FLAG),
           new XAttribute("USERID", USERID),
           new XAttribute("LOGINID", LOGINID),
           new XAttribute("DESC", DESC)
           ));
            XDocument CreateXml = CommonXML("UserMaster_g", MAINXML, LOGXML);
            return CreateXml;
        }
        
        #endregion

    }

}
