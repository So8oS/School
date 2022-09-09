using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Models.Repositories;

namespace School.Repositories
{
    public class SubjectRankRepo : ISchoolRepository<SubjectRank>
    {

        SchoolDbContext db;

        public SubjectRankRepo(SchoolDbContext _db)
        {
            db = _db;
        }

        public void Add(SubjectRank entity)
        {
            db.SubjectRanks.Add(entity);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var subjectRank = Find(id);
            db.SubjectRanks.Remove(subjectRank);
            db.SaveChanges();
        }

        public SubjectRank Find(int Id)
        {
            var subjectRank = db.SubjectRanks.Include(x => x.Rank).Include(s => s.Subject).SingleOrDefault(x => x.Id == Id);
            return subjectRank;
        }

        public IList<SubjectRank> List()
        {
            return db.SubjectRanks.Include(x => x.Rank).Include(s => s.Subject).ToList();
        }

        public void Update(int id, SubjectRank newSubjectRank)
        {
            db.Update(newSubjectRank);
            db.SaveChanges();
        }
    }
}