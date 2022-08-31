using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace School.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public String Name { get; set; }

        public int Grade { get; set; }

        public int RankId { get; set; }
        public Rank Rank { get; set; }


    }
}
