using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private IStudent istudent;

        public StudentController(ILogger<StudentController> logger, IStudent istudent)
        {
            this.istudent = istudent;
            _logger = logger;
        }


        public IActionResult Insertar()
        {

            return View();
        }

        public IActionResult SaveStudent(Students s)
        {
            if (ModelState.IsValid)
            {
                istudent.Save(s);
                return View();
            }
            else
            {
                return View("SaveStudent", s);
            }

        }

        public IActionResult GetAllStudent()
        {
            var DandoFormatoJsonStudent = istudent.ListOfStudents();

            return Json(new { data = DandoFormatoJsonStudent });
        }

        public IActionResult MostrarAlumnos()
        {
            return View();
        }

    }
}
