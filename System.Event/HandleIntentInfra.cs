namespace System.Event;





class HandleIntInfra : InfraObject
{
    public static HandleIntInfra This { get; } = CreateGlobal();




    private static HandleIntInfra CreateGlobal()
    {
        HandleIntInfra global;

        global = new HandleIntInfra();

        global.Init();


        return global;
    }





    public override bool Init()
    {
        base.Init();




        this.Lock = new object();



        this.CurrentValue = 0;



        return true;
    }






    private object Lock;




    private ulong CurrentValue;
    




    public ulong NewValue()
    {
        ulong o;


        
        lock (this.Lock)
        {
            o = this.CurrentValue;



            this.CurrentValue = this.CurrentValue + 1;
        }



        return o;
    }
}