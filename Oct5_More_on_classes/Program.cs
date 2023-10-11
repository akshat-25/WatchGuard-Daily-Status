using Methods;
using System;



namespace Demo
{
    
    class Program 
    {
         /* static void Main(string[] args) {


            //var person = new Person(new DateTime(2001, 11, 25));
            //person.setBirthDate(new DateTime(2001,11,25));

            //Console.WriteLine(person.getBirthdate());

            //Console.WriteLine(person.Age);

            //var cookie = new HttpCookie();
            //cookie["name"] = "Test";
            //Console.WriteLine(cookie["name"]);

            var stopwatch = new StopWatch();

            while(true)
            {
                stopwatch.setStartTime(DateTime.Now);

                Console.WriteLine("Press 1  to stop");

                var inp =  Console.ReadLine();

                if(int.Parse(inp) == 1)
                {
                    stopwatch.setEndTime();

                    Console.Write("Want to continue, press 2");
                    var ip2 =  Console.ReadLine();

                    if(int.Parse(ip2) != 2)
                    {
                        break;
                    }
                }

                else
                {
                    break;
                }

            }

        } */
        // *** If we want our method to return more than one value, then "out" parameter is used.
       
        static void useOfOut()
        {
            int total = 0;
            int prod = 1;

            Calculate(10, 20, out total, out prod);

            Console.WriteLine($"Sum -> {total} ans Product -> {prod}");
        }
        static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7, 8, 9));
        }

        static void usePoints()
        {   
            try
            {
                var point = new Point(10, 20);
                point.move(new Point(200, 930));

                Console.WriteLine($"Point is at the location {point.X}, {point.Y}");

                point.move(new Point(100, 230));

                Console.WriteLine($"Point is at the location {point.X}, {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpexted error occured ");
            }
        }
    }
}