using Autofac;
using DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfData;

namespace WcfFacade
{
    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // register types
            builder.RegisterType<AlumnoRepository>().As<IAlumnoRepository>();
            builder.RegisterType<Service1>().As<IService1>();

            // build container
            return builder.Build();
        }
    }
}