

using ExeciseOop.Sevice;

namespace ExeciseOop.Dal;
internal class DalProduct : IProduct
{
    public List<Products> ListPro { get; set; } = new() ;
    public void AddProduct()
    {
        Console.WriteLine("enter the number");
        var on = Validate <int>.CheckReadLine();
        for (int i = 0; i < n; i++) { }
    }
}
