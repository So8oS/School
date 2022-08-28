namespace School.Models.Repositories
{
    public class StudentRepo : ISchoolRepository<Student>
    {
       SchoolDbContext db;

        public StudentRepo(SchoolDbContext _db)
        {
            db = _db;
        }
        public void Add(Student entity)
        {
            db.Students.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
        }

        public Student Find(int id)
        {
            var student = db.Students.SingleOrDefault(x => x.ID == id);
            return student;

        }

        public IList<Student> List()
        {
            return db.Students.ToList();
        }

        public void Update(int id, Student newStudent)
        {
            db.Update(newStudent);
            db.SaveChanges();

        }
    }
}
