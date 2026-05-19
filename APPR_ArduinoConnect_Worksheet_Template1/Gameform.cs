using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPR_ArduinoConnect_Worksheet_Template1
{
    public partial class Gameform : Form
    {
        int horizontal, vertical, rotation;
        string locationtype = "";
        Arduinoform arduinoform = null;
        Location newLocation = null;
        List<Location> locationlist = null; 
        int moveArduinoCounter = 0;
        string commando = "";
        Location currentLocation = null;
        int currentLocationCount = 0;
        bool moveBusy = false;
        public Gameform()

        {
            InitializeComponent();
        }

        private void Gameform_Load(object sender, EventArgs e)
        {
            arduinoform = new Arduinoform(this);
            locationlist = new List<Location>();

            newLocation = new Location(860, 880, 0, "Pickup");
            locationlist.Add(newLocation);

            newLocation = new Location(0, 0, 2900, "Pickup");
            locationlist.Add(newLocation);

            newLocation = new Location(0, 0, 2900, "Pickup");
            locationlist.Add(newLocation);

            btnRunApplication.Enabled = false;
        }

        private void btnConnectArduino_Click(object sender, EventArgs e)
        {
            arduinoform.Show();
            arduinoform.Left = this.Left + this.Width + 10;
            arduinoform.Top = this.Top;
        }

        private void btnRunApplication_Click(object sender, EventArgs e)
        {
            if (locationlist.Count != 0)
            {
                moveBusy = false;
                currentLocationCount = 0;
                currentLocation = locationlist[currentLocationCount];
                moveArduinoCounter = 0;
                tmrArduino.Start();
            }
            else
            {
                MessageBox.Show("There are no steps saved for the arduino.");
            }
        }

        private void tmrArduino_Tick(object sender, EventArgs e)
        {
            commando = "";

            if (moveArduinoCounter == 0)
            {
                commando = "HS:860";
            }
            else if (moveArduinoCounter == 1)
            {
                commando = "VS:880";
            }
            else if (moveArduinoCounter == 2)
            {
                commando = "CS:1";
            }
            else if (moveArduinoCounter == 3)
            {
                commando = "SS:1";
            }
            else if (moveArduinoCounter == 4)
            {
                commando = "VS:0";
            }
            else if (moveArduinoCounter == 5)
            {
                commando = "HS:0";
            }
            else if (moveArduinoCounter == 6)
            {
                commando = "RS:2900";
            }
            else if (moveArduinoCounter == 7)
            {
                commando = "VS:1500";
            }
            else if (moveArduinoCounter == 8)
            {
                commando = "HS:1500";
            }
            else if (moveArduinoCounter == 9)
            {
                commando = "CS:0";
            }
            else if (moveArduinoCounter == 10)
            {
                commando = "SS:0";
            }
            else
            {
                tmrArduino.Stop();
                return;
            }

            if (moveBusy == false)
            {
                moveBusy = true;
                arduinoform.WriteArduino(commando);
            }
        }

        public void ArduinoConnected()
        {
            btnRunApplication.Enabled = true;
            lblConnected.Text = "Yes";
        }

        public void NextArduinoStep()
        {
            moveBusy = false;
            moveArduinoCounter++;

            if (moveArduinoCounter > 10)
            {
                tmrArduino.Stop();
            }
        }
    }
}
