namespace System.View;




class Infra : InfraObject
{
    public static Infra This { get; } = CreateGlobal();




    private static Infra CreateGlobal()
    {
        Infra global;

        global = new Infra();

        global.Init();


        return global;
    }




    public bool DrawRect(Rect rect, ref DrawRect drawRect)
    {
        drawRect.Pos = new DrawPos();

        drawRect.Pos.Init();


        drawRect.Pos.Left = rect.Pos.Left;

        drawRect.Pos.Up = rect.Pos.Up;




        drawRect.Size = new DrawSize();

        drawRect.Size.Init();


        drawRect.Size.Width = rect.Size.Width;

        drawRect.Size.Height = rect.Size.Height;



        return true;
    }
}