using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class LibraryItem
    {
        protected internal string title;
        public string GetTitle() { return title; }
    }

    internal class Book:LibraryItem
    {
        public void settitle(string title)
        {
            this.title = title;
        }
    }

}
