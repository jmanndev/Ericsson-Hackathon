using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    public class LightControl : Device
    {
        public double lightSetting {get;set;}

        public LightControl(string name) : base(name)
        { }
    }
}
