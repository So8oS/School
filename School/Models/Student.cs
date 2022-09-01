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

        [Display(Name = "Student Id")]
        public int ID { get; set; }
        [Display(Name = "Student Name")]
        public String Name { get; set; }

        public int Grade { get; set; }


        [Display(Name = "Class")]
        public Rank Rank { get; set; }


    }
}
