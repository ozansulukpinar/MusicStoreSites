﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSites.UI.MVC.CustomFilter
{
    public class CustomFilterAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //kullanıcı girişi varken nasıl davranacağını belirtiriz
            if (HttpContext.Current.Session["kullanici"] != null)
            {
                return true;
            }
            return false;
        }

       
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //kullanıcı girişi yokken nasıl davranacağını belirtiriz
            filterContext.Result = new RedirectResult("/Account/Login");
        }



    }
}