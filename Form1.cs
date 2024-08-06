using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_Modifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void strart_btn_Click(object sender, EventArgs e)
        {
            Person1 person = new Person1();
            person.set_age(21);
            int a= person.get_age();
            label1.Text = "age of person is"+ a.ToString();
            Dog dog = new Dog();
            label1.Text += "spechi is " + dog.GetSpecies();
            MathOperations mathop = new MathOperations();
            int b = mathop.add2(2, 3);
            label1.Text += " add2  = " + b.ToString();
            Book book = new Book();
            book.title = "tora";
            label1.Text += " title book: " + book.title;
        }
    }
}
