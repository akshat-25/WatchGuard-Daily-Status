using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Customer
{
    string _firstName;
    string _lastName;

    public Customer() : this("No First Name provided", "No Last Name provided")
    {}

    public Customer(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public void printFullName()
    {
        Console.WriteLine($"Full Name is {_firstName} {_lastName}");
    }

    ~Customer() { }
}


