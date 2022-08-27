using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models.Repositories;
using School.Models;
using NuGet.DependencyResolver;

namespace School.Controllers
{
    public class ClassController : Controller
    {
        private ISchoolRepository<Class> classRepository;

        public ClassController(ISchoolRepository<Class> classRepository)
        {
            this.classRepository = classRepository;
        }




        // GET: ClassController
        public ActionResult Index()
        {
            var classes = classRepository.List();
            return View(classes);
        }

        // GET: ClassController/Details/5
        public ActionResult Details(int id)
        {
            var classes = classRepository.Find(id);
            return View(classes);
        }

        // GET: ClassController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Class classes)
        {
            try
            {
                classRepository.Add(classes);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
