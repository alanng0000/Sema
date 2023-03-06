namespace Sema.Text;





public class Text : InfraObject
{
    public override bool Init()
    {
        base.Init();




        this.Line = new LineList();


        this.Line.Init();



        return true;
    }




    public LineList Line { get; private set; }
}