using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models.Repositories;
using School.Models;
using NuGet.DependencyResolver;
using School.ViewModel;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        public readonly ISchoolRepository<Student> StudentRepository;
        private readonly ISchoolRepository<Rank> rankRepository;

        public StudentController(ISchoolRepository<Student> StudentRepository, ISchoolRepository<Rank> rankRepository)
        {
            this.StudentRepository = StudentRepository;
            this.rankRepository = rankRepository;

        }




        // GET: StudentController
        public ActionResult Index()
        {
            var students = StudentRepository.List();
            return View(students);
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

            var model = new StudentRankViewModel
            {
                Ranks = rankRepository.List().ToList()
            };


            return View(model);
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentRankViewModel viewmodel)
        {
            try
            {

                var rank = rankRepository.Find(viewmodel.RankId);

                Student student = new Student
                {
                    ID = viewmodel.StudentId,
                    Name = viewmodel.Name,
                    Grade = viewmodel.Grade,
                    Rank = rank

                };



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
            var student = StudentRepository.Find(id);
            var rankId = student.Rank == null ? student.Rank.Id = 0 : student.Rank.Id;

            var viewModel = new StudentRankViewModel
            {
                StudentId = student.ID,
                Name = student.Name,
                Grade = student.Grade,
                RankId = rankId,
                Ranks = rankRepository.List().ToList()
            };
            return View(viewModel);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( StudentRankViewModel viewModel)
        {
            try
            {
                var rank = rankRepository.Find(viewModel.RankId);
                Student student = new Student
                {
                    ID = viewModel.StudentId,
                    Name = viewModel.Name,
                    Grade = viewModel.Grade,
                    Rank = rank
                };

                StudentRepository.Update(viewModel.StudentId, student);
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
            var student = StudentRepository.Find(id);

            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student student)
        {
            try
            {
                StudentRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
