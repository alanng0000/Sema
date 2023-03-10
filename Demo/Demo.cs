namespace Demo;




class Demo : Object
{
    private AView AView { get; set; }



    private Frame Frame { get; set; }




    public Control Control { get; set; }




    public int Execute()
    {
        Frame frame;


        frame = new Frame();


        frame.Title = "Sema Demo";


        frame.Init();




        AView aview;

        aview = new AView();

        aview.Init();



        frame.View = aview;




        this.Frame = frame;




        this.Control = new Control();


        this.Control.Init();




        this.Frame.Control = this.Control;




        this.AView = aview;




        Handle handle;

        handle = new Handle();

        handle.Init();


        handle.Demo = this;




        this.Control.Input.Handle.AddHandle(handle);
        



        this.Frame.Execute();




        this.Frame.Final();





        this.AView.Final();





        return 0;
    }
    





    public bool GridMoveUp()
    {
        return this.MoveVertical(this.AView.Grid.Pos, -10);
    }



    public bool GridMoveDown()
    {
        return this.MoveVertical(this.AView.Grid.Pos, 10);
    }




    public bool GridMoveLeft()
    {
        return this.MoveHorizontal(this.AView.Grid.Pos, -10);
    }




    public bool GridMoveRight()
    {
        return this.MoveHorizontal(this.AView.Grid.Pos, 10);
    }





    public bool GridDestMoveUp()
    {
        return this.MoveVertical(this.AView.Grid.Dest.Pos, -10);
    }



    public bool GridDestMoveDown()
    {
        return this.MoveVertical(this.AView.Grid.Dest.Pos, 10);
    }




    public bool GridDestMoveLeft()
    {
        return this.MoveHorizontal(this.AView.Grid.Dest.Pos, -10);
    }




    public bool GridDestMoveRight()
    {
        return this.MoveHorizontal(this.AView.Grid.Dest.Pos, 10);
    }





    public bool TextMoveUp()
    {
        return this.MoveVertical(this.AView.Text.Pos, -10);
    }



    public bool TextMoveDown()
    {
        return this.MoveVertical(this.AView.Text.Pos, 10);
    }




    public bool TextMoveLeft()
    {
        return this.MoveHorizontal(this.AView.Text.Pos, -10);
    }




    public bool TextMoveRight()
    {
        return this.MoveHorizontal(this.AView.Text.Pos, 10);
    }






    public bool ImageSourceMoveUp()
    {
        return this.MoveVertical(this.AView.Image.Source.Pos, 10);
    }



    public bool ImageSourceMoveDown()
    {
        return this.MoveVertical(this.AView.Image.Source.Pos, -10);
    }




    public bool ImageSourceMoveLeft()
    {
        return this.MoveHorizontal(this.AView.Image.Source.Pos, 10);
    }




    public bool ImageSourceMoveRight()
    {
        return this.MoveHorizontal(this.AView.Image.Source.Pos, -10);
    }





    private bool MoveHorizontal(Pos pos, int offset)
    {
        int left;



        left = pos.Left;



        left = left + offset;



        pos.Left = left;



        this.Frame.Update();



        return true;
    }





    private bool MoveVertical(Pos pos, int offset)
    {
        int up;



        up = pos.Up;



        up = up + offset;



        pos.Up = up;



        this.Frame.Update();



        return true;
    }





    public bool Close()
    {
        this.Frame.Close();



        return true;
    }




    public bool GridToggleVisible()
    {
        bool b;


        b = this.AView.Grid.Visible;



        b = !b;



        this.AView.Grid.Visible = b;




        this.Frame.Update();


        return true;
    }


    

    
    public bool TextWidthIncrease()
    {
        this.SizeWidthChange(this.AView.Text.Size, 10);



        
        return true;
    }




    public bool GridDestWidthIncrease()
    {
        this.SizeWidthChange(this.AView.Grid.Dest.Size, 10);



        
        return true;
    }




    public bool GridDestWidthDecrease()
    {
        this.SizeWidthChange(this.AView.Grid.Dest.Size, -10);



        
        return true;
    }







    private bool SizeWidthChange(Size size, int different)
    {
        int width;



        width = size.Width;




        width = width + different;




        size.Width = width;





        this.Frame.Update();



        
        return true;
    }





    public bool FrameNotVisible()
    {
        this.Frame.Visible = false;



        return true;
    }






    public bool Aa()
    {
        this.AView.Grid.Pos.Left = 500;



        this.Frame.Update();



        
        return true;
    }
}