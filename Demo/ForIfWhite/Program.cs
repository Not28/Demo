using System.Collections;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string[] arrs = { "not1", "not2", "not3", "not4" };

foreach(var t in arrs)
{
    Console.WriteLine($"{t}: có chiều dài {t.Length}");
}

//int i = 0;
//int leangth = arrs.Length;
//while (i< leangth)
//{
//    Console.WriteLine($"{arrs[i]} có chiều dài{arrs[i].Length}");
//    i++;
//}

IEnumerator e = arrs.GetEnumerator();
while (e.MoveNext())
{
    string s = (string)e.Current;
    Console.WriteLine($"{s}: có chiều dài {s.Length}");
}
