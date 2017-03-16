using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class DataAtTime
    {
        DateTime dateTimeOfReading;
        int reading;

        public DataAtTime(DateTime dateTimeOfReading, int reading) 
        {
            this.dateTimeOfReading = dateTimeOfReading;
            this.reading = reading;
        }
    }
}
