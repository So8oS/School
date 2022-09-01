using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Models.Repositories;
using School.ViewModel;
using System.Linq;

namespace School.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ISchoolRepository<Teacher> teacherRepository;
        private readonly ISchoolRepository<Rank> rankRepository;

       

        public TeacherController(ISchoolRepository<Teacher> teacherRepository, ISchoolRepository<Rank> rankRepository)
        {
            this.teacherRepository = teacherRepository;
            this.rankRepository = rankRepository;
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
            var model = new RankViewModel
            {
                Ranks = rankRepository.List().ToList()
            };
           
            return View(model);
        }



        // POST: TeacherController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RankViewModel model)
        {
            try
            {
                var rank = rankRepository.Find(model.RankId);
                Teacher teacher = new Teacher
                {
                    ID = model.TeacherId,
                    Name = model.Name,
                    Occupation = model.Occupation,
                    Rank = rank
                    


                };
                teacherRepository.Add(teacher);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }










        // EDDDDDIIIIIIIIIIIIIIIIIITTTTTTTTTTTT 
        // GET: TeacherController/Edit/5
        public ActionResult Edit(int id)
        {

            var teacher = teacherRepository.Find(id);
            var rankId = teacher.Rank == null ? teacher.Rank.Id = 0 : teacher.Rank.Id;

            var viewModel = new RankViewModel
            {
                TeacherId = teacher.ID,
                Name = teacher.Name,
                Occupation = teacher.Occupation,
                RankId = rankId,
                Ranks = rankRepository.List().ToList()
            };



            return View(viewModel);
        }

        // POST: TeacherController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RankViewModel viewModel)
        {
            try
            {
                var rank = rankRepository.Find(viewModel.RankId);
                Teacher teacher = new Teacher
                {
                    ID= viewModel.TeacherId,
                    Name= viewModel.Name,
                    Occupation= viewModel.Occupation,
                    Rank= rank
                };

                teacherRepository.Update(viewModel.TeacherId, teacher);




                // teacherRepository.Update(id, teacher);  
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
            var teacher = teacherRepository.Find(id);

            return View();
        }

        // POST: TeacherController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Teacher teacher)
        {
            try
            {
                teacherRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
