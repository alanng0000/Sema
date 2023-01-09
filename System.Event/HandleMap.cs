namespace System.Event;




public class HandleMap : Map
{
    public override bool Init()
    {
        HandleIntentCompare compare;
        
        
        compare = new HandleIntentCompare();


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

        pair.Key = handle.Intent;

        pair.Value = handle;



        this.Add(pair);



        return true;
    }




    public bool RemoveHandle(Handle handle)
    {
        this.Remove(handle.Intent);



        return true;
    }
}