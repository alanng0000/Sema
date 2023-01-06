namespace System.View;




class Create : InfraObject
{
    public static Create This { get; } = CreateGlobal();




    private static Create CreateGlobal()
    {
        Create global;

        global = new Create();

        global.Init();


        return global;
    }






    public DrawSize DrawSize(WinSize size)
    {
        DrawSize t;



        t = new DrawSize();



        t.Init();



        t.Width = size.Width;



        t.Height = size.Height;




        DrawSize ret;


        ret = t;


        return ret;
    }








    public DrawColor DrawColor(Color color)
    {
        DrawColor t;



        t = new DrawColor();



        t.Init();



        t.Alpha = this.DrawColorComp(color.Alpha);



        t.Red = this.DrawColorComp(color.Red);



        t.Green = this.DrawColorComp(color.Green);



        t.Blue = this.DrawColorComp(color.Blue);




        DrawColor ret;


        ret = t;


        return ret;
    }






    private byte DrawColorComp(int comp)
    {
        ulong u;

        u = (ulong)comp;



        byte ob;

        ob = (byte)u;



        byte ret;

        ret = ob;


        return ret;
    }
}