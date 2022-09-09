using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class SubjectRank
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public int RankId { get; set; }
        [Display(Name = "Class")]
        public virtual Rank Rank { get; set; }

    }
}
