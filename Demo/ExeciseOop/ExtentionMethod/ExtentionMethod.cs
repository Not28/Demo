
namespace ExeciseOop.ExtentionMethod;
internal class ExtentionMethod
{
    public static void ChangColor<T> (this T item, params ConsoleColor[] items)
    {
        Console.BackgroundColor = items[0];
        Console.ForegroundColor = items[1];
    }

    public static bool In<T>(this T obj, params T[] items)
    {
        return items.Contains(obj);
    }
        
}
