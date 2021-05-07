using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ResultManagementSystem.Models
{
   
    public class Classes
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }
        public string Class { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public virtual ICollection<Course> Courses { get; set; }





    }

}
