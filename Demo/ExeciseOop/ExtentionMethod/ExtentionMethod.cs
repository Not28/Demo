using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
