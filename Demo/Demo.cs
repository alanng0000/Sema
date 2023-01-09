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

        view.Size.Width = 100;

        view.Size.Height = 100;


        view.Back = blueBrush;


        view.Visible = true;




        frame.Execute();



        return 0;
    }
}