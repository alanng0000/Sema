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





    public WinRectangle ExecuteWinRectangle(Rect rect)
    {
        WinRectangle u;

        u = new WinRectangle(this.ExecuteWinPoint(rect.Pos), this.ExecuteWinSize(rect.Size));


        return u;
    }





    public WinPoint ExecuteWinPoint(Pos pos)
    {
        WinPoint u;
        
        u = new WinPoint(pos.Left, pos.Up);


        return u;
    }




    public WinSize ExecuteWinSize(Size size)
    {
        WinSize u;
        
        u = new WinSize(size.Width, size.Height);


        return u;
    }




    public WinColor ExecuteWinColor(Color color)
    {
        WinColor c;


        c = WinColor.FromArgb(color.Alpha, color.Red, color.Green, color.Blue);


        return c;
    }
}