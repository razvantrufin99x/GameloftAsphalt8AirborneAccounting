using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameloftAsphalt8AirborneAccounting
{
    public class game
    {

        public Form mainform;

        public string codgame;
        
        public string denumire;
        public string codcompany;
        
        
        public string codplayer;


        public listofvehicles allvehicles = new listofvehicles();
        public listoftracks alltrack = new listoftracks();
        public listofvehiclesproducers allproducers = new listofvehiclesproducers();


        public List<coin> coins= new List<coin>();
        public List<groupproductprice> listofallpricesperproduct = new List<groupproductprice>();
        



        public game() { }
        public game(Form pf) { this.setMainForm(pf); }

        public void setMainForm(Form f) { this.mainform = f; }

        public void printListOfAllCarsToTextBox(ref TextBox t) {
            t.Text += "\r\n";
            for (int index = 0; index < allvehicles.vehicles.Count; index++)
            {
                t.Text += allvehicles.vehicles[index].codvehicle;
                t.Text += " ";
                t.Text += allvehicles.vehicles[index].codvehicleproducer;
                t.Text += " ";
                t.Text += allvehicles.vehicles[index].name;
                t.Text+= "\r\n";
            }
        }

        public void printListOfAllCarsProducersToTextBox(ref TextBox t)
        {
            t.Text += "\r\n";
            for (int index = 0; index < allproducers.vehicleproducers.Count; index++)
            {
                t.Text += allproducers.vehicleproducers[index].codvehicleproducer;
                t.Text += " ";
                t.Text += allproducers.vehicleproducers[index].denumire;
                t.Text += " ";
                
                t.Text += "\r\n";
            }
        }


    }
}
