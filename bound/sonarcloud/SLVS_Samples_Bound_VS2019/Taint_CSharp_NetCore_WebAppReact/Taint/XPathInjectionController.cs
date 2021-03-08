using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml;

namespace WebApplication_NetFx.Controllers
{
    public class RSPEC2091XPathInjectionNoncompliant : Controller
    {
        public XmlDocument doc { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Authenticate(string user, string pass)
        {
            String expression = "/users/user[@name='" + user + "' and @pass='" + pass + "']"; // Unsafe

            // An attacker can bypass authentication by setting user to this special value
            // user = "' or 1=1 or ''='";

            return Content(doc.SelectSingleNode(expression) != null ? "success" : "fail"); // Noncompliant
        }

    }
}