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




    public int Count
    {
        get
        {
            return this.List.Count;
        }
    }




    public char[] Data
    {
        get
        {
            return this.List.Data;
        }
    }





    public char Get(int index)
    {
        return this.List.Get(index);
    }







    public bool Insert(InfraRange range)
    {
        return this.List.Insert(range);
    }




    public bool Remove(InfraRange range)
    {
        return this.List.Remove(range);
    }




    public bool Set(int index, char[] item, InfraRange range)
    {
        return this.List.Set(index, item, range);
    }
    






    public CharIter Iter()
    {
        CharIter iter;

        iter = new CharIter();

        iter.Iter = this.List.Iter();

        iter.Init();


        return iter;
    }
}