using OopEncapsulation;
namespace OopEncapsulationCont;
internal class Weed : Plant
{
    static void Main(string[] args)
    {
        Weed w = new ();

        w.ProtctedInternal();
        w.Protected();
        //w.PrivateProtected(); //mặc dù là con nhưng khác Project cũng không dùng dc
    }
}
