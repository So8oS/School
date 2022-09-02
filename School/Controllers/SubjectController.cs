using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Models.Repositories;


namespace School.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISchoolRepository<Subject> subjectRepository;

        public SubjectController(ISchoolRepository<Subject> subjectRepository)
        {
            this.subjectRepository = subjectRepository;

        }






        // GET: SubjectController
        public ActionResult Index()
        {
            var subject = subjectRepository.List();
            return View(subject);
            
        }

        // GET: SubjectController/Details/5
        public ActionResult Details(int id)
        {
            var subject = subjectRepository.Find(id);
            return View(subject);
        }

        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Subject subjects)
        {
            try
            {
                subjectRepository.Add(subjects);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Subject subjects)
        {
            try
            {
                subjectRepository.Update(id, subjects);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            var subjects = subjectRepository.Find(id);
            return View();
        }

        // POST: SubjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                subjectRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
