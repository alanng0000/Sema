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





    public bool MoveUp()
    {
        return this.MoveVertical(-10);
    }



    public bool MoveDown()
    {
        return this.MoveVertical(10);
    }




    public bool MoveLeft()
    {
        return this.MoveHorizontal(-10);
    }
    



    public bool MoveRight()
    {
        return this.MoveHorizontal(10);
    }




    private bool MoveHorizontal(int offset)
    {
        int left;



        left = this.AView.Grid.Pos.Left;



        left = left + offset;



        this.AView.Grid.Pos.Left = left;



        this.Frame.Update();



        return true;
    }





    private bool MoveVertical(int offset)
    {
        int up;



        up = this.AView.Grid.Pos.Up;



        up = up + offset;



        this.AView.Grid.Pos.Up = up;



        this.Frame.Update();



        return true;
    }








    





    public bool Aa()
    {
        global::System.Console.Write("Demo Aa()\n");


        this.AView.Grid.Pos.Left = 500;



        global::System.Console.Write("Demo Aa() 1\n");



        // this.AView.ColA.Width = 500;



        // global::System.Console.Write("Demo Aa() 2\n");
        



        this.Frame.Update();



        global::System.Console.Write("Demo Aa() 3\n");



        
        return true;
    }
}