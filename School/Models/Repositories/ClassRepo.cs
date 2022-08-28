namespace School.Models.Repositories
{
    public class ClassRepo : ISchoolRepository<Class>
    {

        SchoolDbContext db;

        public ClassRepo(SchoolDbContext _db)
        {
            db = _db;
        }
        public void Add(Class entity)
        {
            db.Classes.Add(entity);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var Class = Find(id);
            db.Classes.Remove(Class);
            db.SaveChanges();
        }

        public Class Find(int ClassID)
        {
            var Class = db.Classes.SingleOrDefault(x => x.ClassId == ClassID);
            return Class;
        }

        public IList<Class> List()
        {
            return db.Classes.ToList(); ;
        }

        public void Update(int id, Class newClass)
        {
            db.Update(newClass);
            db.SaveChanges();
        }
    }
}
