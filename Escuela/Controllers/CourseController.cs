using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> _logger;
        private ICourese icourse;

        public CourseController(ILogger<CourseController> logger, ICourese icourse)
        {
            this.icourse = icourse;
            _logger = logger;
        }

        public IActionResult insert(Course c)
        {

            return View();
        }

        public IActionResult Indexdos(Course c)
        {
            if (ModelState.IsValid)
            {
                icourse.Insertar(c);
                return View();
            }
            else
            {
                return View("Indexdos", c);
            }
            
        }

        public IActionResult GetAll()
        {
            var DandoFormatoJson = icourse.ListarCursos();

            return Json(new { data = DandoFormatoJson });
        }


        public IActionResult MostrarCourses()
        {
            return View();
        }
    }
}
