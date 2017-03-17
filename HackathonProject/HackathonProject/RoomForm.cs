using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonProject
{
    public partial class RoomForm : Form
    {
        Building building;
        Room selectedRoom;

        public RoomForm(Building building)
        {
            InitializeComponent();
            this.building = building;
            roomDropDown.DataSource = this.building.rooms;
            roomDropDown.DisplayMember = "ID";
        }

        private void roomDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoom = (Room)roomDropDown.SelectedValue;
            lightingTextBox.Text = selectedRoom.luminositySensor.getLuxAdjustment().ToString("F") + " Lux";
            temperatureTextBox.Text = selectedRoom.temperatureSensor.getTemperatureAdjustment().ToString("F") + " C";
            peopleInRoomLabel.Text = "People in room: " + selectedRoom.peopleInRoom;
            lightingLastPollTimeLabel.Text = selectedRoom.luminositySensor.sensorReadings.Last().getDateOfReading().ToShortTimeString();
            temperatureLastPollTimeLabel.Text = selectedRoom.temperatureSensor.sensorReadings.Last().getDateOfReading().ToShortTimeString();
        }
    }
}
