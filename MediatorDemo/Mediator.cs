using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public class Mediator : IMediate
    {
        public delegate object Creator(Mediator container);

        private readonly Dictionary<Type, Creator> _typeToCreator = new Dictionary<Type, Creator>();

        public void Register<T>(Creator creator)
        {
            _typeToCreator.Add(typeof(T), creator);
        }

        private T Create<T>()
        {
            return (T)_typeToCreator[typeof(T)](this);
        }

        public TResponse Request<TResponse>(IQuery<TResponse> query)
        {
            var handler = Create<IQueryHandler<IQuery<TResponse>, TResponse>>();
            return handler.Handle(query);
        }

        public void Register<TInterface, TImplementation>()
        {
            Classes.Add(new Registration { InterfaceType = typeof(TInterface), ConcreteType = typeof(TImplementation) });
        }

        private readonly List<Registration> Classes = new List<Registration>();

        public class Registration
        {
            public Type InterfaceType { get; set; }

            public Type ConcreteType { get; set; }
        }
    }
}
