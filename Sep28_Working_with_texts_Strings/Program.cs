using Microsoft.VisualBasic;
using System;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args) {
            /* string s1 = "akshat parakh";

             string s2 = s1.ToUpper();
             Console.WriteLine(s2);

             string s3 = "WatchGuard       Technologies         ";

             string s4 = s3.Trim();  // Remove trailing white spaces from the string
             Console.WriteLine($"Trim: '{s4}'");

             var index = s1.IndexOf(' ');
             var firstName = s1.Substring(0, index);
             Console.WriteLine(firstName);
             Console.WriteLine(s1.Substring(index + 1));

             var names = s1.Split(' ');
             Console.WriteLine("First Name: " + names[0]);
             Console.WriteLine("Last Name: " + names[1]);

             string s5 = s1.Replace("akshat", "AKSHAT");
             Console.WriteLine(s5);

             if (String.IsNullOrEmpty(" ".Trim()))
             {
                 Console.WriteLine("Invalid!!");
             }

             // Better Approach

             if (String.IsNullOrWhiteSpace(s1))
             {
                 Console.WriteLine("Invalid stirng!!");
             }

             var age = "22";
             int age1 = int.Parse(age);
             int age2 = Convert.ToByte(age);

             Console.WriteLine(age1);
             Console.WriteLine(age2);

             float price = 38.62f;

             Console.WriteLine(price.ToString("C0")); */

            //var sentence = "This is a very very very long sentence. And I am not willing to write this again and again";
            //var summary = SummarizeText(sentence);
            //Console.WriteLine(summary);

            /* ----- STRING BUILDER ----- */

            //var builder = new StringBuilder("Hello World!!!!"); // String Builder is used to manipulate the stirngs...

            //builder.Append('-', 10)
            //       .AppendLine()
            //       .Append("Header")
            //       .AppendLine()
            //       .Append('-',10)
            //       .Replace('-', '$')
            //       .Remove(0, 10)
            //       .Insert(0,new string('@',10));
            //builder[3] = 'R'; // We cannot do this is normal stirng
            //Console.WriteLine(builder);

            /* -----  EXERCISE QUESTION - 1 ------
            var inp = "";
            inp = Console.ReadLine();

            var nums = inp.Split('-');
           
            for(int i = 1;i<nums.Length;i++)
            {
                int j = int.Parse(nums[i]);
                int k = int.Parse(nums[i-1]);
                if (j-k != 1)
                {
                    Console.WriteLine("Not consecutive");
                    break;
                }
                else
                {
                    if(i == nums.Length-1)
                        Console.WriteLine("consecutive");
                    continue;
                } *//////


            //var builder = new StringBuilder(Console.ReadLine());

            //Console.WriteLine("Result: {0}", builder.ToString());

            // EXERCISE QUESTION 3

            /* var time = "";
             time = Console.ReadLine();
             if(time.Length == 0)
             {
                 Console.WriteLine("Invalid Time");
             }
             var nums = time.Split(':');

             int hrs = int.Parse(nums[0]);
             int min = int.Parse(nums[1]);   

             if((hrs >= 0 && hrs <= 23) && (min >= 0 && min <= 59))
             {
                 Console.WriteLine("Ok");
             }
             else
             {
                 Console.WriteLine("Invalid Time");
             }
            */

            //-------------FILE AND FILE INFO-------------------
            /*
            Generally if you are performing a single operation on a file, 
            use the File class. If you are performing multiple operations on the same file, use FileInfo.
            The reason to do it this way is because of the security 
            checking done when accessing a file. When you create an instance of FileInfo, 
            the check is only performed once. However, each time you use a static File method the check is performed. 
             */
            //var path = @"c:\somefile.jpg";
            //File.Copy(@"c:\temp\myFile.jpg", @"d:\temp2\abd.jpg", true);
            //File.Delete(path);  


            //var content = File.ReadAllText(path);
            ////Console.WriteLine(content);

            //var fileInfo = new FileInfo(content);


            //------------DIRECTORY------------
            //var files = Directory.GetFiles(@"C:\Users\aparakh\source\repos\WatchGuard", "*.*", SearchOption.AllDirectories);

            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //}

            //var path = @"C:\Users\aparakh\source\repos\WatchGuard";

            //var dotIndex = path.IndexOf('.');
            //var extension = path.Substring(dotIndex);

            //Console.WriteLine(Path.GetExtension(path));

            var path = @"C:\Users\aparakh\Documents\sql injection.txt";

            var content = File.ReadAllText(path);

            var words = content.Split(' ');

            Console.WriteLine(words.Length);
            var dis = " ";
            int temp = 0;
            foreach (var word in words)
            {
                if(word.Length > temp)
                {
                    dis = word;
                    temp = word.Length;
                }


            }

            Console.WriteLine(dis);

        }

        }

        /*  static string SummarizeText(string text,int maxLength = 20)
          {
              if(text.Length < maxLength)
              {
                  return text;
              }

              var words = text.Split(' ');
              var totalCharacters = 0;
              var summaryWords = new List<string>();  

              foreach( var word in words) { 
                 summaryWords.Add(word);  
                  totalCharacters += word.Length + 1;
                  if(totalCharacters > maxLength) {
                      break;
                  }


              }

              return String.Join(" ", summaryWords) + ".....";

          } */



    }
