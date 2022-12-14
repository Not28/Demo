using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop.Entity;
internal class Products
{
    public string Proid { get; set; }
    public string ProName { get; set; }
    public double ProPrice { get; set; }
    public int ProQuantity { get; set; }
    public DateTime ProDate { get; set;}

    public override string ToString()
    {
        return $"{{{nameof(Proid)}={Proid}, {nameof(ProName)}={ProName}, {nameof(ProPrice)}={ProPrice.ToString()}, {nameof(ProQuantity)}={ProQuantity.ToString()}, {nameof(ProDate)}={ProDate.ToString()}}}";
    }
}
