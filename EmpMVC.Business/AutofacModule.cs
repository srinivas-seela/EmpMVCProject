using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Mvc;
using EmpMVC.Data.Repositories;
using EmpMVC.Data.Interfaces;
using EmpMVC.Data;


namespace EmpMVC.Business
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterModule(new EmpMVC.Data.DI.AutofacModule());
        }
    }
}
