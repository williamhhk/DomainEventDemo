using Autofac;
using System.Linq;
using System.Reflection;

namespace DomainEventDemo
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.Load("DomainEventDemo"))
                    .Where(t => !t.IsAbstract && t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition().Equals(typeof(IHandler<>))))
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();

            var container = builder.Build();
            Event.Dispatcher = new EventDispatcher(container);

            var survey = new Survey();
            survey.EndSurvey();
        }

    }
}
