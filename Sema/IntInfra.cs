namespace Sema;





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






    public Int New()
    {
        ulong o;

        o = this.NewValu();
        


        Int a;

        a = new Int();

        a.Valu = o;


        return a;
    }





    public bool Remove(Int a)
    {
        this.RemoveValu(a.Valu);



        return true;
    }






    private ulong NewValu()
    {
        ulong? u;



        lock (this.Lock)
        {
            u = this.Map.New();
        }
        



        if (!u.HasValue)
        {
            SystemConsole.Write("Error: Sema:IntInfra NewValu Fail\n");

            SystemEnvironment.Exit(10);
        }




        ulong k;

        k = u.Value;



        ulong ret;

        ret = k;

        return ret;
    }






    private bool RemoveValu(ulong a)
    {
        lock (this.Lock)
        {
            this.Map.Remove(a);
        }



        return true;
    }

    




    private IntMap Map { get; set; }




    private object Lock { get; set; }
}