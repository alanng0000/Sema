namespace Sema.Event;




public class HandleMap : Map
{
    public override bool Init()
    {
        IntCompare compare;
        
        
        compare = new IntCompare();


        compare.Init();



        this.Compare = compare;



        base.Init();




        return true;
    }




    public bool AddHandle(Handle handle)
    {
        Pair pair;

        pair = new Pair();

        pair.Init();

        pair.Key = handle.Int;

        pair.Valu = handle;



        this.Add(pair);



        return true;
    }




    public bool RemoveHandle(Handle handle)
    {
        this.Remove(handle.Int);



        return true;
    }
}