namespace System.Text;






public class CharList : InfraObject
{
    private GenericList<char> List;




    public override bool Init()
    {
        base.Init();



        this.List = new GenericList<char>();

        this.List.Init();



        return true;
    }
}