using System;
using System.Diagnostics;
using System.Collections.Generic;
/*
public class Baase
{
    public virtual void fun()
    {
        Console.WriteLine("In the base class");
    }
}

public class Derived : Baase
{

}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");

        Baase obj = new Derived();
        Derived obj2 = new Derived();
        obj.fun();
        obj2.fun();
    }
}
*/

/*
public class Program
{
    public static void Main()
    {
        IFile file1 = new FileInfo();
        file1.ReadFile();
        file1.WriteFile("content");
        file1.DisplayName();

        FileInfo file2 = new FileInfo();
        file1.DisplayName();
        file2.DisplayName();

    }
}

interface IFile
{
    void ReadFile();
    void WriteFile(string text);

    void DisplayName()
    {
        Console.WriteLine("IFile");
    }
}

class FileInfo : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading File");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing to file");
    }

    public void DisplayName()
    {
        Console.WriteLine("In class Function");
    }
}

*/


interface I1
{
    public void func1()
    {
        Console.WriteLine("in I1");
    }
}

interface I2
{
    public void func1()
    {
        Console.WriteLine("in I2");
    }
}

class A : I1, I2
{
    //public void func1()
    //{
    //    Console.WriteLine("This is the func1 of interface 1");
    //}

    //void I2.func1()
    //{
    //Console.WriteLine("This is the func1 of interface 2");
    // }
    //public void func2() 
    //{
    //    Console.WriteLine("This is the fuunction of the class");
    //}
    
    
}


public class Program
{
    public static void Main()
    {
        I1 a = new A();
        a.func1();

        I2 b = new A();
        b.func1();

        A c = new A();
        


    }
}



/*
interface I1
{
    private static int a = 1;
    public static int b = a;

    public static void func1()
    {
        Console.WriteLine("In the func1 of the interface");
    }

     static I1()
    {
        Console.WriteLine("Static constructor in the iterface I1.");
    }

}
// Difference b/w static and const.
public class Base : I1
{ 
    //const int k = 1;

    public Base()
    {
        Console.WriteLine("Default constructor of the class");
    }
    public void func1()
    {
        Console.WriteLine("In the func1 of the class.");
    }
    public static void Main()
    {
        I1 a = new  Base();
        I1.func1();
        //I1.func1();


        //Base b = new Base();
        //b.func1();
        //Console.WriteLine(Base.k);
    }
}

*/