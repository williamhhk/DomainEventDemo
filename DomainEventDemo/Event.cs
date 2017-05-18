using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventDemo
{
    public static class Event
    {
        public static IEventDispatcher Dispatcher { get; set; }

        public static void Raise<T>(T @event) where T : IEvent
        {
            Dispatcher.Dispatch(@event);
        }

    }
}
