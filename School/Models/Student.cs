using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace School.Models
{
    public class Student
    {
        public String Name { get; set; }

        [Key]
        public int ID { get; set; }

        public int Grade { get; set; }

       // public Class Class { get; set; }


    }
}
