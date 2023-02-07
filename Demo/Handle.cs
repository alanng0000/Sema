namespace Demo;




class Handle : EventHandle
{
    public Demo Demo { get; set; }



    public override bool Execute(object arg)
    {
        KeyArg o;

        o = (KeyArg)arg;



        Key k;

        k = o.Key;



        bool state;

        state = o.State;
        




        Control control;

        control = this.Demo.Control;



        KeyList u;

        u = control.Key;



        if (!state)
        {
            if (k == u.Tab)
            {
                this.Tab = !this.Tab;
            }


            return true;
        }



        bool b;

        b = this.Tab;
        




        if (!b & k == u.LeftUp)
        {
            this.Demo.GridMoveUp();
        }


        if (!b & k == u.LeftDown)
        {
            this.Demo.GridMoveDown();
        }


        if (!b & k == u.LeftLeft)
        {
            this.Demo.GridMoveLeft();
        }


        if (!b & k == u.LeftRight)
        {
            this.Demo.GridMoveRight();
        }




        if (b & k == u.LeftUp)
        {
            this.Demo.GridDestMoveUp();
        }


        if (b & k == u.LeftDown)
        {
            this.Demo.GridDestMoveDown();
        }


        if (b & k == u.LeftLeft)
        {
            this.Demo.GridDestMoveLeft();
        }


        if (b & k == u.LeftRight)
        {
            this.Demo.GridDestMoveRight();
        }




        if (!b & k == u.RightUp)
        {
            this.Demo.TextMoveUp();
        }


        if (!b & k == u.RightDown)
        {
            this.Demo.TextMoveDown();
        }


        if (!b & k == u.RightLeft)
        {
            this.Demo.TextMoveLeft();
        }


        if (!b & k == u.RightRight)
        {
            this.Demo.TextMoveRight();
        }



        if (b & k == u.RightUp)
        {
            this.Demo.ImageSourceMoveUp();
        }


        if (b & k == u.RightDown)
        {
            this.Demo.ImageSourceMoveDown();
        }


        if (b & k == u.RightLeft)
        {
            this.Demo.ImageSourceMoveLeft();
        }


        if (b & k == u.RightRight)
        {
            this.Demo.ImageSourceMoveRight();
        }




        if (!b & k == u.LetterH)
        {
            this.Demo.GridToggleVisible();
        }

        



        if (!b & k == u.LetterC)
        {
            this.Demo.TextWidthIncrease();
        }





        if (b & k == u.LetterC)
        {
            this.Demo.GridDestWidthIncrease();
        }


        if (b & k == u.LetterV)
        {
            this.Demo.GridDestWidthDecrease();
        }





        if (!b & k == u.LetterT)
        {
            this.Demo.FrameNotVisible();
        }





        if (!b & k == u.LetterB)
        {
            this.Demo.Close();
        }



        return true;
    }




    private bool Tab
    {
        get; set;
    }
}