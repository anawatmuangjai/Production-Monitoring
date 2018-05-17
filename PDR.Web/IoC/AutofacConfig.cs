using Autofac;
using Autofac.Integration.Mvc;
using PDR.Web.Controllers;
using PDR.Web.Core;
using PDR.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDR.Web.IoC
{
    public static class AutofacConfig
    {
        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();
            //builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<MonitorRepository>().As<IMonitorRepository>();
            builder.RegisterType<MonitorController>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}