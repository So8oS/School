namespace School.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SubjectRank> SubjectRank { get; set; }
    }
}
