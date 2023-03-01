namespace System.Comp;





class IntInfra : InfraObject
{
    public static IntInfra This { get; } = CreateGlobal();




    private static IntInfra CreateGlobal()
    {
        IntInfra global;

        global = new IntInfra();

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