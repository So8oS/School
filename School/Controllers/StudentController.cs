using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models.Repositories;
using School.Models;
using NuGet.DependencyResolver;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        public ISchoolRepository<Student> StudentRepository;

        public StudentController(ISchoolRepository<Student> StudentRepository)
        {
            this.StudentRepository = StudentRepository;
        }




        // GET: StudentController
        public ActionResult Index()
        {
            var Students = StudentRepository.List();
            return View(Students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var student = StudentRepository.Find(id);
            return View(student);
            
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                StudentRepository.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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
