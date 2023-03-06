namespace System.Infra;



public class IntOp : Object
{
    public static IntOp This { get; } = CreateGlobal();




    private static IntOp CreateGlobal()
    {
        IntOp global;

        global = new IntOp();

        global.Init();


        return global;
    }




    public int Sub(int left, int right)
    {
        int o;

        o = 0;



        if (!(left < right))
        {
            o = left - right;
        }



        int ret;

        ret = o;


        return ret;
    }





    public int Div(int left, int right)
    {
        int o;

        o = 0;



        if (!(right == 0))
        {
            o = left / right;
        }



        int ret;

        ret = o;


        return ret;
    }
}
