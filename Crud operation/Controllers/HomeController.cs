using Crud_operation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Web.Services.Description;

namespace Crud_operation.Controllers
{
    public class HomeController : Controller
    {
     
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student a) 
        {
            if (ModelState.IsValid == true)
            {
                db.students.Add(a);
                int b=  db.SaveChanges();
               if (b > 0) 
                {
                    //ViewBag.Message = ("<script>alert('Data Save Successfully')</script>");
                    // TempData["Message"] = ("<script>alert('Data Save Successfully')</script>");
                    TempData["Message"] = "Data Save Successfully...";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    //ViewBag.Message = ("<script>alert('Data save not successfully')</script>");
                    TempData["Message"] = ("<script>alert('Data Save Successfully')</script>");
                }
            }
            return View(a);
        }

        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }


        public ActionResult Edit(int id)
        {
            var o = db.students.Where(model => model.Id == id).FirstOrDefault();
            return View(o);
        }

        [HttpPost]
        public ActionResult Edit(Student e) 
        {
            db.Entry(e).State = EntityState.Modified;
            int b = db.SaveChanges();
            if(b > 0)
            {
                ViewBag.Message = ("<script>alert('Data update Successfully')</script>");
            }
            else
            {
                ViewBag.Message = ("<script>alert('Data not update successfully')</script>");
            }
            return View(e);
        }

        public ActionResult Delete(int id) 
        {
            var o = db.students.Where(model => model.Id == id).FirstOrDefault();
            return View(o);
        }

        [HttpPost]
        public ActionResult Delete(Student e)
        {
            db.Entry(e).State = EntityState.Deleted;
            int b = db.SaveChanges();
            if(b > 0)
            {
                ViewBag.deleteMessage = ("<script>alert('Data delete Successfully')</script>");
            }
            else
            {
                ViewBag.deleteMessage = ("<script>alert('Data delete Successfully')</script>");
            }
            return View(e);
        }
    }
}
