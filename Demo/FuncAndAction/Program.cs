
internal class Program
{
    //Method

    public static void Add(int a, int b) => Console.WriteLine(a + b);
    public static int Subtract(int a, int b) => a - b;
    public static void Show() => Console.WriteLine("LOL");
    public static int ReturnNumber() => 5;
    private static void Main(string[] args)
    {
        //local function không dùng dc delegate
        void Sub(int a, int b) => Console.WriteLine(a - b);

        // fun and action => đều là delegate
        //action dùng cho các phương thức có void 
        //fun dùng cho các phương thức khác void

        Action act = Show;
        act();


        Action<int, int> ac = Add;
        _ = (5,6);

        Func<int> fun = ReturnNumber;
        Console.WriteLine(fun());

        Func<int, int, int> fu = Subtract;
        Console.WriteLine(fu(10,15));

        Action<string> action = (str) =>
        {
            Console.WriteLine(str);
        };

        action("Lô");

    }
}