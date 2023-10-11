using System;


public class Vehicle
{
    private string _registrationNumber;

    //public Vehicle()
    //{
    //    Console.WriteLine("Vehicle is being initialized.");
       
    //}

    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
        Console.WriteLine($"Vehicle is being initialized.{registrationNumber}");
    }
}

//class Program
//{
//    static void Main()
//    {
//        var car = new Car("akshat");
//    }
//}