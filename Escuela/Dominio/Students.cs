using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public string LastName { get; set; }

        [Display(Name = "FirstMidName")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public string FirstMidName { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "DATO REQUERIDO")]
        public DateTime EnrollmentsDate { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }



    }
}
