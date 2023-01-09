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




        Text text;

        text = new Text();

        text.Init();

        text.Size.Width = 300;

        text.Size.Height = 100;


        text.Back = transparentBrush;




        string s;

        s = "AAABBB HHHH KKKK OOOOO";



        text.Value.Span.String = s;


        text.Value.Span.Range.End = s.Length;




        view.Child = text;




        frame.View = view;





        frame.Execute();



        return 0;
    }
}