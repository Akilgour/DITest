using Autofac;
using DITest.Repository.Context;
using System.Linq;

namespace DITest.Service.Autofac
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // "ThisAssembly" means "any types in the same assembly as the module"
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .WithParameter("context", new DITestContext())
                .AsImplementedInterfaces();
        }
    }
}