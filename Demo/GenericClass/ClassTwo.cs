using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class ClassTwo<A,B>
{
    public A Field1 { get; set; }
    public B Field2 { get; set; }

    public void Show() => Console.WriteLine($"{ Field1}, {Field2}"); 

}
