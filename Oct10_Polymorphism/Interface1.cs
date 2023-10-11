/*
1.  We create interface using the interface keyword. Just like classes
    interfaces also contain methods, delegates or events, but 
    ONLY DECLARATIONS AND NO IMPLEMENTATIONS.

2.  It is a compile time error to provide implementations for any
    interface member.

3.  Interface members are public by default, and they don't allow
    explicit  access modifiers.

4.  Interfaces cannot contain fields.

5.  If a class or struct inherits from an interface, it must 
    provide implementation for all interface members. Otherwise,
    we get a compile error.
  
6.  A class or a struct can inherit from more than one interface
    at the same time, but where as, a class cannot inherit from 
    more than one class at the same time.

7.  Interfaces can inherit from other interfaces. A class that
    inherits this interface must provide implementation for all
    interface mambers in the entire interface chain.

8.  We cannot create an instance of an interface, but an interface
    reference variable can point to a derived class object.
*/

using System;
using System.Reflection.Metadata;

/*interface ICustomer1
{
    void Print1();

}

interface ICustomer2 : ICustomer1 
{
    void Print2();
}

public class Customer : ICustomer2
{
    public void Print1()
    {
        Console.WriteLine("I2 interface method");
    }

    public void Print2()
    {
        Console.WriteLine("Interface 1 print method");
    }
}

class Program1
{
    static void Main()
    {
        Customer c = new Customer();
        c.Print1();
        c.Print2();
    }
}*/


/* ---------------------Explicit interfaces implementation------------------------
 A class inherits from 2 interfaces and both the interfaces
 have the same method name. How should the class implement
 the method for both the interface.
*/
interface I1
{
    void func();
}

interface I2
{
    void func();
}

// *****Access modifiers are not allowed on explicitly implemented interface members*****
/*
 If we want to make one of the interface method, the DEFAULT, 
 then implement that method normally and the other interface 
 method Explicitly. This makes the default method to be accessible 
 through class instance.
 */
public class Program: I1, I2
{
     void I1.func()
    {
        Console.WriteLine("Interface 1 method");
    }

    void I2.func()
    {
        Console.WriteLine("Interface 2 method");
    }

    /*  public static void Main()
      {
          // Method 1
          var obj = new Program();

          ((I1)obj).func();
          ((I2)obj).func();

          // Method 2

          I1 i1 = new Program();
          I2 i2 = new Program();

          i1.func();
          i2.func();
      }*/
}

