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
        public int ID { get; set; }
        public String Name { get; set; }

        public String Occupation { get; set; }
        public Rank Rank { get; set; }

    }
}
