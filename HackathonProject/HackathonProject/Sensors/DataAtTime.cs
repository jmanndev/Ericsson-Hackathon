using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class DataAtTime
    {
        public string dateTimeOfReading { get; }
        public string reading { get; }

        public DataAtTime(string dateTimeOfReading, string reading) 
        {
            this.dateTimeOfReading = dateTimeOfReading;
            this.reading = reading;
        }

        public DateTime getDateOfReading()
        {
            return DateTime.Parse(dateTimeOfReading);
        }
    }
}
