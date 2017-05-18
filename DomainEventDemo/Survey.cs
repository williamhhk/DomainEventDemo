using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventDemo
{
    public class Survey
    {
        public Guid Id { get; private set; }
        public DateTime EndTime { get; private set; }
        public string QualityChecker { get; set; }

        public Survey()
        {
            this.Id = Guid.NewGuid();
        }

        public void EndSurvey()
        {
            EndTime = DateTime.Now;
            Event.Raise(new EndOfSurvey() { Survey = this });
        }
    }
}
