using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventDemo
{
    public class EndOfSurveyHandler : IHandler<EndOfSurvey>
    {
        public void Handle(EndOfSurvey args)
        {
            args.Survey.QualityChecker = "Ivan Amalo";
            Console.WriteLine("This is a test");
        }
    }
}
