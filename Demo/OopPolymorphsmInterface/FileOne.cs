using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphsmInterface;
internal class FileOne : IBinaryFile, ITestFile
{
    public void ReadFile() => Console.WriteLine("read file");

    public void WriteBinaryFile() => Console.WriteLine("write binary file");

    public void WriteTestFile() => Console.WriteLine("write test file");



}
