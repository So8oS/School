using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Models.Repositories;

namespace School.Controllers
{
    public class TeacherController : Controller
    {
        private ISchoolRepository<Teacher> teacherRepository;

        public TeacherController(ISchoolRepository<Teacher> teacherRepository)
        {
            this.teacherRepository = teacherRepository;

        }




        // GET: TeacherController
        public ActionResult Index()
        {
            var teahcers = teacherRepository.List();
            return View(teahcers);
        }

        // GET: TeacherController/Details/5
        public ActionResult Details(int id)
        {
            var teacher = teacherRepository.Find(id);
            return View(teacher);
        }

        // GET: TeacherController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teacher teacher)
        {
            try
            {
                teacherRepository.Add(teacher);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeacherController/Edit/5
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

        // GET: TeacherController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeacherController/Delete/5
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
