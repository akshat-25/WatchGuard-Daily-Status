using System;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Demo
{

    class Program
    {
        enum Days
        {
            Sun = 6,Mon,Tue,Wed,Thu,Fri,Sat
        };
        public struct exp
        {
            public int x;
            public int x2;
            public string s1;
            public void setVal(int val)
            {
                x = val;   
            }

            public void getVal()
            {
                Console.WriteLine($"The value is {x}");
            }
        }public class Foo
        {
            public int x;
            public void setVal(int val)
            {
                x = val;   
            }

            public void getVal()
            {
                Console.WriteLine($"The value is {x}");
            }
        }
        static void Main(string[] args) { 
           
            //exp exp1 = new exp();
            //exp1.setVal(1);
            //exp1.getVal();
            Console.WriteLine(Convert.ToInt32(Days.Tue));
            //var exp2 = exp1;

            //exp2.getVal();
            //exp2.setVal(2);
            //exp2.getVal();
            //exp1.getVal();

            //var foo1 = new Foo();
            //foo1.setVal(1);
            //foo1.getVal();

            //var foo2 = foo1;

            //foo2.setVal(2);
            //foo2.getVal();
            //foo1.getVal();
            //Console.WriteLine("The size of the class is" + Marshal.SizeOf(typeof(Foo)));
            Console.WriteLine("The size of the struct is" + Marshal.SizeOf(typeof(exp)));
            //Console.WriteLine("The size of the struct is" + sizeof());
            //unsafe
            //{
            //    Console.WriteLine("The size of the class is" + Marshal.SizeOf(typeof(Foo)));
            //}
            int num1 = 10;  // Value Type
            Object obj1 = num1; // Implicit conversion of value type to object type.

            Console.WriteLine(obj1);

            int num2 = (int)obj1; // Expplicit conversion of reference type to value type.


            /*
            -- Why do we need Boxing and Unboxing?
              In c#, we have many built-in methods that accepts/ works on value type or reference
              types then we need boxing and unboxing to use that functions.

             */
            //int a = 10;
            //string s1 = "11";
            //object s = "";

            //Console.WriteLine(int.Parse(s1));
            ////Console.WriteLine(int.Parse(s));

            //var li = new List<int>();   
            //li.Add(1);
            

            //unsafe
            //{
            //    int* ptr = (int*)&li;

            //    Console.WriteLine(*ptr);
            //    Console.WriteLine(Convert.ToString((long)ptr, 16));

            //    Console.WriteLine((int)*ptr);

            //    //li.Add(3);
            //    //li.Add(4);
            //    //li.Add(5);
            //    //li.Add(6);
            //    //li.Add(7);
            //    Console.WriteLine(Convert.ToString((long)ptr, 16));

            //    Console.WriteLine((int)*ptr);

            //}

            //unsafe
            //{
            //    String s = "Hello";
            //    StringBuilder sb = new StringBuilder("Hello");
            //    String* strPtr = &s;
            //    StringBuilder* sbPtr = &sb;



            //    Console.WriteLine((string)*strPtr);
            //    Console.WriteLine((int)sbPtr);
            //    Console.WriteLine(sb.Capacity);
            //    Console.WriteLine(sb.Length);

            //    s = "World";
            //    sb.AppendLine("1234567891011213141516171819");
            //    String* strPtr2 = &s;
            //    StringBuilder* sbPtr2 = &sb;
            //    //Console.WriteLine(object.ReferenceEquals();
            //    Console.WriteLine((string)*strPtr2);
            //    Console.WriteLine((int)sbPtr2);
            //    Console.WriteLine(sb.Capacity);
            //    Console.WriteLine(sb.Length);

            //}
            //String s = "Hello";
            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.Length);
            ////s = "World";
            //sb.AppendLine("1234567891011213141516171819");
            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.ToString());

            //string s = "1234567891011213141516171819";
            //Console.WriteLine(s.Length);

            Customer customer1 = new Customer("Akshat","Parakh");
            customer1.printFullName();



        }    

    }
}



/*
                        --------- STRUCT --------- 
** Typically, you use structure types to design small data-centric types 
that provide little or no behavior. For example, .NET uses structure types
to represent a number (both integer and real), a Boolean value, a Unicode 
character, a time instance. If you're focused on the behavior of a type,
consider defining a class. Class types have reference semantics. 
That is, a variable of a class type contains a reference to an instance 
of the type, not the instance itself.


** Structures provide better performance as it is value type. Using a value type 
will result in fewer objects on the managed heap, which results in lesser load
on the garbage collector (GC), less frequent GC cycles, and consequently better
performance. However, value types have their downsides too. Passing around a big 
struct is definitely costlier than passing a reference, that's one obvious problem. 
 
 */