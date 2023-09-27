using System;
using System.Globalization;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string s1 = "Akshat";
             string s2 = s1;
             //s2[2] = 'e';
             s2 = "Parakh";
             string s3 = s1 + s2;
             Console.WriteLine(s3);
             s3 = "Ritika";
             Console.WriteLine(s3);
             Console.WriteLine(s2);
             Console.WriteLine(s1); */

            /* string s1 = "Akshat";
             string s2 = "Akshat";
             String s3 = new String("Akshat");
             s2 = "Parakh";  // Immutability 

             Console.WriteLine(s1); Console.WriteLine(s2);
             Console.WriteLine(s3); */

            /* A string is an object of type String 
             * whose value is text. Internally, the text is stored as
             * a sequential read-only collection of Char objects. 

             In C#, the string keyword is an alias for
            String; therefore, String and string are equivalent.*/

            // Ways to inintialize string

            /* string s1;
             string s2 = null;
             string s3 = System.String.Empty;
             string s4 = "C:\\program Files\\xyz";
             string s5 = @"C\programFIles\abc";
             System.String s6 = "akshat";
             var s7 = "AKSHAT";
             const string s8 = "WatchGuard"; */

            //char[] letters = new char[] { 'A', 'K', 'S', 'H', 'A', 'T' };
            //char[] lett = { 'a', 'k', 's' };
            //string name = new string(letters);
            //string name1 = new string(lett);
            //Console.WriteLine(name);
            //Console.WriteLine(name1);

            /*Although string is a reference type,
             * the equality operators == and != are 
             * defined to compare the values of string 
             * objects, not references. Value based equality
             * makes testing for string equality more intuitive.  */

            /* string a = "hello";
              String c = "hello";
              string b = "h"; 

             b += "ello";
               Console.WriteLine(a == b);
               Console.WriteLine(object.ReferenceEquals(a, b));
               Console.WriteLine(object.ReferenceEquals(a, c));
               Console.WriteLine(a.Equals(b)); */

            //string n1 = "good";
            //string n2 = "morning";
            //string n3 = n1 + " "+  n2;
            //Console.WriteLine(n3);

            //string str1 = "Hello";
            //string str2 = str1;

            //str1 += "World";
            //Console.WriteLine(str2);

            //var names = new string[] { "akshat", "ayush", "millind" };
            //Console.WriteLine(String.Format(",",names));

            /* The CLR maintains a table called the intern pool that contains the literal strings in a program. This ensures that repeated use of the same constant strings in your code will utilize the same string reference. The System.String class provides an Intern method that ensures a 
             * string is in the intern pool and returns the reference to it. */

            /* string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 == s2);
            Console.WriteLine(object.ReferenceEquals(s1,s2));
            string s3 = new string("Hello");
            Console.WriteLine(s1 == s3);
            Console.WriteLine(object.ReferenceEquals(s1, s3));
            string s4 = "He";
            string s5 = "llo";
            string s6 = s4 + s5;
            Console.WriteLine(s1 == s6);
            Console.WriteLine(object.ReferenceEquals(s3, s6));
            string s7 = "He" + "llo";
            Console.WriteLine(s1 == s7);
            Console.WriteLine(object.ReferenceEquals(s1,s7));
            Console.WriteLine((string.Join(s4,s 5))); */

            //var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write((char)random.Next(97, 155));
            //}

            //Console.WriteLine((int)'a');

            int[] numbers = new int[] { 1, 2, 3, 4, 5, };

            //Console.WriteLine(numbers.Length);

            //int index = Array.IndexOf(numbers,4);
            //Console.WriteLine(index);

            Array.Clear(numbers, 0, 2); // Set first two items to 0... 

            //foreach (var num in numbers)
            //{ 
            //    Console.WriteLine(num);
            //}

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            foreach (var item in another)
            {
                Console.WriteLine($"{item}");
            }

            Array.Sort(numbers);    
            Array.Reverse(numbers); 
        }

        
}
}