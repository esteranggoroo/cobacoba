using cobacoba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cobacoba.Controllers
{
    [Authorize]
    public class Siswaaa_DBController : Controller
    {
        public ActionResult Index()
        {
            //
            List<Siswaaa_DB> r;
            using (var s = new Siswaaa_DBEntities())
            {
                r = s.Siswaaa_DB.ToList();
            }
            return View(r);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            var model = new Siswaaa_DB();
            TryUpdateModel(model);
            using (var s = new Siswaaa_DBEntities())
            {
                s.Siswaaa_DB.Add(model);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public ActionResult Edit_Get(string nim)
    {
            var model = new Siswaaa_DB();
            TryUpdateModel(model);
            using (var s = new Siswaaa_DBEntities())
            {
                model = s.Siswaaa_DB.Where(x => x.NIM == nim).FirstOrDefault();
            }
            return View(model);
}
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(string nim)
        {
            var model = new Siswaaa_DB();
            TryUpdateModel(model);
            using (var s = new Siswaaa_DBEntities())
            {
                var m = s.Siswaaa_DB.Where(x => x.NIM == nim).FirstOrDefault();
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(string nim)
        {
            var model = new Siswaaa_DB();
            TryValidateModel(model);
            using (var s = new Siswaaa_DBEntities())
            {
                model = s.Siswaaa_DB.FirstOrDefault(x => x.NIM == nim);
            }
            return View(model);
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult Delete_Get(string nim)
        {
            var model = new Siswaaa_DB();
            TryUpdateModel(model);
            using (var s = new Siswaaa_DBEntities())
            {
                model = s.Siswaaa_DB.FirstOrDefault(x => x.NIM == nim);
            }
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(string nim)
        {
            var model = new Siswaaa_DB();
            TryUpdateModel(model);
            using (var s = new Siswaaa_DBEntities())
            {
                var m = s.Siswaaa_DB.Remove(s.Siswaaa_DB.FirstOrDefault(x => x.NIM == nim));
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }