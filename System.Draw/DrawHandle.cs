namespace System.Draw;




public class DrawHandle : InfraObject
{
    public virtual bool Execute(Draw draw)
    {
        return true;
    }
}