using System;


namespace Demo
{

    class Person
    {
        public string FirstName;
        public string LastName;

        public void introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    /* class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.FirstName = "Akshat";
            per.LastName = "Parakh";
            per.introduce();
        }
    }
    */
}