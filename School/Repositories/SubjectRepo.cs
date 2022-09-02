namespace School.Models.Repositories
{
    public class SubjectRepo : ISchoolRepository<Subject>
    {
        SchoolDbContext db;

        public SubjectRepo(SchoolDbContext _db)
        {
            db = _db;
        }

        public void Add(Subject entity)
        {
            db.Subjects.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var subject = Find(id);
            db.Subjects.Remove(subject);
            db.SaveChanges();
        }

        public Subject Find(int id)
        {
            var subject = db.Subjects.SingleOrDefault(x => x.Id == id);
            return subject;
        }

        public IList<Subject> List()
        {
            return db.Subjects.ToList();
        }

        public void Update(int id, Subject newSubject)
        {
            db.Update(newSubject);
            db.SaveChanges();
        }
    }
}
