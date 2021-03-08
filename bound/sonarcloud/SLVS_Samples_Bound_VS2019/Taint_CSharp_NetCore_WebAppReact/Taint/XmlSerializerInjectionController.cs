using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Xml.Serialization;

namespace WebApplication_NetFx.Controllers
{
    public class XmlSerializerInjectionController : Controller
    {
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
    }
}