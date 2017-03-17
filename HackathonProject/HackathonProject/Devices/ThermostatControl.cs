using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProject
{
    class ThermostatControl : Device
    {
        public double temperatureSetting { get; set; }
        public ThermostatControl(string name) : base(name)
        { }
    }
}
