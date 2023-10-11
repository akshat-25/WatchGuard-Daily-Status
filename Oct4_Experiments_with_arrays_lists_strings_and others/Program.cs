using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Demo
{
    //enum Countries
    //{
    //    India = 1,
    //    US = 2,
    //    China = 3,
    //    Germany = 4,
    //    Russia = 5
    //}
    
    struct MyStruct
    {
        public MyStruct() {

            Console.WriteLine("Hello You are in Structure");
        }
    }
    class Program
    {
        static void Main(string[] args) {
            int[] arr = new int[3];
            List<int> list = new List<int>();
            //Console.WriteLine("Hello WOrld");
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //unsafe
            //{
            //    int* ptr = (int*)&list;
            //    //int* ptr1 = (int*)list[1];


            //    Console.WriteLine((long)&ptr[1]);
            //    //Console.WriteLine((long)&ptr1);
            //}
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(list[0]);
            //Console.WriteLine("Array - " + arr.Length);
            //Console.WriteLine("List - " + list.Capacity);


            var path = @"C:\Users\aparakh\Documents\sql injection.txt";

            //var content = File.ReadAllText(path);
            //Console.WriteLine("Helloooo");

            //FileInfo fi = new FileInfo(path);
            //File.AppendAllText(path,"knlkgnrelk");
            //fi.AppendText;
            //Console.WriteLine(content);

            //StreamReader readf = new StreamReader(path);

            //string line;

            //while ((line == readf.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);

            //} 
            //string s1;     //null
            //string s2 = null;
            //string s3 = "";

            //char c1;

            //Console.WriteLine(s1);
            //Console.WriteLine(s2); // exception
            //Console.WriteLine(s3.Length); // nothing is printed


            //Console.WriteLine(s1.Contains());
            //Console.WriteLine(s2.Contains('\0'));
            //Console.WriteLine(Convert.ToInt32(c1));

            //char[] arr1 = new char[3];

            //Console.WriteLine(arr1[0].ToString().Length);
            //Console.WriteLine("The arr[0] is"+arr1[0]);

            //string s11 = "";
            //Console.WriteLine(s11.Length);

            //char c1;

            //string[] arr2 = new string[3];

            //Console.WriteLine(arr2[0].Length);


            //var files = Directory.GetFiles(@"C:\Users\aparakh\source\repos\WatchGuard", "*.txt", SearchOption.AllDirectories);

            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //}

            //FileInfo file = new FileInfo(path);

            var person = Person.Parse("Akshat");
            person.Introduce("Ayush");
            //Person.Parse("Akshat");
            //person.Introduce("Ayush");

            var customer = new Customer(1,"Akshat");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            var order = new Order();
            customer.Orders.Add(order);

            //var obj1 = new MyStruct();


            MyStruct obj2;
            int i = new int();
            int j;
            Console.WriteLine(i);
            //Console.WriteLine(j); -- This will give ERROR

            //Console.WriteLine(Countries.Indi);

            var k = new { i = 1, j = 2, c = "abc" };

            //string s1;
            //string s2 = "";
            //string s3 = null;


            //Console.WriteLine(string.IsNullOrEmpty(s1));
            //Console.WriteLine(string.IsNullOrWhiteSpace(s1));

            /*
             The main difference between IsNullOrEmpty and IsNullOrWhiteSpace
            in C# is that IsNullOrEmpty checks if there's at least one character,
            while IsNullOrWhiteSpace checks every character until it finds a
            non-white-space character.
             */

            string name = "akshat";

            Console.WriteLine(string.IsNullOrEmpty(name)); // False

            Console.WriteLine(string.IsNullOrWhiteSpace(name)); // False


            Console.WriteLine(string.IsNullOrEmpty(string.Empty)); // True

            Console.WriteLine(string.IsNullOrWhiteSpace(string.Empty)); // True


            Console.WriteLine(string.IsNullOrEmpty(null)); // True

            Console.WriteLine(string.IsNullOrWhiteSpace(null)); // True


            Console.WriteLine(string.IsNullOrEmpty(" ")); // False

            Console.WriteLine(string.IsNullOrWhiteSpace(" ")); // True


            Console.WriteLine(string.IsNullOrEmpty("\0")); // False

            Console.WriteLine(string.IsNullOrWhiteSpace("\n")); // True

        }
    }
}