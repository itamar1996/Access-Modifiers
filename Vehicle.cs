using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Vehicle
    {
        protected string model;
        private int engineCapacity;
    }

    internal class Car : Vehicle
    {
        internal int numofdoors;
        Car(string model1 , int numdoors ) 
        { 
            this.model = model1;
            numofdoors = numdoors;
        }
        public void get_detles()
        {
            Console.WriteLine("car model " + this.model + " numdoors: " + this.numofdoors );
        }
    }
}
