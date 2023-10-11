// ------------------ METHOD HIDING -------------------

/*  public class Employee
{
    public string FirstName;
    public string LastName; 

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}


public class FullTimeEmployee : Employee
{
   public new void PrintFullName()
    {
        base.PrintFullName();
        //Console.WriteLine(FirstName + " " + LastName + "- FullTime");
    }
}


public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
       Console.WriteLine(FirstName + " " + LastName + "-PartTime");
    }
}

public class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.FirstName = "ABC";
        emp.LastName = "DEF";
        emp.PrintFullName();

        FullTimeEmployee emp2 = new FullTimeEmployee();
        emp2.FirstName = "XY";
        emp2.LastName = "z";
        emp2.PrintFullName();
        ((Employee)emp2).PrintFullName(); // Upcasting

        PartTimeEmployee emp3 = new PartTimeEmployee();
        emp3.FirstName = "PQ";
        emp3.LastName = "R";
        emp3.PrintFullName();
    }
} 
*/

// ------------------- METHOD HIDING AND METHOD OVERRIDING ----------------------

 /*
 public class BaseClass
{
    public void WriteNum()
    {
        Console.WriteLine(12);
    }
    public virtual void WriteStr()
    {
        Console.WriteLine("abc");
    }
}

public class DerivedClass : BaseClass
{
    public new void WriteNum()
    {
        Console.WriteLine(42);
    }
    public override void WriteStr()
    {
        Console.WriteLine("xyz");
    }
}

public class Program
{
    public static void Main()
    {
        BaseClass isReallyBase = new BaseClass();
        BaseClass isReallyDerived = new DerivedClass();
        DerivedClass isClearlyDerived = new DerivedClass();

        isReallyBase.WriteNum(); // 12
        isReallyBase.WriteStr(); // writes
        isReallyDerived.WriteNum(); // writes 12
        isReallyDerived.WriteStr(); // writes xyz
        isClearlyDerived.WriteNum(); // writes 
        isClearlyDerived.WriteStr(); // writes 
    }
}
 */

/*
public abstract class Base
{
    public abstract void fun();

    public void funTwo()
    {
        Console.WriteLine("second function of base class");
    }
    
}
*/
/*
class Derived : Base
{
    public override void fun()
    {
        Console.WriteLine("It is the implementation of abstract method"); ;
    }
}

class Program
{
    public static void Main()
    {
        Derived obj = new Derived();

        obj.fun();
        obj.funTwo();
    }
}

/*
public class Base
{
    public virtual void fun()
    {
        Console.WriteLine("In Base");
    }
}


public class Derived : Base
{
    public override void fun()
    {
        Console.WriteLine("In Derived");
    }
}


public class Program
{
    public static void Main()
    {
        Base obj = new Base();
        obj.fun();

        Derived obj2 = new Derived();   
        obj2.fun();

        Base obj3 = new Derived();  
        obj3.fun();
    }
}
*/


