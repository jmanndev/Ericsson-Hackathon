using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class Luminosity : Sensor
    {
        public Luminosity(string ID) : base(ID)
        { }

        public override void pollForData()
        {
            jsonData = Utility.getRawJSon(getJsonURL(ID, "LUM", 7.0));
            base.pollForData();

        }
            
    }
}
