using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args) { 
        /* var list = new List<int>();
            //Console.WriteLine(list.Capacity);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add('2');
            //list.Add(int.Parse('A'));
             var a = 'A';
             var b = "Aks";
            Console.WriteLine(a); //A



            //***********Parse() converts the string data type to another data type********
            // int b = int.Parse(a);
            //Console.WriteLine(int.Parse(b));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(list.Capacity); // 8

            //list.Remove('1');
            //list.Remove('2');
            //list.Remove('3');
            //list.Remove('4');
            //Console.WriteLine(list.Capacity); // 8
            //list.TrimExcess(); // USE TO OPTIMIZE MEMORY MANUALLY.....
            //Console.WriteLine(list.Capacity); // 4
            //list.Add('Z');
            //list.TrimExcess();
            //Console.WriteLine(list.Capacity); //

            


            //var arrLis = new ArrayList();
            //Console.WriteLine(arrLis.Capacity);

            //arrLis.Add(0);
            //Console.WriteLine(arrLis.Capacity);
            //arrLis.Add("aks");
            //Console.WriteLine(arrLis.Capacity);
            //arrLis.Add('a'); */

            //var list = new List<int>();
            //var list1 = new List<char>();
            //var list2 = new int[4] { 1, 2, 3, 4 };

            //var list3 = new ArrayList();

            //list3.Add(1);
            //list3.Add(2);
            //list3.Add(3);
            ////list3.Add("Akshat");
            ////list3.Add("Akshat");


            //Console.WriteLine(list.Capacity);

            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);

            //list1.Add('a');
            //list1.Add('a');
            //list1.Add('a');
            //list1.Add('a');
            //list1.Add('a');

            //Console.WriteLine(list.Capacity);

            //list.AddRange(list3);

            //Console.WriteLine(list.Capacity);  
            

            //var arrLis = new ArrayList();
            //arrLis.Add(1);
            //arrLis.Add('A');
            //arrLis.Add("Akshat");
            //arrLis.Add("AAA");
            //arrLis.Add(2);
            //arrLis.Add('M');
            //arrLis.Add(4);
            //arrLis.Add("Ayush");
            //arrLis.Add(4);

            StringBuilder s = new StringBuilder(); // By default size capacity is 16.

            /*
              A StringBuilder object maintains a buffer to accommodate expansions to the
            string. New data is appended to the buffer if room is available;
            otherwise, a new, larger buffer is allocated, data from the original
            buffer is copied to the new buffer, and the new data is then appended 
            to the new buffer.
            Confirm 
             */

            /*
             * Console.WriteLine(s.Capacity);

            var st = "";
            Console.WriteLine(st.StartsWith('a'));  // This function does not work
                                                    // with string builder
            
            var exp = new StringBuilder("hi");
            exp.AppendLine("hello");

            Console.WriteLine(exp.ToString().IndexOf('l'));

            */

            /*var path = @"C:\Users\aparakh\Desktop\New Text Document.txt";
            //var path = @"C:\Users\aparakh\Downloads\annual-enterprise-survey-2021-financial-year-provisional-csv.csv";

            //var path = @"C:\Users\aparakh\Downloads\industry.csv";
            var content = File.ReadAllLines(path);
             //Console.WriteLine(content);
             //var lines = content.Split('\n');
             foreach (var line in content)
             {
                 Console.WriteLine(line);
             }*/
            

            //var content = File.(path);
            //Console.WriteLine(content);

            //var exp = new StringBuilder("Akshat\0parakh",25);

            ////Console.WriteLine(exp.ToString().IndexOf('\0'));

            //int i = 0;
            //while (i<6)
            //{
            //    Console.WriteLine(exp[i]);
            //    Console.WriteLine(i);
            //    i++;
            //    if (exp[i] == '\0')
            //        Console.WriteLine("jj");
            //}

           //Console.WriteLine(exp.ToString().Length);
            //char[] arr = new char[16];
            //arr[6] = 'c';
            //char a = 'a';
            //char b = char.MinValue;
            //Console.WriteLine(Convert.ToInt32(b));
            //Console.WriteLine(Convert.ToInt32(a));
            //Console.WriteLine(Convert.ToInt32('a'));
            //Console.WriteLine('a'.GetTypeCode);
           /* foreach (var c in arr)
            {
                Console.WriteLine(Convert.ToInt32(c));
            } */
            //Console.WriteLine();



            var str1 = new StringBuilder("ABC", 10);
            var str2 = new StringBuilder("ABC", 10);
               
            str1.Append("akshat");
            str1.Append("parakh");
            

            



        }
    }
    }
