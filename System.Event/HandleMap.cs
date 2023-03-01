namespace System.Event;




public class HandleMap : Map
{
    public override bool Init()
    {
        HandleIntCompare compare;
        
        
        compare = new HandleIntCompare();


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

        pair.Value = handle;



        this.Add(pair);



        return true;
    }




    public bool RemoveHandle(Handle handle)
    {
        this.Remove(handle.Int);



        return true;
    }
}