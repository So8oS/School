using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models.Repositories;
using School.Models;
using NuGet.DependencyResolver;

namespace School.Controllers
{
    public class RankController : Controller
    {
        private ISchoolRepository<Rank> rankRepository;

        public RankController(ISchoolRepository<Rank> rankRepository)
        {
            this.rankRepository = rankRepository;
        }




        // GET: ClassController
        public ActionResult Index()
        {
            var ranks = rankRepository.List();
            return View(ranks);
        }

        // GET: ClassController/Details/5
        public ActionResult Details(int id)
        {
            var ranks = rankRepository.Find(id);
            return View(ranks);
        }

        // GET: ClassController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rank ranks)
        {
            try
            {
                rankRepository.Add(ranks);
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
        public ActionResult Edit(int id, Rank ranks)
        {
            try
            {
                rankRepository.Update(id, ranks);
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
            var ranks = rankRepository.Find(id);
            return View();
        }

        // POST: ClassController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Rank ranks)
        {
            try
            {
                rankRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
