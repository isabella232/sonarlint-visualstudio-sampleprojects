using Microsoft.AspNetCore.Mvc;

namespace WebApplication_NetFx.Controllers
{
    // There are multiple flows in this file with the same source

    public class RSPEC2083IOInjectionNoncompliantController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // Simple taint issue - just involves this method
        public ActionResult DeleteFile(string fileName)
        {
            System.IO.File.Delete(fileName); // Noncompliant

            return Content("File " + fileName + " deleted");
        }

        // Flow 1
        public ActionResult DeleteAnotherFile(string fileName)
        {
            IntermediateMethod(fileName);

            return Content("1. File " + fileName + " deleted");
        }

        // Flow 2
        public ActionResult DeleteAnotherFile2(string fileName)
        {
            IntermediateMethod(fileName);

            return Content("2. File " + fileName + " deleted");
        }

        // Flow 3
        public ActionResult DeleteAnotherFile3(string fileName)
        {
            IntermediateMethod(fileName);

            return Content("3. File " + fileName + " deleted");
        }

        private void IntermediateMethod(string fileName)
        {
            InternalDeleteFile(fileName);
        }

        private void InternalDeleteFile(string fileName)
        {
            System.IO.File.Delete(fileName); // Noncompliant
        }
    }
}