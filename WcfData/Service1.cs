using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataRepository;

namespace WcfData
{
    public class Service1 : IService1
    {
        private IAlumnoRepository alumnoRepository;

        public Service1(IAlumnoRepository alumnoRepository)
        {
            this.alumnoRepository = alumnoRepository;
        }
        public List<Alumno> GetAll()
        {
            return this.alumnoRepository.GetAll();
        }
        public void Add(Alumno alumno)
        {
            throw new NotImplementedException();
        }
    }
}
