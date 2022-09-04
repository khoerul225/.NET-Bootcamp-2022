using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NorthwindDb
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FullName { get; set; }

        public int Age { get; set; }
    }
}
