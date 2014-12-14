using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Assignment1.Controllers
{
    public class TeachingController : Controller
    {
        //
        // GET: /Teaching/

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase selectedFile)
        {
            if (selectedFile != null && selectedFile.ContentLength > 0)
            {
                var fileName = Path.GetFileName(selectedFile.FileName);
                var filePath = Path.Combine(Server.MapPath("~/UploadedFiles/"),
            fileName);
                selectedFile.SaveAs(filePath);
            }
            return RedirectToAction("Index");
        }

        public FilePathResult DownloadFile(string fileNameWithExtention)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "FileUploads/";
            string fileName = fileNameWithExtention;
            return File(path + fileName, "text/plain", "test.txt");
        }

        public FileStreamResult StreamFile(string fileNameWithExtention)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "FileUploads/";
            string fileName = fileNameWithExtention;
            return File(new FileStream(path + fileName, FileMode.Open), "text/plain", fileName);
        }

        public void DeleteFile(string fileNameWithExtention)
        { 
	        string path = AppDomain.CurrentDomain.BaseDirectory + "FileUploads/"; 
	        if (System.IO.File.Exists(path + fileNameWithExtention)){
                System.IO.File.Delete(path + fileNameWithExtention);
	        }
        }
    }
}
