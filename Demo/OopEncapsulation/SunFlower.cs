namespace OopEncapsulation;
internal class SunFlower:Plant
{
    //svm(static void Main)
    static void Main(string[] args)
    {
        Plant sf = new  ();
        sf.Public();
        sf.Internal();
        sf.ProtctedInternal();


        SunFlower s = new ();
        s.Public();
        s.Protected();
        s.Internal();
        s.PrivateProtected();
        s.ProtctedInternal();
        
    }
}
