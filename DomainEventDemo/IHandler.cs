using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventDemo
{
    public interface IHandler<IEvent>
    {
        void Handle(IEvent @event);
    }
}
