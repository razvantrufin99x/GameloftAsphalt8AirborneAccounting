using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameloftAsphalt8AirborneAccounting
{
    public class vehicle
    {
        public string codvehicle;
        public string codvehicleproducer;
        public string name;
        public int rank;
        public float acceleration;
        public float topspeed;
        public float handling;
        public float nitro;
        public string photo;
        public string logo;
        public string color;
        public string tires;
        public string suspension;
        public string drivetrain;
        public string exhaust;
        public string update;
        public nitrotank thenitrotank;
        public wheel wheeltype;
        public steeringwheel thesteeringwheel;
        public breake breakstype;
        public drivetrain thedrivetrain;
        public exhaust theexhaust;
        public tire tirestype;
        public string sticker;

        public bool owned = false;
        public bool fullupdated = false;


        public vehicle() { }
        public vehicle(
            string pcodvehicle,
            string pcodvehicleproducer,
            string pname           
            ) 
        { 
            this.codvehicle = pcodvehicle;
            this.codvehicleproducer = pcodvehicleproducer;
            this.name = pname;
         }

    }
}
