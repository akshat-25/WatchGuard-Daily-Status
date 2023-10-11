using System;
using System.Security.Cryptography.X509Certificates;

// ----------- ref --------------
/* class Demo
{
    public static void Main()
    {
        int i = 0;

        func(ref i);

        Console.WriteLine(i);
    }

    public static void func(ref int j)
    {
        j = 111;
    }  
} */

// --------- out ----------
 /*class Demo
{
    public static void Main()
    {
        int total;
        int prdd;

        Calculate(10,20,out total,out prdd);

        Console.WriteLine($"The sum is {total} and product is {prdd}");
    }

    public static void Calculate(int FN, int SN,out int sum, out int prod)
    {
        sum = FN + SN;
        prod = FN * SN;

    }
} 
 */
// ----------Params-------------

/*
 ** Params is used to make the parameters optional.
 ** If there are more than one arguements in a function or method than the 
    param array should be the last one in the parameter list.
 ** We can have only one param as parameter array.
 */
 /* class Demo
{
    public static void Main()
    {
        int[] Numbers = new int[4];
        Numbers[0] = 100;
        Numbers[1] = 101;
        Numbers[2] = 102;
        Numbers[3] = 103;

        //ParamMethod(); // 0
        ParamMethod(1,2,Numbers);
        //ParamMethod(1, 2, 3, 4, 4, 5, 5, 6);  //1,2,3,4,5,6 these are arguements.
    }

    public static void ParamMethod(int i, int j ,params int[] Numbers) {  // params[] int Numbers are parameters.
       
        Console.WriteLine($"There are {Numbers.Length} elements.");
        Console.WriteLine("i is " + i);
        Console.WriteLine("j is " + j);

        foreach (var item in Numbers)
        {
            Console.WriteLine(item);
        }
    }
}*/



// -------------in----------------

 /* class Demo
{
    public static void Main()
    {
        int i = 10;

        func1(i);

        Console.WriteLine(i);
    }

    public static void func1(in int j) // ref read only
    {
        j = 90;
        int k = j++;

    }
} 
 */ 

/* public class Point
{
    public int _x = 10;
    public int _y = 20;
    

}

public class Calculator
{
    public void add(in Point p)
    {
        p._x = 1;
        p._y = 2;
    }
}

public class Demo
{
    public static void Main()
    {
        Point pt = new Point();
        Calculator cal = new Calculator();
        cal.add(pt);

        Console.WriteLine(pt._x);
        Console.WriteLine(pt._y);
    }
}
*/ 