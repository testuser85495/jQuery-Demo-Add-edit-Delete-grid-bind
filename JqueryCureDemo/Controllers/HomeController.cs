using JqueryCureDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryCureDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentDbcontext db;
        public HomeController(ILogger<HomeController> logger, StudentDbcontext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult studataList()
        {
            var data = db.students.ToList();
            return  Json(data);
        }
        [HttpPost]
        public IActionResult Addstu(Student stu)
        {
            //var emp = new Student();
            db.students.Add(stu);
            db.SaveChanges();

            return Json(stu);
        }
        public IActionResult Delete(int studentid)
        {
            var data = db.students.Where(x => x.studentId == studentid).FirstOrDefault();
            db.students.Remove(data);
            db.SaveChanges();

            return Json("data delete") ;
        }
        public IActionResult Edit(int studentid)
        {
            var data = db.students.Where(x => x.studentId == studentid).FirstOrDefault();
            

            return Json(data);
        }
        [HttpPost]
        public IActionResult Update(Student stu)
        {
            db.students.Update(stu);
            db.SaveChanges();
            return Json("record update");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
