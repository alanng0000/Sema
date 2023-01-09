namespace System.Draw;




class Convert : InfraObject
{
    public static Convert This { get; } = CreateGlobal();




    private static Convert CreateGlobal()
    {
        Convert global;

        global = new Convert();

        global.Init();


        return global;
    }





    public WinRectangle WinRectangle(Rect rect)
    {
        WinRectangle u;

        u = new WinRectangle(this.WinPoint(rect.Pos), this.WinSize(rect.Size));


        return u;
    }





    public WinPoint WinPoint(Pos pos)
    {
        WinPoint u;
        
        u = new WinPoint(pos.Left, pos.Up);


        return u;
    }




    public WinSize WinSize(Size size)
    {
        WinSize u;
        
        u = new WinSize(size.Width, size.Height);


        return u;
    }




    public WinColor WinColor(Color color)
    {
        WinColor c;


        c = global::System.Drawing.Color.FromArgb(color.Alpha, color.Red, color.Green, color.Blue);


        return c;
    }
}