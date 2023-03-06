using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameloftAsphalt8AirborneAccounting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public game Asphalt8Airborne = new game();

        private void Form1_Load(object sender, EventArgs e)
        {
            Asphalt8Airborne.setMainForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asphalt8Airborne.printListOfAllCarsToTextBox(ref this.textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asphalt8Airborne.printListOfAllCarsProducersToTextBox(ref this.textBox2);
        }
    }
}
