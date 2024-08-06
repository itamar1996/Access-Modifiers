using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Animal1
    {
        protected string species;
        public string GetSpecies()
        {
        return species; 
        } 
    }

    internal class Dog : Animal1
    {
        public Dog() {

            species = "dog";
        }
    }

}
