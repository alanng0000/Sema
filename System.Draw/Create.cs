namespace System.Draw;




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





    public WinRectangle CreateWinRectangle(Rect rect)
    {
        WinRectangle u;

        u = new WinRectangle(this.CreateWinPoint(rect.Pos), this.CreateWinSize(rect.Size));


        return u;
    }





    public WinPoint CreateWinPoint(Pos pos)
    {
        WinPoint u;
        
        u = new WinPoint(pos.Left, pos.Up);


        return u;
    }




    public WinSize CreateWinSize(Size size)
    {
        WinSize u;
        
        u = new WinSize(size.Width, size.Height);


        return u;
    }




    public WinColor CreateWinColor(Color color)
    {
        WinColor c;


        c = WinColor.FromArgb(color.Alpha, color.Red, color.Green, color.Blue);


        return c;
    }
}