using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{

    public enum Grade
    {
        A,B,C,D
    }
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentId { get; set; }

        [Display(Name = "CourseID")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public int CourseID { get; set; }

        [Display(Name = "StudentID")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public Course Course { get; set; }

        public Students Student { get; set; }
    }
}
