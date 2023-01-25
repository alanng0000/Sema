namespace System.Draw;





public class Infra : InfraObject
{
    public static Infra This { get; } = CreateGlobal();




    private static Infra CreateGlobal()
    {
        Infra global;

        global = new Infra();

        global.Init();


        return global;
    }





    public Color CreateColor(byte alpha, byte red, byte green, byte blue)
    {
        Color color;

        color = new Color();

        color.Init();

        color.Alpha = alpha;

        color.Red = red;

        color.Green = green;

        color.Blue = blue;


        return color;
    }





    public bool BoundArea(Rect bound, ref Rect area)
    {
        int left;

        left = area.Pos.Left;



        int up;

        up = area.Pos.Up;




        int width;

        width = area.Size.Width;



        int height;

        height = area.Size.Height;




        int right;

        right = left + width;



        int down;

        down = up + height;





        int boundRight;

        boundRight = bound.Pos.Left + bound.Size.Width;



        int boundDown;

        boundDown = bound.Pos.Up + bound.Size.Height;





        if (left < bound.Pos.Left)
        {
            left = bound.Pos.Left;
        }



        if (up < bound.Pos.Up)
        {
            up = bound.Pos.Up;
        }





        if (boundRight < right)
        {
            right = boundRight;
        }



        if (boundDown < down)
        {
            down = boundDown;
        }




        int w;


        w = right - left;


        w = this.Int(w);




        int h;


        h = down - up;


        h = this.Int(h);





        area.Pos.Left = left;


        area.Pos.Up = up;


        area.Size.Width = w;


        area.Size.Height = h;




        return true;
    }




    private int Int(int a)
    {
        int o;

        o = a;



        if (o < 0)
        {
            o = 0;
        }


        return o;
    }
}