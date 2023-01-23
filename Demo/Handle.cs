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




        if (k == 'w')
        {
            this.Demo.GridMoveUp();
        }


        if (k == 's')
        {
            this.Demo.GridMoveDown();
        }


        if (k == 'a')
        {
            this.Demo.GridMoveLeft();
        }


        if (k == 'd')
        {
            this.Demo.GridMoveRight();
        }




        if (!shift & k == 'i')
        {
            this.Demo.TextMoveUp();
        }


        if (!shift & k == 'k')
        {
            this.Demo.TextMoveDown();
        }


        if (!shift & k == 'j')
        {
            this.Demo.TextMoveLeft();
        }


        if (!shift & k == 'l')
        {
            this.Demo.TextMoveRight();
        }



        if (shift & k == 'i')
        {
            this.Demo.ImageSourceMoveUp();
        }


        if (shift & k == 'k')
        {
            this.Demo.ImageSourceMoveDown();
        }


        if (shift & k == 'j')
        {
            this.Demo.ImageSourceMoveLeft();
        }


        if (shift & k == 'l')
        {
            this.Demo.ImageSourceMoveRight();
        }




        if (k == 'h')
        {
            this.Demo.GridToggleVisible();
        }

        



        if (k == 'c')
        {
            this.Demo.TextWidthIncrease();
        }





        if (k == 't')
        {
            this.Demo.FrameNotVisible();
        }





        if (k == 'b')
        {
            this.Demo.Close();
        }



        return true;
    }
}