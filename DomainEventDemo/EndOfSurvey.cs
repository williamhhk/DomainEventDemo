using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventDemo
{
    public class EndOfSurvey : IEvent
    {
        public Survey Survey { get; set; }
    }
}
