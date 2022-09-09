using School.Models;
using System.ComponentModel.DataAnnotations;

namespace School.ViewModel
{
    public class StudentRankViewModel
    {
        
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int Grade { get; set; }

        public int RankId { get; set; }
        public List<Rank> Ranks { get; set; }
    }
}
