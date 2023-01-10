namespace Demo;




class Demo : Object
{
    private AView AView { get; set; }



    private Frame Frame { get; set; }




    public int Execute()
    {
        Frame frame;


        frame = new Frame();


        frame.Title = "System Demo";


        frame.Init();




        AView aview;

        aview = new AView();

        aview.Init();



        frame.View = aview;




        this.Frame = frame;



        this.AView = aview;




        Handle handle;

        handle = new Handle();

        handle.Init();


        handle.Demo = this;



        Control.This.CharInput.Handle.AddHandle(handle);
        



        frame.Execute();



        return 0;
    }




    public bool Aa()
    {
        global::System.Console.Write("Demo Aa()\n");


        this.AView.Size.Width = 1000;



        global::System.Console.Write("Demo Aa() 1\n");



        this.AView.ColA.Width = 500;



        global::System.Console.Write("Demo Aa() 2\n");
        



        this.Frame.Update();



        global::System.Console.Write("Demo Aa() 3\n");



        
        return true;
    }
}