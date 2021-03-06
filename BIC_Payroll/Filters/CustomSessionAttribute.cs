﻿using DataModel.LoginModel;
using Newtonsoft.Json;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace BIC_Payroll.Filters
{
    public class CustomSessionAttribute : FilterAttribute, IAuthorizationFilter
    {
        void IAuthorizationFilter.OnAuthorization(AuthorizationContext filterContext)
        {
            try
            {
                LoginModels objLog = new LoginModels();
                object UserSession = filterContext.RequestContext.HttpContext.Session["SessionInformation"];

                if (UserSession == null || ((LoginSessionDetails)UserSession).USERID == 0 || ((LoginSessionDetails)UserSession).objComp == null || ((LoginSessionDetails)UserSession).objComp.COMPID == 0)
                {

                    if (HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName] != null)
                    {
                        filterContext.HttpContext.Session.RemoveAll();
                        HttpCookie authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                        FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                        LoginSessionDetails serializeModel = JsonConvert.DeserializeObject<LoginSessionDetails>(authTicket.UserData);
                        if (serializeModel.USERID > 0)
                        {
                            filterContext.HttpContext.Session["SessionInformation"] = serializeModel;
                        }
                        else
                        {
                            UrlHelper h = new UrlHelper(HttpContext.Current.Request.RequestContext);
                            filterContext.Result = new RedirectResult(h.Action("Index", "Home").ToString());
                        }
                    }
                    else
                    {
                        UrlHelper h = new UrlHelper(HttpContext.Current.Request.RequestContext);
                        filterContext.Result = new RedirectResult(h.Action("Login", "Account").ToString());
                    }
                }
                 
            }
            catch (Exception ex)
            {
                UrlHelper h = new UrlHelper(HttpContext.Current.Request.RequestContext);
                filterContext.Result = new RedirectResult(h.Action("Login", "Account").ToString());
            }

        }
    }
}