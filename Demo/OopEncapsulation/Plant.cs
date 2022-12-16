

namespace OopEncapsulation;
public class Plant
{
    //encapsulation thể hiện ở 2 chổ 
    //1 là access modify
    //2 là property

    //access modify ( từ khóa)
    private             void Private()          => Console.WriteLine("Private");
    //đứng tại class đó mới dc dùng
    protected           void Protected()        => Console.WriteLine("Protected");
    //chỉ cón cái mới dc dùng
    internal            void Internal()         => Console.WriteLine("Internal");
    //chỉ dc dùng khi cùng project
    private protected   void PrivateProtected() => Console.WriteLine("PrivateProtected");
    protected internal  void ProtctedInternal() => Console.WriteLine("ProtctedInternal");
    public              void Public()           => Console.WriteLine("public");
    

    

}
