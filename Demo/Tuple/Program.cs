using System.Runtime.Versioning;
using UsingTuple;

Person per = new()
{
    Id = 1,
    FName = "Hoang",
    LName = "Nguyen",

};
Console.WriteLine(per.Id);
Console.WriteLine(per.FName);

//dùng Tuple không dùng đến class (struct)
ValueTuple<int, string, string> p1 = (1, "Hoang", "Nguyen");
Console.WriteLine(p1.Item1);
Console.WriteLine(p1.Item3);

//mới hơn
(int, string, string) p2 = (2, "Not", "Nguyen");
Console.WriteLine(p2.Item1);
Console.WriteLine(p2.Item2);

//dùng var 
var p3 = (3, "Not2", "Nguyen"); //value tuple

var p4 = (1); //=> variable int p4 = 1


//nên dùng 1 trong 2 cách này
//net core dùng name thay thế cho các item

(int id, string FName, string LName) p5 = (5, "Fatcat", " ");
Console.WriteLine(p5.FName);
Console.WriteLine(p5.LName);

//hoặc dùng name trước
var p6 = (id:6, FName:"Not2", LName:"Nguyen");
Console.WriteLine(p6.FName);
Console.WriteLine(p6.LName);

//không phải tuple => anonymous type
var p7 = new { id = 1, FName = "Hoang", LName = "Nguyen" };
Console.WriteLine(p7.FName);
Console.WriteLine(p7.LName);

