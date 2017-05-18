using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventDemo
{
    public class EventDispatcher : IEventDispatcher
    {
        private readonly IContainer _container;

        public EventDispatcher(IContainer kernel)
        {
            _container = kernel;
        }


        public void Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IEvent
        {
            foreach (var handler in _container.Resolve<IEnumerable<IHandler<TEvent>>>())
            {
                handler.Handle(eventToDispatch);
            }
        }
    }
}
