using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface IStudent
    {
        void Save(Students s);

        void Delete(Students s);

        void Buscar(Students s);
        List<Students> ListOfStudents();
    }
}
