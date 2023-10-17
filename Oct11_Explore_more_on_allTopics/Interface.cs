interface ISampleInterface
{
    public void SampleMethod()
    {
        Console.WriteLine("called in interface");
    }
}
interface ISample2
{
    public void Sampling()
    {
        Console.WriteLine("Hello in sample2");
    }
}

class ImplementationClass : ISampleInterface,ISample2
{
    //public void SampleMethod()
    //{
    //    Console.WriteLine("called in class");
    //}

}

public class Program
{
   
        public static void Main()
        {
            Console.WriteLine("hello");
            ISample2 obj = new ImplementationClass();

            obj.Sampling();
        }
   
}
