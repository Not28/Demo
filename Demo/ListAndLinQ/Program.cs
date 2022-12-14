using System.Net;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

List<Student> list = new()
{
    new Student() {RollNumber= 1 , FullName="Not", Section="dãy nhà số 1" , HosterNumber = 1},
    new Student() {RollNumber= 2 , FullName="Not1", Section="dãy nhà số 2" , HosterNumber = 2},
    new Student() {RollNumber= 3 , FullName="Not2", Section="dãy nhà số 3" , HosterNumber = 5},
    new Student() {RollNumber= 4 , FullName="Not3", Section="dãy nhà số 4" , HosterNumber = 7},
    new Student() {RollNumber= 1 , FullName="Gin", Section="dãy nhà số 1" , HosterNumber = 3},
    new Student() {RollNumber= 2 , FullName="Gin2", Section="dãy nhà số 2" , HosterNumber = 5},
    new Student() {RollNumber= 3 , FullName="Gin3", Section="dãy nhà số 3" , HosterNumber = 4},
    new Student() {RollNumber= 4 , FullName="Gin4", Section="dãy nhà số 4" , HosterNumber = 6},
};
//(

//Stopwatch sw= new Stopwatch();
//sw.Restart();
//foreach (var stu in list )
//{
//    Console.WriteLine(stu);
//}
//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

////tất cả các dạng của Colection đều có mẫu để duyệt qua dữ liệu
////mà không dùng for hay foreach => ienumerator


////chạy nhanh hơn
//IEnumerator enu = list.GetEnumerator();
////IEnumerator <Student> = list.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current);
//}
//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

//)

//linq => language Intergrated query

//linq to object
//linq to sql
//linq to xml,json
//parallel linq => plinq (đi làm )

//select from where group by having order
//from where group by having order => select


//linq to object có 2 dạng
//style 1) theo trường phái sql=> query syntax , dễ học, dễ hiểu
//style 2) theo trường phái lamda=>method syntax, khó học , rất khó hiểu

//Liệt kê tất cả sinh viên với mã sinh viên phải lớn hơn 2

//foreach (var stu in list)
//{
//    if (stu.RollNumber > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}
//Console.WriteLine("--------------------------");
//linq to object style 1

//var lisstu = from stu in list 
//             where stu.RollNumber > 2
//             select stu;

//foreach (var st in lisstu)
//{
//    Console.WriteLine(st);
//}

//linq to object style 1 rút gọn


//foreach (var st in (from stu in list
//                    where stu.RollNumber > 2
//                    select stu))
//{
//    Console.WriteLine(st);
//}

//linq to object sytle 2(lamda => method syntax)
//var liststu = list.Where(stu=>stu.RollNumber > 2);
// foreach (var st in liststu)
//{ Console.WriteLine(st); }

//linq to object sytle 2 rút gọn
//foreach (var st in list.Where(stu => stu.RollNumber >2))
//{
//    Console.WriteLine(st);
//}

//các phương thức có sẵn trong list
//list.ForEach(Console.WriteLine);
//list.ForEach(stu => Console.WriteLine(stu));

//list.ForEach(
//        stu =>
//        {
//            if (stu.RollNumber >2)
//            {
//                Console.WriteLine(stu);
//            }
//        }
//    );

//kết hợp lamda với phương thức có sẵn trong list
//list.Where(stu => stu.RollNumber > 2)
//    .ToList()
//    .ForEach(Console.WriteLine);


//var r = from stu in list
//        where stu.RollNumber > 2
//        select new // anonymous type
//        {
//            stu.RollNumber,
//            stu.FullName
//        };
//r.ToList().ForEach(Console.WriteLine);


//var r = from stu in list
//        where stu.RollNumber > 2
//        select new // anonymous type
//        {
//            StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
//            StudentRoom   = $"{stu.Section} : {stu.HosterNumber}" 
//        };
//r.ToList().ForEach(Console.WriteLine);
//// Query Sytax


//list.Select(stu=>new
//    {
//        StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
//        StudentRoom = $"{stu.Section} : {stu.HosterNumber}"
//    }).ToList().ForEach(Console.WriteLine);
////Method Sytax


//foreach(var stu in list)
//{
//    Console.WriteLine(stu);
//}

//IEnumerator enu = list.GetEnumerator();
//while (enu.MoveNext())
//{

//}

//từ khi có linq

//var t = from stu in list
//        select stu;

//linq to Object
//lần đầu tiên nó sễ thực thi trên Sever và trả về bộ nhớ

//select * from list where rollnumber >2
//IEnumerable<Student> i = from stu in list
//                         where stu.RollNumber > 2
//                         select stu;



//i = i.Take(2);
////==================================================
//IQueryable<Student> u = from stu in list.AsQueryable()
//                        where stu.RollNumber > 2
//                        select stu;
//select top(2) * from list where rollnumber >2
//sẽ chạy lên sever lần nữa
//Linq 
//u = u.Take(2);
////=====================================================

//var k = from stu in list
//        where stu.RollNumber > 2
//        select stu;
//k.ToList().ForEach(Console.WriteLine);

//=============================================================
//sắp xếp

var obj1 = from stu in list
           where stu.RollNumber >5
           orderby stu.Section descending, stu.HosterNumber ascending
           select stu;

var obj2 = list.OrderByDescending(stu => stu.Section)
               .OrderBy(stu => stu.HosterNumber);

var obj3 = list.Where(stu=>stu.RollNumber >5)
               .OrderByDescending(stu => stu.Section)
               .ThenBy(stu => stu.HosterNumber);