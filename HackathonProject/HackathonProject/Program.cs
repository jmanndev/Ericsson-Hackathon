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
        static Building build;
        static RoomForm roomForm;
        
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 420000; // 7 minutes in milliseconds
            timer.Elapsed += timer_Elapsed;
            timer.Start();

            build = new Building("DemoBuilding");
            build.pollForBuildingData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            roomForm = new RoomForm(build);
            Application.Run(roomForm);

        }

        static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            build.pollForBuildingData();
            roomForm.updateRoomData();
        }
    }
}
