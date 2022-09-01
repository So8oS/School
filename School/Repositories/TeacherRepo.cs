
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace School.Models.Repositories
{
    public class TeacherRepo : ISchoolRepository<Teacher>
    {
        SchoolDbContext db;
        
        public TeacherRepo(SchoolDbContext _db)
        {
          db = _db;
        }



        public void Add(Teacher entity)
        {
            db.Teachers.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var teacher = Find(id); 

            db.Teachers.Remove(teacher);
            db.SaveChanges();
        }

        public Teacher Find(int id)
        {
            var teacher = db.Teachers.Include(x=>x.Rank).SingleOrDefault(x => x.ID == id);
            return teacher; 
        }

        public IList<Teacher> List()
        {
            return db.Teachers.Include(x => x.Rank).ToList();
        }


        public void Update(int id, Teacher newTeacher)
        {
            db.Update(newTeacher);
            db.SaveChanges();

        }
    }
}
