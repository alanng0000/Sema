namespace System.Text;





public class Text : InfraObject
{
    public override bool Init()
    {
        base.Init();




        this.Lines = new Lines();


        this.Lines.Init();



        return true;
    }




    public Lines Lines { get; private set; }
}