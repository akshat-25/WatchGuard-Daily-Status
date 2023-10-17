//using System;
//using System.Security.Cryptography.X509Certificates;

//public class Base1
//{
//    public int a;
//    public int b;
//    public void add()
//    {
//        Console.WriteLine(a+b);
//    }
//}

//public class Program1
//{
//   public static void Main()
//    {
//      Base1 obj = new Base1();
//        obj.a = 1;
//        obj.b = 2;

//        obj.add();
//    }
//}

/*public class Customer
{
    public int CustomerID { get; set;}
    public string CustomerName { get; set; }

    public void Add()
    {
        validate();
        createDBObjects();
    }

    private void validate() { }
    private void createDBObjects(){ }
}


public class Program
{
    public static void Main() {
    
        Customer obj = new Customer();
        obj.CustomerID = 1;
        obj.CustomerName = "test";

        obj.Add();

        
    }
} 
*/


/*
using System.Collections.Generic;
using System.Text;

public class Demo
{ 
    public static void Main()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        //list.Add(2);
        list.Add(2);
        Console.WriteLine(list.Capacity);
        list.Remove(1);
        list.RemoveAt(0);
        list.RemoveAt(4);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // list.RemoveAll();

        var st = new StringBuilder();

        st.Append("1");
        st.Append("aaaaaaaaaa");

        Console.WriteLine(st);
    }
}
*/


using System.Diagnostics;

interface Ishape
{
    void Add();
    static int a;

    
}

public class Remote {
    int a = 1;
    int b = 1;
    //public void fun(int A, int B) {
    //    this.a = A;
    //    this.b = B
    //}

    //public Remote() {
    //    Console.WriteLine("Parameterless ctor");
    //}

    //public Remote(int a){
        
    //}
}
public class Base
{

    public static void Main() {
        //Ishape.a = 1;

        //Console.WriteLine(Ishape.a);

        //Remote remote = new Remote(5);

        string s1 = null;
        string s2 = string.Empty;
        string s3 = "";
        Console.WriteLine(s1 == s2);
        Console.WriteLine(s1 == s3);
        Console.WriteLine(s2 == s3);

    }
}