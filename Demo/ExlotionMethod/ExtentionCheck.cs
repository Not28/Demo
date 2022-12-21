using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod;
//biến class này thành Extention Method
//=>Class buộc phải là Static
//1 Class là static thì toàn bộ buộc phải là Static
internal static class ExtentionCheck
{
    public static void IsGetterThan(int i , int value)
    {
        Console.WriteLine($"{i}đúng là lớn hơn{value}");
    }

    public static void Hi(this Program obj) => Console.WriteLine("Loo");
    
}
