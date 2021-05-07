using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public String Subject1 { get; set; }
        public String Subject2 { get; set; }
        public String Subject3 { get; set; }
        public String Subject4 { get; set; }
        public int ClassId { get; set; }

        public int Credits { get; set; }

        public virtual Classes Classes { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
