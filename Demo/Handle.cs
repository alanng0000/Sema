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
        



        if (!state)
        {
            return true;
        }



        Control control;

        control = this.Demo.Control;



        KeyList u;

        u = control.Key;



        bool capLock;

        capLock = control.CapLock;




        if (!capLock & k == u.LetterW)
        {
            this.Demo.GridMoveUp();
        }


        if (!capLock & k == u.LetterS)
        {
            this.Demo.GridMoveDown();
        }


        if (!capLock & k == u.LetterA)
        {
            this.Demo.GridMoveLeft();
        }


        if (!capLock & k == u.LetterD)
        {
            this.Demo.GridMoveRight();
        }




        if (!capLock & k == u.LetterI)
        {
            this.Demo.TextMoveUp();
        }


        if (!capLock & k == u.LetterK)
        {
            this.Demo.TextMoveDown();
        }


        if (!capLock & k == u.LetterJ)
        {
            this.Demo.TextMoveLeft();
        }


        if (!capLock & k == u.LetterL)
        {
            this.Demo.TextMoveRight();
        }



        if (capLock & k == u.LetterI)
        {
            this.Demo.ImageSourceMoveUp();
        }


        if (capLock & k == u.LetterK)
        {
            this.Demo.ImageSourceMoveDown();
        }


        if (capLock & k == u.LetterJ)
        {
            this.Demo.ImageSourceMoveLeft();
        }


        if (capLock & k == u.LetterL)
        {
            this.Demo.ImageSourceMoveRight();
        }




        if (!capLock & k == u.LetterH)
        {
            this.Demo.GridToggleVisible();
        }

        



        if (!capLock & k == u.LetterC)
        {
            this.Demo.TextWidthIncrease();
        }





        if (!capLock & k == u.LetterT)
        {
            this.Demo.FrameNotVisible();
        }





        if (!capLock & k == u.LetterB)
        {
            this.Demo.Close();
        }



        return true;
    }
}