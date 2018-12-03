using Autofac;
using Autofac.Integration.WebApi;
using DISample.Controllers;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DISample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            //AUTOFAC

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;


            builder.RegisterType<GreetingsService>().As<IGreetingsService>();
            //Property Injection wih object initializer
            //builder.Register(c => new A(){ MyB = c.ResolveOptional<B>() });
            //Property injection with autowiring
            //builder.RegisterType<A>().PropertiesAutowired();
            //Method injection lambda
            /*
             builder.Register(c => {
              var result = new MyObjectType();
              var dep = c.Resolve<TheDependency>();
              result.SetTheDependency(dep);
              return result;
            });
             */

            //Method injection with an event handler 
            /*
             builder
              .Register<MyObjectType>()
              .OnActivating(e => {
                var dep = e.Context.Resolve<TheDependency>();
                e.Instance.SetTheDependency(dep);
              });
             */

            //Specific parameters
            //builder.RegisterType<A>().WithProperty("PropertyName", propertyValue);

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //AUTOFAC
        }
    }
}
