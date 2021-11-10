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
    public class EnrollementController : Controller
    {
        private readonly ILogger<EnrollementController> _logger;
        private ICourese icourse;
        private IEnrollements ienrollements;
        private IStudent istudent;

        public EnrollementController(ILogger<EnrollementController> logger, ICourese icourse, IEnrollements ienrollements, IStudent istudent)
        {
            this.icourse = icourse;
            this.ienrollements = ienrollements;
            this.istudent = istudent;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      

        public IActionResult ComboBox()
        {
            var informationofthecombo = icourse.ListarCursos();
            var informationofthecomboforStudents = istudent.ListOfStudents();


            List<SelectListItem> listOfCourse = new List<SelectListItem>();
            List<SelectListItem> listStudent = new List<SelectListItem>();


            foreach (var iterarinformation in informationofthecombo)
            {
                listOfCourse.Add(
                    new SelectListItem
                    {
                        Text = iterarinformation.Title,
                        Value = Convert.ToString(iterarinformation.CourseId)
                    }

                    );
                ViewBag.estadolistcourse = listOfCourse;
            }

            foreach (var iterarinformation in informationofthecomboforStudents)
            {
                listStudent.Add(
                    new SelectListItem
                    {
                        Text = iterarinformation.FirstMidName,
                        Value = Convert.ToString(iterarinformation.StudentId)
                    }

                    );
                ViewBag.estadoliststudent = listStudent;
            }


            return View();
        }

        public IActionResult GetinformationCombobox(Enrollment e)
        {
            _ = e;
            Console.WriteLine(e.CourseID);
            return View("comboBox");
        }

       
        public IActionResult ListaEnrollement()
        {

            var listado = ienrollements.UnionDeTablas();
            _ = listado;


            return View(listado);
        }

        public IActionResult Insertar()
        {

            return View();
        }

       
        
    }
}