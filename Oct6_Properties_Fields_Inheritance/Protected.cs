// A protected member is accessible within its class and by derived class instances.

// A protected member of a base class is accessible in a derived class only if the
// access occurs through the derived class type. 
class A
{
    protected int x = 123;
}

class B : A
{

    static void Main()
    {
        var a = new A();
        var b = new B();

        a.x = 10;

        b.x = 20;

        Console.WriteLine(a.x);
        Console.WriteLine(b.x);
    }
}