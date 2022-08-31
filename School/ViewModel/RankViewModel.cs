 using School.Models;
using System.ComponentModel.DataAnnotations;

namespace School.ViewModel
{
    public class RankViewModel
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name { get; set; }

        public string Occupation { get; set; }

        public int RankId { get; set; }
        public List<Rank> Ranks { get; set; }

    }
}
