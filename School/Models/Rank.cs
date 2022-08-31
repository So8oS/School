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
        public int Id { get; set; }
        public String Name { get; set; }



    }
}
