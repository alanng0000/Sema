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



        int a;

        a = u.Shift.Index;



        bool shift;

        shift = control.Get(a);




        if (!shift & k == u.LetterW)
        {
            this.Demo.GridMoveUp();
        }


        if (!shift & k == u.LetterS)
        {
            this.Demo.GridMoveDown();
        }


        if (!shift & k == u.LetterA)
        {
            this.Demo.GridMoveLeft();
        }


        if (!shift & k == u.LetterD)
        {
            this.Demo.GridMoveRight();
        }




        if (!shift & k == u.LetterI)
        {
            this.Demo.TextMoveUp();
        }


        if (!shift & k == u.LetterK)
        {
            this.Demo.TextMoveDown();
        }


        if (!shift & k == u.LetterJ)
        {
            this.Demo.TextMoveLeft();
        }


        if (!shift & k == u.LetterL)
        {
            this.Demo.TextMoveRight();
        }



        if (shift & k == u.LetterI)
        {
            this.Demo.ImageSourceMoveUp();
        }


        if (shift & k == u.LetterK)
        {
            this.Demo.ImageSourceMoveDown();
        }


        if (shift & k == u.LetterJ)
        {
            this.Demo.ImageSourceMoveLeft();
        }


        if (shift & k == u.LetterL)
        {
            this.Demo.ImageSourceMoveRight();
        }




        if (!shift & k == u.LetterH)
        {
            this.Demo.GridToggleVisible();
        }

        



        if (!shift & k == u.LetterC)
        {
            this.Demo.TextWidthIncrease();
        }





        if (!shift & k == u.LetterT)
        {
            this.Demo.FrameNotVisible();
        }





        if (!shift & k == u.LetterB)
        {
            this.Demo.Close();
        }



        return true;
    }
}