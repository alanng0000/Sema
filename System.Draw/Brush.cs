namespace Sema.Draw;




public class Brush : InfraObject
{
    internal ulong Intern { get; set; }




    public virtual bool Final()
    {
        return true;
    }
}