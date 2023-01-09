namespace System.Event;




public class Event : InfraObject
{
    public HandleMap Handle { get; set; }




    public override bool Init()
    {
        base.Init();




        this.Handle = new HandleMap();


        this.Handle.Init();




        return true;
    }





    public virtual bool Trigger(object arg)
    {
        MapIter iter;


        iter = this.Handle.Iter();


        while (iter.Next())
        {
            Pair pair;


            pair = (Pair)iter.Value;



            Handle handle;


            handle = (Handle)pair.Value;



            handle.Execute(arg);
        }



        return true;
    }
}