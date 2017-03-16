using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class DataAtTime
    {
        string dateTimeOfReading;
        string reading;

        public DataAtTime(string dateTimeOfReading, string reading) 
        {
            this.dateTimeOfReading = dateTimeOfReading;
            this.reading = reading;
        }
    }
}
