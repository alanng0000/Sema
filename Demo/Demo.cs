namespace Demo;




class Demo : Object
{
    public int Execute()
    {
        Frame frame;


        frame = new Frame();


        frame.Title = "System Demo";


        frame.Init();


        frame.Execute();



        return 0;
    }
}