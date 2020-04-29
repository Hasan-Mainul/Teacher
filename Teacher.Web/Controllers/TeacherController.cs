using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teacher.Data.Models;
using Teacher.Data.Services;

namespace Teacher.Web.Controllers
{

    public class TeacherController : Controller
    {
        private readonly ITeacherData db;
        public TeacherController(ITeacherData db)
        {
            this.db = db;
        }
        // GET: Teacher
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeacherInfo teacherInfo)
        {
            if (ModelState.IsValid)
            {
                db.Add(teacherInfo);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TeacherInfo teacherInfo)
        {
            if (ModelState.IsValid)
            {
                db.Update(teacherInfo);
                return RedirectToAction("Index", new { id = teacherInfo.Id });
            }
            return View(teacherInfo);

        }
    }
}