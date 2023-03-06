using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameloftAsphalt8AirborneAccounting
{
    public class vehicleproducer
    {
        public string codvehicleproducer;
        public string denumire;
        public string country;
        public string logo;
        public string info;

        public vehicleproducer() { }
        public vehicleproducer(
            string codvehicleproducer, string denumire)
        {
            this.codvehicleproducer = codvehicleproducer;
            this.denumire = denumire;

        }
    }
}
