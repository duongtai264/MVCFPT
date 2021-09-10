using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFPT.Models;
namespace MVCFPT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UseModel(StudentInfo model)
        {
            
            return View();
        }
        public ActionResult SaveStudent(StudentInfo model)
        {
            String path = Server.MapPath("~/StudentInfo.txt");
            String[] lines = {model.Id, model.Name, model.Marks };
            System.IO.File.WriteAllLines(path, lines);
            ViewBag.Save = "Lưu thành công á";
            return View();
        }
        public ActionResult Open()
        {
            String path = Server.MapPath("~/StudentInfo.txt");
            String[] lines = System.IO.File.ReadAllLines(path);
            ViewBag.Id = lines[0];
            ViewBag.Name = lines[1];
            ViewBag.Marks = lines[2];
            ViewBag.Open = "Mở thành công á";
            return View();
        }
    }
}