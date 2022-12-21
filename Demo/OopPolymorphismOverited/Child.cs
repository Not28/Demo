using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverited;
internal class Child : Parent
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("child display");
    }

    //thêm new để tạo phương thức mới
    public new void Show()
    {
        Console.WriteLine("child show");
    }
}