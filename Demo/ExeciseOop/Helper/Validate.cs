

using System.Globalization;
using System.Linq.Expressions;

namespace ExeciseOop.Helper;
internal class Validate<T>
{
    public static T CheckReadLine()
    {
        var typeCode = Type.GetTypeCode(typeof(T));
        object obj      = new();
        bool flag;
        do
        {
            flag = true;
            try{
                var str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("eror , null of empty");
                }
                switch(typeCode)
                {
                    case TypeCode.String:
                        obj = str;
                        break;
                    case TypeCode.Int32:
                        obj = Convert.ToInt32(str);
                        if ((int)obj < 0) throw new Exception("Value must be greter than zero");
                        break;
                    case TypeCode.Double:
                        obj = Convert.ToDouble(str);
                        if ((double)obj < 0) throw new Exception("Value must be greter than zero");
                        break;
                    case TypeCode.DateTime:
                        var date = DateTime.TryParseExact(str, new[] {"d/M/yyyy","d-M-yyyy"}, new CultureInfo("vi-vn"), DateTimeStyles.None, out var t)? t: throw new Exception("datetime wrong (d/M/yyyy or d-M-yyyy)")  
                        break;
                    default:
                        obj = null;
                        break;
                    
                }

            }catch(Exception e)
            {
                Console.WriteLine($"{e.GetType()}:{e.Message},plese enter again");
            }
                
        } while (!flag);
        return (T)obj;
    }
}
