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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICourese icourse;
        private IEnrollements ienrollements;
        private IStudent istudent;
        public HomeController(ILogger<HomeController> logger, ICourese icourse, IEnrollements ienrollements, IStudent istudent)
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


        public IActionResult GetAllForJoinJsonLinq()
        {
            var listado = ienrollements.UnionDeTablas();
            var CombinacionDeArreglos = (from union in listado
                                         select new
                                         {
                                             union.Course.Title,
                                             union.Student.LastName,
                                             union.Student.FirstMidName,
                                             union.Grade
                                         }).ToList();

            return Json(new { CombinacionDeArreglos});
        }

        public IActionResult GetAll()
        {
            var DandoFormatoJson = icourse.ListarCursos();

            return Json(new { data = DandoFormatoJson });
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
