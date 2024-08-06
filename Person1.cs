using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Person1
    {
        private int age;
        public void set_age(int value)
        {
        this.age = value; 
        }
        public int get_age()
        {
            return this.age;
        }
    }
}
