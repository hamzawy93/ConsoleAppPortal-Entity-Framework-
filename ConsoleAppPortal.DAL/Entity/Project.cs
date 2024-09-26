using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPortal.DAL.Entity
{
    [Table("Projects")]

    public class Project
    {
        [Required]
        [Key]

        public int ProjId { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string ProjName { get; set; }

    }
}
