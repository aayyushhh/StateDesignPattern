using StateDemo.Models;

internal class Program
{
     static void Main(string[] args)
    {
        var context = new Context(new ConcreteStateA());
        
        context.Request();
        context.Request();
        context.Request();
        context.Request();
    }
}