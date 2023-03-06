using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameloftAsphalt8AirborneAccounting
{
    public class listofvehicles
    {
        public List<vehicle> vehicles = new List<vehicle>();
        public listofvehicles() { createTheList(); }
        public void createTheList()
        { 
                vehicles.Add(new vehicle("1","1","Dodge Dart GT"));
                vehicles.Add(new vehicle("2", "2", "Audi R8 e-tron"));
                vehicles.Add(new vehicle("3", "3" , "Ford F-150"));
                vehicles.Add(new vehicle("4","4","Camaro Z/28"));
                
        }
    }
}
