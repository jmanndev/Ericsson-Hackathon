using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject
{
    class Program
    {
        static void Main(string[] args)

        {
            Main main = new HackathonProject.Main();

            Building build = new Building("test");
            build.pollForBuildingData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RoomForm(build));
        }
    }
}
