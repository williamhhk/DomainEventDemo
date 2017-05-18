using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    class Program
    {

        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            //builder.RegisterAssemblyTypes(Assembly.Load("MediatorDemo"))
            //        .Where(t => !t.IsAbstract && t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition().Equals(typeof(IMediate))))
            //        .AsImplementedInterfaces()
            //        .InstancePerLifetimeScope();

            //builder.RegisterAssemblyTypes(Assembly.Load("MediatorDemo"))
            //        .Where(t => !t.IsAbstract && t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition().Equals(typeof(IQuery<>))))
            //        .AsImplementedInterfaces()
            //        .InstancePerLifetimeScope();

            var container = builder.Build();
            var mediator = new Mediator();
            mediator.Register<IQueryHandler<IQuery<ProductDetailQuery>, ProductDetailQuery>, ProductDetailQueryHandler>();
            builder.RegisterAssemblyTypes(Assembly.Load("MediatorDemo"))
                    .Where(t => !t.IsAbstract && t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition().Equals(typeof(IMediate))))
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();


            var query = new ProductDetailQuery(2);
            mediator.Request<ProductDetailModel>(query);
            
        }
    }

}
