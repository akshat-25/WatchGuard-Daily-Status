using System;


//using Sep26.Math;
namespace Program
{
    //public class Person
    //{
    //    public string FirstName;
    //    public string LastName;
    //    private int a = 1;
    //    public void Introduce()
    //    { 
    //        int a = 2; 
    //        Console.WriteLine("Hello, my name is " + FirstName + " " + LastName);
    //    }
    //}
    class Status
    {
       static void Main(string[] args)
        {
            //string s = "11";
            //int i = int.Parse(s);
            //Console.WriteLine(i);
            //Console.WriteLine("The char is {0}",(char)i); // Why error is not generated
            //Person person = new Person();
            //var person = new Person();
            //person.FirstName = "Akshat";
            //person.LastName = "Parakh";

            //person.Introduce();

            var calc = new Calculator();

            //Console.WriteLine(calculator.Add(5, 5));

            int[] numbers = new int[3];
            numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //var num = new bool[3];
            //num[0] = true;
            var ch = new char[3];
            ch[0] = 'A';
            ch[1] = 'K';
            ch[02] = 'S';
           


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ch[i]);
            }

            var names = new string[3] { "Akshat","Parakh","WatchGuard!!"};

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            var anytype = new Object[3]; // IMPORTANT

            anytype[0] = true;
            anytype[1] = 2;
            anytype[2] = "Akshat";

            for (int i = 0; i < anytype.Length; i++)
            {
                Console.WriteLine(anytype[i]);
            }

            string msg1 = null;
            //msg1 = "AKSHAT PARAKH";
            var firstName = "Akshat";
            var lastName = "Parakh";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(msg1);

            var myFullName = string.Format("My name is {0} {1}",firstName,lastName);
            Console.WriteLine(myFullName);

            var jnt = string.Join("     ", names);
            Console.WriteLine(jnt);

            // Initialize with a regular string literal.
            string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

            // Initialize with a verbatim string literal.
            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

            Console.WriteLine(oldPath);
            Console.WriteLine(newPath);

            int n1 = 1;
            int n2 = 2;
            int n3 = n1 + n2;

            Console.WriteLine($"The value of n1+n2 is {n3}");
            
        }

       
        
    }
}