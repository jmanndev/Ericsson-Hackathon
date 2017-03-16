using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace HackathonProject
{
    class Temperature : Sensor
    {
        public Temperature(string ID) : base(ID)
        {}

        public override void pollForData()
        {
            jsonData = Utility.getRawJSon(getJsonURL(ID, "TCA", 7.0));
            base.pollForData();
        }
    }
}
