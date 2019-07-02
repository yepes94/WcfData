using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfData
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Alumno> GetAll();
        [OperationContract]
        void Add(Alumno alumno);
    }
}
