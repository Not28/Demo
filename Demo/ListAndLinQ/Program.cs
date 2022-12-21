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

foreach (var stu in list)
{
    if (stu.RollNumber > 2)
    {
        Console.WriteLine(stu);
    }
}
Console.WriteLine("--------------------------");
//linq to object style 1

//var lisstu = from stu in list 
//             where stu.RollNumber > 2
//             select stu;

//foreach (var st in lisstu)
//{
//    Console.WriteLine(st);
//}

//linq to object style 1 rút gọn


foreach (var st in (from stu in list
                    where stu.RollNumber > 2
                    select stu))
{
    Console.WriteLine(st);
}

//linq to object sytle 2
var liststu = list.Where(stu=>stu.RollNumber > 2);