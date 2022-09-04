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
        public int studentId { get; set; }
        [Required]
        public string fullName { get; set; }

        public int Age { get; set; }
    }
}
