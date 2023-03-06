using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameloftAsphalt8AirborneAccounting
{
    public class listofvehiclesproducers
    {
        public List<vehicleproducer> vehicleproducers = new List<vehicleproducer>();
        public listofvehiclesproducers() { createListofvehiclesproducers(); }
        public void createListofvehiclesproducers()
        { 
            vehicleproducers.Add(new vehicleproducer("1","Dodge"));
            vehicleproducers.Add(new vehicleproducer("2", "Audi"));
            vehicleproducers.Add(new vehicleproducer("3", "Ford"));
            vehicleproducers.Add(new vehicleproducer("4", "Chevrolet"));
        }

    }
}
