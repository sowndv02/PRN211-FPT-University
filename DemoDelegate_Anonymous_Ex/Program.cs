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
        obj = Sub;
        obj += Add;
        obj -= Add;
        obj -= Add;
        Calculate(20, 25, Add);

    }

    // Nếu biết hàm có 2 tham số int
    // Thực hiện phép tính nào chưa biết

    public static void Calculate(int x, int y, Calculation deleobj)
    {
        deleobj(x, y);
    }
    public static int Sub(int x, int y) 
    {
        Console.WriteLine("Sub Func");
        return x - y;
    }

    /*
     Quy tắc Lambda Expression:
    1. Không cần khai báo kiểu dữ liệu truyền vào
    2. Nếu có 1 tham số thì không cần sử dụng ()
    3. Nếu hàm chỉ có 1 lệnh return thì bỏ qua dấu {} sử dụng => và bỏ luôn dấu ; ở cuối
    4. Nếu câu lệnh duy nhất là return bỏ luôn chữ return
    4. 
     */

}