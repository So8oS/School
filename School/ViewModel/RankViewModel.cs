 using School.Models;
using System.ComponentModel.DataAnnotations;

namespace School.ViewModel
{
    public class RankViewModel
    {
        
        [Display(Name = "Teacher Id")]
        public int TeacherId { get; set; }
        [Display(Name = "Teacher Name")]
        public string Name { get; set; }

        public string Occupation { get; set; }
        [Display(Name = "Class Id")]
        public int RankId { get; set; }
        public List<Rank> Ranks { get; set; }

    }
}
