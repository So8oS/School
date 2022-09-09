using Microsoft.EntityFrameworkCore;
using School.Models;
using System.ComponentModel.DataAnnotations;

namespace School.ViewModel
{
    
    public class SubjectRankViewModel
    {
        
        public int SubjectId { get; set; }
        public int RankId { get; set; }
        public List<Rank> Ranks { get; set; }
        public List<Subject> Subjects { get; set; }
        
    }
}
