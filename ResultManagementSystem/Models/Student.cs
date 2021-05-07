using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Student

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string ParentEmail { get; set; }

        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }

        
    }
}
