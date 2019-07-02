using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataRepository
{
    public class AlumnoRepository : IAlumnoRepository
    {
        static List<Alumno> alumnoList = new List<Alumno>();

        static AlumnoRepository()
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Pepe";
            alumno.Apellido = "Soto";
            alumnoList.Add(alumno);
        }
        public List<Alumno> GetAll()
        {
            return alumnoList;
        }
    }
}
