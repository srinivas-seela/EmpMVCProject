using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using EmpMVC.Data.Interfaces;
using EmpMVC.Data.Repositories;

namespace EmpMVC.Data.DI
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDBContext>();
        }
    }
}
