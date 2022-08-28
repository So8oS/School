using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Teacher
    {
        public String Name { get; set; }

        [Key]
        public int ID { get; set; }
        public String Occupation { get; set; }

        //public Class Class { get; set; }

    }
}
