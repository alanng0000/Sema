namespace Demo;




class Handle : EventHandle
{
    public Demo Demo { get; set; }



    public override bool Execute(object arg)
    {
        KeyArg o;

        o = (KeyArg)arg;



        byte k;

        k = o.Key;





        KeyList keyList;

        keyList = KeyList.This;



        bool shift;

        shift = this.Demo.Control.Get(keyList.Shift);




        if (!shift & k == 'W')
        {
            this.Demo.GridMoveUp();
        }


        if (!shift & k == 'S')
        {
            this.Demo.GridMoveDown();
        }


        if (!shift & k == 'A')
        {
            this.Demo.GridMoveLeft();
        }


        if (!shift & k == 'D')
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