using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class PeopleCounterReading
    {
        public string serial { get; set; }
        public string name { get; set; }
        public long timestamp { get; set; }
        public int @in { get; set; }
        public int @out { get; set; }


        public int getCurrentPeopleCount()
        {
            if (@in - @out > 0)
                return @in - @out;
            else return 0;
        }
    }
}