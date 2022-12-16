
namespace OopAbstraction;
internal abstract class Cat:Animal
    
//nếu Cat(con) không viết dc biểu thức của Animal(Cha) thì phải có abstract
{
    private bool gender;
     public void ShowInfoCat()
    {
        Console.WriteLine($"{nameof(gender)}= {gender}");
    }

}
