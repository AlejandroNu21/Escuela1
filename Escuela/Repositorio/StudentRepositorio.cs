using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class StudentRepositorio : IStudent
    {
        private ApplicationDbContext app;

        public StudentRepositorio(ApplicationDbContext app)
        {
            this.app = app;
        }
        public void Buscar(Students s)
        {
            app.Students.Find(s);
        }

        public void Delete(Students s)
        {
            app.Students.Remove(s);
        }

        public void Save(Students s)
        {
            app.Students.Add(s);
            app.SaveChanges();
        }

        public List<Students> ListOfStudents()
        {
            return app.Students.ToList();
        }


    }
}
