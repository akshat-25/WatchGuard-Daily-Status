/*
 when we create an object of child class,
 the parent class gets instantiated even before that,
 so the parent's class constructor are called even
 before the child class constructor.

 It is also possible for the derived class to 
 control which child class constructors are called 
 when parent class objects are created.
 */

public class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int X { get; set; }
    public int Y { get; set; }
    public void Draw()
    {

    }

}