using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Service.Autofac
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // "ThisAssembly" means "any types in the same assembly as the module"
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                //.WithParameter("context", new PurchaseOrderManagerContext())
                //.WithParameter("entityExpressions", new PurchaseOrderCreateDate())
                .AsImplementedInterfaces();
        }
    }
}
