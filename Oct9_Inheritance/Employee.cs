using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public void printFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public new void printFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Full Time"); 
    }
}
public class PartTimeEmployee : Employee
{
    //public new void printFullName() // use 'new' keyword if the hiding is intended...
    //{
    //    //base.printFullName();
    //    Console.WriteLine(LastName + " " + FirstName + "- Contractor");
    //}

    //public override void printFullName()
    //{
    //    Console.WriteLine(FirstName + " " + LastName + "- Part Time");
    //}
}

//public class TemporaryEmployee : Employee
//{
//    public override void printFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + "- Temporary");
//    }
//}

class Demo
{
     static void Main()
    {
        Employee FTE = new FullTimeEmployee(); // PTE is a variable of Employee type pointing to an object of PartTimeEmployee
        //PartTimeEmployee PTE = new PartTimeEmployee();
        FTE.FirstName = "ABC";
        FTE.LastName = "DEF";
        ((FullTimeEmployee)FTE).printFullName();

        //FTE.printFullName();
        //Employee[] employees = new Employee[4];

        //employees[0] = new Employee();
        //employees[1] = new FullTimeEmployee();
        //employees[2] = new PartTimeEmployee();
        //employees[3] = new TemporaryEmployee();


        //foreach (var emp in employees)
        //{
        //    emp.printFullName();
        //}

    }
}

/* 
 * Parent/Base class reference variable can actually point to Child class 
 * object but vice-versa is not true. 
 

  Q) What is Polymorphism?
  Ans.) * Polymorphism enables us to invoke the derived class methods using the base class 
          reference variable at runtime.
        * In the Base Class, the method is declared virtual and the same method is override 
          in Derived Class.
        * The virtual keyword indicates that the method can be overridden.
        
 */