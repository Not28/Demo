using ExtentionMethod;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("vui lòng nhập 1 số");
int i = int.TryParse(Console.ReadLine(), out var result)?result:0;

// Làm kiểm tra số lớn hơn 100
CheckNumber.Check(i, 100);



i.IsGetterThan(100);
int abc = 500;
abc.IsGetterThan(100);

//Extention Method không thông qua đối tượng của class đang chứa
//mà thông qua cái muốn sử dụng

Program pro = new();
pro.Hi();
