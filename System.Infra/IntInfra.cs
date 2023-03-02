namespace System.Infra;





public class IntInfra : Object
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



        this.Map = new IntMap();

        this.Map.Init();




        this.Lock = new object();



        return true;
    }





    public ulong NewValue()
    {
        ulong? u;



        lock (this.Lock)
        {
            u = this.Map.NewInt();
        }
        



        if (!u.HasValue)
        {
            Console.Write("Error: System.Infra:IntInfra NewValue Fail\n");

            Environment.Exit(10);
        }




        ulong k;

        k = u.Value;



        ulong ret;

        ret = k;

        return ret;
    }




    private IntMap Map { get; set; }



    private object Lock { get; set; }
}