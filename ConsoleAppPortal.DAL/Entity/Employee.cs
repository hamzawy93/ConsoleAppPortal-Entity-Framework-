using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPortal.DAL.Entity
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is reqiuired")]
        [MaxLength(100)]
        [MinLength(2)]

        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        [EmailAddress(ErrorMessage ="this is not an email form ")]

        public string Email { get; set; }
        public int Age { get; set; } 
        public decimal salary { get; set; }
        public int DeptID { get; set; }

    }
}
