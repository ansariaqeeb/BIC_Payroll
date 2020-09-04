using DataModel.LoginModel;
using Newtonsoft.Json;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Net.Sockets;
using System.Net;
using DataModel.CommonModel;

namespace BIC_Payroll.Controllers
{
    public class AccountController : Controller
    {
        LoginModels objLog = new LoginModels();
        LoginSessionDetails SessLogObj = new LoginSessionDetails();

        public object AddressFamily { get; private set; }

        public ActionResult Index()
        {
            return View();
        }
        //Login page for all users
        public ActionResult Login()
        { 

            object UserSession = Session["SessionInformation"];

            if (UserSession != null && ((LoginSessionDetails)UserSession).UserId != 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
            {
                try
                {
                    Session.RemoveAll();
                    HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                    FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                    LoginSessionDetails serializeModel = JsonConvert.DeserializeObject<LoginSessionDetails>(authTicket.UserData);
                    if (serializeModel.UserId > 0)
                    {
                        Session["SessionInformation"] = serializeModel;
                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (Exception ex)
                {

                }
            }

            //If user chacked remember me check box
            if (this.HttpContext.Request.Cookies["rem_user"] != null)
            {
                var rem = (this.HttpContext.Request.Cookies["RememberMe"].Value).ToString();
                if (rem != "False")
                {
                    var userdecrypt = objLog.Decryptdata(this.HttpContext.Request.Cookies["rem_user"].Value);
                    string[] strTemp = userdecrypt.Split(',');
                    objLog.userName = strTemp[0];
                    objLog.password = strTemp[1];
                    string[] user;
                    if (Request.LogonUserIdentity.Name.Contains("\\"))
                    {
                        user = Request.LogonUserIdentity.Name.Replace("\\\\", "\\").Split('\\');
                    }
                    else
                    {
                        user = new string[2] { "", Request.LogonUserIdentity.Name.Replace("\\\\", "\\").ToString() };

                    }

                    string username = user[1];
                    string mc = Environment.MachineName;
                    string domainName = user[0];
                    string bTyp = Request.Browser.Type;
                    string bVer = Request.Browser.Version;
                    /*GET IP*/
                    string localIP = "";
                    //IPHostEntry host = host = Dns.GetHostEntry(Dns.GetHostName());
                    //foreach (IPAddress ip in host.AddressList)
                    //{
                    //    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    //    {
                    //        localIP = ip.ToString();
                    //        break;
                    //    }
                    //}


                    bool ISDomain = false;
                    string emailaddress = "";
                    string[] aduname = objLog.userName.Split('\\');
                    if (aduname.Length > 1)
                    {
                        var userdata = objLog.ADIsValid(aduname[0], aduname[1], objLog.password);
                        ISDomain = userdata.Item1;
                        emailaddress = userdata.Item2;
                    }
                    string strErrorMsg = "";
                    LoginSessionDetails objLogSession = objLog.getLoginInfo(objLog);

                    //Form setializing user object and encrypting 
                    string userData = JsonConvert.SerializeObject(objLogSession);
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddDays(1), false, userData);
                    string encTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                    faCookie.Expires = authTicket.Expiration;
                    Response.Cookies.Add(faCookie);


                    if (objLogSession.UserId != 0)
                    {
                        Session["SessionInformation"] = objLogSession;
                        string time = DateTime.Now.AddMinutes(1).ToString("mm.ss");
                        Session["ReminderTime"] = time;
                        objLog.RememberMe = true;
                        return RedirectToAction("Index", "Home", new { returnUrl = (this.HttpContext.Request).Path });
                    }
                    //else
                    //{
                    //    ModelState.AddModelError("ErrorMgr", "The user name or password provided is incorrect.");
                    //}
                }
            }
            return View("Login", objLog);
        }

        //Login Post action for getting authenticating user and maintaining its session
        [HttpPost]
        public ActionResult Login(LoginModels objLogin, string returnUrl)
        {

            bool vLicenseExpired = false;

            returnUrl = (returnUrl == "/Account/Login" ? "" : returnUrl);

            Response.Cookies["RememberMe"].Value = objLogin.RememberMe.ToString();
            if (objLogin.RememberMe)
            {
                var userencrypt = string.Join(",", objLogin.userName, objLogin.password, objLogin.RememberMe);
                Response.Cookies["rem_user"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["rem_user"].Value = objLogin.Encryptdata(userencrypt);

                Response.Cookies["RememberMe"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["RememberMe"].Value = objLogin.RememberMe.ToString();
            }
            else
            {
                Response.Cookies["rem_user"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["RememberMe"].Expires = DateTime.Now.AddDays(-1);
            }


            try
            {
                //Validating user for required fields
                if (ModelState.IsValid)
                {
                    string[] user;
                    if (Request.LogonUserIdentity.Name.Contains("\\"))
                    {
                        user = Request.LogonUserIdentity.Name.Replace("\\\\", "\\").Split('\\');
                    }
                    else
                    {
                        user = new string[2] { "", Request.LogonUserIdentity.Name.Replace("\\\\", "\\").ToString() };

                    }

                    string username = user[1];
                    string mc = Environment.MachineName;
                    string domainName = user[0];
                    string bTyp = Request.Browser.Type;
                    string bVer = Request.Browser.Version;
                    /*GET IP*/
                    string localIP = "";
                    //IPHostEntry host = host = Dns.GetHostEntry(Dns.GetHostName());
                    //foreach (IPAddress ip in host.AddressList)
                    //{
                    //    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    //    {
                    //        localIP = ip.ToString();
                    //        break;
                    //    }
                    //}

                    bool ISDomain = false;
                    string emailaddress = "";
                    string[] aduname = objLogin.userName.Split('\\');
                    if (aduname.Length > 1)
                    {
                        var userdata = objLogin.ADIsValid(aduname[0], aduname[1], objLogin.password);
                        ISDomain = userdata.Item1;
                        emailaddress = userdata.Item2;
                    }

                    string strErrorMsg = "";
                    LoginSessionDetails objLogSession = objLog.getLoginInfo(objLogin);

                    //string vEncryptString = "";
                    //vEncryptString = CommonMethods.Encrypt("30 Jul 2016 ", "ERPWEB");


                    //-------------------------------------------------------------------
                    // License Validation
                    //-------------------------------------------------------------------
                    if (objLogSession.UserId != 0)
                    {
                        string vDecryptString = "";
                        vDecryptString = CommonMethods.Decrypt(objLogSession.SVRKEY, "ERPWEB");

                        if (vDecryptString.Trim() == "")
                        {
                            objLogSession.UserId = 0;
                            vLicenseExpired = true;
                        }
                        else if (Convert.ToDateTime(vDecryptString) < objLogSession.SVRDATE)
                        {
                            objLogSession.UserId = 0;
                            vLicenseExpired = true;
                        }
                    }
                    //-------------------------------------------------------------------


                    //Form setializing user object and encrypting 
                    string userData = JsonConvert.SerializeObject(objLogSession);
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddDays(1), false, userData);
                    string encTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                    //faCookie.Expires = authTicket.Expiration; // comment for use as non persistence cookie
                    Response.Cookies.Add(faCookie);

                    if (objLogSession.UserId != 0)
                    {
                        Session["SessionInformation"] = objLogSession;
                        string time = DateTime.Now.AddMinutes(1).ToString("mm.ss");
                        Session["ReminderTime"] = time;
                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {

                            return Redirect(returnUrl);
                        }
                        else
                        {
                            if (System.Configuration.ConfigurationManager.AppSettings["DefaultUrl"] == "")
                            {
                                return RedirectToAction("Index", "Home", new { returnUrl = (this.HttpContext.Request).Path });
                            }
                            else
                            {
                                return Redirect(System.Configuration.ConfigurationManager.AppSettings["DefaultUrl"]);
                            }
                        }
                    }
                    else
                    {
                        if (vLicenseExpired)
                            ModelState.AddModelError("ErrorMgr", "License expired. Please renew your License.");
                        else
                            ModelState.AddModelError("ErrorMgr", strErrorMsg); // "The user name or password provided is incorrect."
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return View(objLogin);
        }

    }
}