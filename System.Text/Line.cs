namespace System.Text;





public class Line : InfraObject
{
    public override bool Init()
    {
        base.Init();
        



        this.Chars = new Chars();


        this.Chars.Init();



        return true;
    }




    public Chars Chars { get; private set; }
}