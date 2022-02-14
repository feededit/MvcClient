using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet, Route("~/login")]
        public ActionResult LogIn()
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = "/Id"
            };

            HttpContext.GetOwinContext().Authentication.Challenge(properties,
                OpenIdConnectAuthenticationDefaults.AuthenticationType);

            return new EmptyResult();
        }

        [AcceptVerbs("GET", "POST"), Route("~/logout")]
        public ActionResult LogOut()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(
                CookieAuthenticationDefaults.AuthenticationType,
                OpenIdConnectAuthenticationDefaults.AuthenticationType);

            return new EmptyResult();
        }
    }
}