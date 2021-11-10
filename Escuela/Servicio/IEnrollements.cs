using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface IEnrollements
    {
        void Ward(Enrollment e);

        void Insertar(Enrollment e);

        List<Enrollment> UnionDeTablas();
    }
}
