namespace School.Models.Repositories
{
    public class ClassRepo : ISchoolRepository<Class>
    {

        IList<Class> classes;

        public ClassRepo()
        {
            classes = new List<Class>()
                 {
                    new Class(){ClassId=1},
                    new Class(){ClassId=2},
                    new Class(){ClassId=3},
                };
        }
        public void Add(Class entity)
        {
            classes.Add(entity);
        }

        public void Delete(int id)
        {
            var Class = Find(id);
            classes.Remove(Class);
        }

        public Class Find(int ClassID)
        {
            var Class = classes.SingleOrDefault(x => x.ClassId == ClassID);
            return Class;
        }

        public IList<Class> List()
        {
            return classes;
        }

        public void Update(int id, Class newClass)
        {
            var Class = Find(id);
            Class.ClassId = newClass.ClassId;
        }
    }
}
