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
}