using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResultManagementSystem.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResultId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Grade? Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }
}
