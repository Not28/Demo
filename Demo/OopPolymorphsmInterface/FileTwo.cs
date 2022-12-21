using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphsmInterface;
internal class FileTwo : IBinaryFile, ITestFile
{
    //không dùng bổ từ
    void IBinaryFile.ReadFile() => Console.WriteLine("read file");

    void ITestFile.ReadFile() => Console.WriteLine("read file");

    //buộc phải dùng
    public void WriteBinaryFile() => Console.WriteLine("write binary file");

    public void WriteTestFile() => Console.WriteLine("write test file");

}
