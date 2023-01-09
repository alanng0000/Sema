namespace Demo;




class Demo : Object
{
    public int Execute()
    {
        Frame frame;


        frame = new Frame();


        frame.Title = "System Demo";


        frame.Init();





        ColorBrush blueBrush;

        blueBrush = new ColorBrush();

        blueBrush.Color.Alpha = Constant.This.ColorCompMax;

        blueBrush.Color.Blue = Constant.This.ColorCompMax;

        blueBrush.Init();





        View view;

        view = new View();

        view.Init();

        view.Pos.Left = 100;

        view.Pos.Up = 100;

        view.Size.Width = 400;

        view.Size.Height = 400;


        view.Back = blueBrush;





        ColorBrush transparentBrush;

        transparentBrush = new ColorBrush();

        transparentBrush.Color = Constant.This.TransparentColor;

        transparentBrush.Init();




        ColorBrush greenBrush;

        greenBrush = new ColorBrush();

        greenBrush.Color.Alpha = Constant.This.ColorCompMax;

        greenBrush.Color.Green = Constant.This.ColorCompMax;

        greenBrush.Init();





        Text text;

        text = new Text();

        text.Init();

        text.Pos.Left = 100;

        text.Pos.Up = 50;

        text.Size.Width = 300;

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




        view.Child = text;




        frame.View = view;





        frame.Execute();



        return 0;
    }
}