using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
CLASS MEMBERS

INSTANCE : accessible from an object.

STATIC   : accessible from the class.

** "this" is a keyword that references to the current object.
 
*/

namespace Demo
{

    public class Person
    {
        public string Name;

        public void Introduce(string name1)
        {
            Console.WriteLine($"Hello {Name}, I am {name1}");
        }

        public static Person Parse(string str) {
        var person = new Person(); 
        person.Name = str;
        return person;
        }
    }
}
