using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace School.Models
{
    public class Rank
    {
        [Key]
        [Display(Name = "Class Id")]
        public int Id { get; set; }
        [Display(Name = "Class Number")]
        public String Name { get; set; }

        public List<SubjectRank> SubjectRank { get; set; }


    }
}
