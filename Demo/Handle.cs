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




        if (!shift & k == 'I')
        {
            this.Demo.TextMoveUp();
        }


        if (!shift & k == 'K')
        {
            this.Demo.TextMoveDown();
        }


        if (!shift & k == 'J')
        {
            this.Demo.TextMoveLeft();
        }


        if (!shift & k == 'L')
        {
            this.Demo.TextMoveRight();
        }



        if (shift & k == 'I')
        {
            this.Demo.ImageSourceMoveUp();
        }


        if (shift & k == 'K')
        {
            this.Demo.ImageSourceMoveDown();
        }


        if (shift & k == 'J')
        {
            this.Demo.ImageSourceMoveLeft();
        }


        if (shift & k == 'L')
        {
            this.Demo.ImageSourceMoveRight();
        }




        if (!shift & k == 'H')
        {
            this.Demo.GridToggleVisible();
        }

        



        if (!shift & k == 'C')
        {
            this.Demo.TextWidthIncrease();
        }





        if (!shift & k == 'T')
        {
            this.Demo.FrameNotVisible();
        }





        if (!shift & k == 'B')
        {
            this.Demo.Close();
        }



        return true;
    }
}