using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Teacher
    {
        [Key]
        [Display(Name = "Teacher Id")]
        public int ID { get; set; }

        [Display(Name = "Teacher Name")]
        public String Name { get; set; }

        public String Occupation { get; set; }
        public Rank Rank { get; set; }

    }
}
