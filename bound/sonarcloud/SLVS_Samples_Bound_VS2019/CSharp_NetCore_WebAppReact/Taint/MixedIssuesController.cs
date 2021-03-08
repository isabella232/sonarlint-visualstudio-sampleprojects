using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WebApplication_NetFx.Controllers
{
    public class MixedIssuesController : Controller
    {
        #region Path injection - S2083

        public ActionResult DeleteFile(string fileName)
        {
            System.IO.File.Delete(fileName); // Noncompliant

            return Content("File " + fileName + " deleted");
        }

        #endregion

        #region XML serialization issue - S5135

        private class ExpectedType { }

        public ActionResult unsecuredeserialization(string typeName)
        {
            // ....
            ExpectedType obj = null;
            Type t = Type.GetType(typeName); // typeName is user-controlled
            XmlSerializer serializer = new XmlSerializer(t); // Noncompliant

            var fs = GetStream();
            obj = (ExpectedType)serializer.Deserialize(fs);
            // ....

            return null;
        }

        private static Stream GetStream()
        {
            return null;
        }

        #endregion

        #region XPath injection - S2091

        public XmlDocument doc { get; set; }

        public ActionResult Authenticate(string user, string pass)
        {
            String expression = "/users/user[@name='" + user + "' and @pass='" + pass + "']"; // Unsafe

            // An attacker can bypass authentication by setting user to this special value
            // user = "' or 1=1 or ''='";

            return Content(doc.SelectSingleNode(expression) != null ? "success" : "fail"); // Noncompliant
        }

        #endregion
    }
}