namespace School.Models.Repositories
{
    public class RankRepo : ISchoolRepository<Rank>
    {

        SchoolDbContext db;

        public RankRepo(SchoolDbContext _db)
        {
            db = _db;
        }






        public void Add(Rank entity)
        {
            db.Ranks.Add(entity);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var rank = Find(id);
            db.Ranks.Remove(rank);
            db.SaveChanges();
        }

        public Rank Find(int Id)
        {
            var rank = db.Ranks.SingleOrDefault(x => x.Id == Id);
            return rank;
        }

        public IList<Rank> List()
        {
            return db.Ranks.ToList(); ;
        }

        public void Update(int id, Rank newRank)
        {
            db.Update(newRank);
            db.SaveChanges();
        }
    }
}
