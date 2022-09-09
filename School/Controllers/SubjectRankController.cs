using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models.Repositories;
using School.Models;
using System.Linq;
using School.ViewModel;
using NuGet.DependencyResolver;

namespace School.Controllers
{
    public class SubjectRankController : Controller
    {
        private readonly ISchoolRepository<SubjectRank> subjectRankRepository;
        private readonly ISchoolRepository<Subject> subjectRepository;
        private readonly ISchoolRepository<Rank> rankRepository;

        public SubjectRankController(ISchoolRepository<SubjectRank> subjectRankRepository, ISchoolRepository<Subject> subjectRepository, ISchoolRepository<Rank> rankRepository)
        {
            this.subjectRankRepository = subjectRankRepository;
            this.subjectRepository = subjectRepository;
            this.rankRepository = rankRepository;
        }



        // GET: SubjectRankController
        public ActionResult Index()
        {
            var subjectRank = subjectRankRepository.List();
            return View(subjectRank);
        }

        // GET: SubjectRankController/Details/5
        public ActionResult Details(int id)
        {
            var subjectRank = subjectRankRepository.Find(id);
            return View(subjectRank);
        }

        // GET: SubjectRankController/Create
        public ActionResult Create()
        {

            var model = new SubjectRankViewModel
            {
                Ranks = rankRepository.List().ToList(),
                Subjects = subjectRepository.List().ToList()
                
            };
            


            return View(model);
        }

        // POST: SubjectRankController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubjectRankViewModel model)
        {
            try
            {
                var rank = rankRepository.Find(model.RankId);
                var subject = subjectRepository.Find(model.SubjectId);

                SubjectRank subjectRank = new SubjectRank
                {
                    
                    SubjectId = model.SubjectId,
                    RankId = model.RankId,
                    Rank = rank,
                    Subject = subject
                    
                };

                subjectRankRepository.Add(subjectRank);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectRankController/Edit/5
        public ActionResult Edit(int id)
        {
            var subject = subjectRepository.Find(id);
            var rank = rankRepository.Find(id);

            var viewModel = new SubjectRankViewModel
            {
                RankId = rank.Id,
                SubjectId = subject.Id,
                Ranks= rankRepository.List().ToList(),
                Subjects= subjectRepository.List().ToList()
            };
            return View(viewModel);
        }

        // POST: SubjectRankController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SubjectRankViewModel viewModel)
        {
            try
            {/*
                var rank = rankRepository.Find(viewModel.RankId);
                var subject = subjectRepository.Find(viewModel.SubjectId);
                SubjectRank subjectRank = new SubjectRank 
                {
                    
                    Rank = rank,
                    RankId = viewModel.RankId,
                    SubjectId= viewModel.SubjectId,
                    Subject = subject
                   

                };
                subjectRankRepository.Update(viewModel.SubjectId, subjectRank);
                subjectRankRepository.Update(viewModel.RankId, subjectRank);*/
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectRankController/Delete/5
        public ActionResult Delete(int id)
        {
            var subjectRank = subjectRankRepository.Find(id);
            return View();
        }

        // POST: SubjectRankController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SubjectRank subjectRank)
        {
            try
            {
                subjectRankRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
