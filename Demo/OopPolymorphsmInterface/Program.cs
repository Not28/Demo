using OopPolymorphsmInterface;
using System.IO;

/*FileOne fileOne = new();
fileOne.WriteBinaryFile();
fileOne.WriteTestFile();
fileOne.ReadFile();

//cách cũ
((IBinaryFile)fileOne).ShowInfo();
(fileOne as IBinaryFile).ShowInfo();

FileTwo fileTwo = new();
fileTwo.WriteBinaryFile();
fileTwo.WriteTestFile();
(fileTwo as ITestFile).ReadFile();
(fileTwo as IBinaryFile).ReadFile();*/

ITestFile itest = new FileOne();
itest.ReadFile();
itest = new FileTwo();
itest.ReadFile();