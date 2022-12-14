//using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int number1 = Random.Shared.Next(0, 9);
int number2 = Random.Shared.Next(0, 9);
Console.WriteLine($"{number1} = {number1}");
Console.WriteLine($"{number2} = {number2}");
Console.WriteLine("vui lòng nhập dấu: ");
var pheptoan = Console.ReadLine();
switch (pheptoan)
{
    case "+" when number1>0 && number2>0:
        Console.WriteLine(number1 + number2);
        break;
    case "-" when number1 >= number2 :
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;
    case "/" when number2 != 0:
        Console.WriteLine(number1 / number2);
        break;
    default:
        Console.WriteLine("................");
        break;
}

// switch expression => biểu thức switch
Console.WriteLine(
        pheptoan switch
        {
            "+" when number1 > 0 && number2 > 0 => number1 + number2,
            "-" when number1 >= number2         => number1 - number2,
            "*"                                 => number1 * number2,
            "/" when number2>=0                 => number1 / number2,
            _ => "................"
        }
    );

