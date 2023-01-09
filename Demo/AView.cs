namespace Demo;




class AView : View
{
    public override bool Init()
    {
        base.Init();








        ColorBrush blueBrush;

        blueBrush = new ColorBrush();

        blueBrush.Color.Alpha = Constant.This.ColorCompMax;

        blueBrush.Color.Blue = Constant.This.ColorCompMax;

        blueBrush.Init();






        this.Pos.Left = 100;

        this.Pos.Up = 100;

        this.Size.Width = 800;

        this.Size.Height = 600;


        this.Back = blueBrush;





        ColorBrush transparentBrush;

        transparentBrush = new ColorBrush();

        transparentBrush.Color = Constant.This.TransparentColor;

        transparentBrush.Init();




        ColorBrush greenBrush;

        greenBrush = new ColorBrush();

        greenBrush.Color.Alpha = Constant.This.ColorCompMax;

        greenBrush.Color.Green = Constant.This.ColorCompMax;

        greenBrush.Init();




        Grid grid;


        grid = new Grid();


        grid.Init();


        grid.Size.Width = 700;




        






        Text text;

        text = new Text();

        text.Init();

        text.Pos.Left = 100;

        text.Pos.Up = 50;

        text.Size.Width = 400;

        text.Size.Height = 100;


        text.Back = greenBrush;




        string s;

        s = "AAABBB HHHH KKKK OOOOO";



        text.Value.Span.String = s;


        text.Value.Span.Range.End = s.Length;



        FontStyle fontStyle;

        fontStyle = new FontStyle();

        fontStyle.Init();

        fontStyle.Underline = true;




        Font font;

        font = new Font();

        font.Family = "Cascadia Mono";

        font.Size = 30;

        font.Style = fontStyle;


        font.Init();



        text.Font = font;




        this.Child = text;





        return true;
    }
}