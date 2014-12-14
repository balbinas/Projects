using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class AssessmentController : Controller
    {
        //
        // GET: /Assessment/

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
        public ActionResult DownloadFile(string fileName)
        {
            Response.ContentType = "APPLICATION/OCTET-STREAM";
            string Header = "Attachment; Filename=" + fileName;
            Response.AppendHeader("Content-Disposition", Header);
            string filePath = Path.Combine(Server.MapPath("~/UploadedFiles/"), fileName);
            Response.WriteFile(filePath);
            Response.End();

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
    }
}
