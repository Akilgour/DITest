using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;

namespace DITest.Autofac
{
    public static class AutofacConfiguration
    {
        //Install-Package Autofac.Mvc5

        public static void Configure()
        {
            var builder = new ContainerBuilder();

            // Register MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register Module
            builder.RegisterModule(new Service.Autofac.ServiceModule());

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}