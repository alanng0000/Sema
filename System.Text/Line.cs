namespace Sema.Text;





public class Line : InfraObject
{
    public override bool Init()
    {
        base.Init();
        



        this.Char = new CharList();


        this.Char.Init();



        return true;
    }




    public CharList Char { get; private set; }
}