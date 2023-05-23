using DemoDelegate_Anonymous_Ex;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int Add(int x, int y)
    {
        Console.WriteLine("Add function");
        return x + y;
    }
    public static void DemoDelegate()
    {
        Calculation obj;
        obj = new Calculation(Add);
        Console.WriteLine(obj(1,22));
    }

}