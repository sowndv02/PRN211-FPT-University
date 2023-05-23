using Q1_Sample_PE;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        User u = new User();
        Console.WriteLine(u.ToString());
        Console.WriteLine();

        ArrayList ListOfUser = new ArrayList();
        ListOfUser.Add(new User("trungnhhe130147", "trungnhhe130147@fpt.edu.vn", 1));
        ListOfUser.Add(new User("trungnhhe130148", "trungnhhe130148@fpt.edu.vn", 1));
        ListOfUser.Add(new User("trungnhhe130149", "trungnhhe130149@fpt.edu.vn", 2));

        User u1 = new User("trungnhhe130148", "trungnhhe130148@fpt.edu.vn", 2);
        Console.WriteLine("Index of u1 in ListOfUser: {0}\n", ListOfUser.IndexOf(u1));
        try
        {
            Object o = new Object();
            Console.WriteLine("Index of o in ListOfUser: ");
            if (ListOfUser.IndexOf(o) == -1) Console.WriteLine("The item id not an User.");
            else Console.WriteLine(ListOfUser.IndexOf(o));
        }catch(Exception e) 
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
}