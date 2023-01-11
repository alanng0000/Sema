namespace Demo;




class Handle : EventHandle
{
    public Demo Demo { get; set; }



    public override bool Execute(object arg)
    {
        CharArg o;

        o = (CharArg)arg;



        char c;

        c = o.Char;



        if (c == 'w')
        {
            this.Demo.GridMoveUp();
        }


        if (c == 's')
        {
            this.Demo.GridMoveDown();
        }


        if (c == 'a')
        {
            this.Demo.GridMoveLeft();
        }


        if (c == 'd')
        {
            this.Demo.GridMoveRight();
        }




        if (c == 'i')
        {
            this.Demo.TextMoveUp();
        }


        if (c == 'k')
        {
            this.Demo.TextMoveDown();
        }


        if (c == 'j')
        {
            this.Demo.TextMoveLeft();
        }


        if (c == 'l')
        {
            this.Demo.TextMoveRight();
        }




        if (c == 'I')
        {
            this.Demo.ImageSourceMoveUp();
        }


        if (c == 'K')
        {
            this.Demo.ImageSourceMoveDown();
        }


        if (c == 'J')
        {
            this.Demo.ImageSourceMoveLeft();
        }


        if (c == 'L')
        {
            this.Demo.ImageSourceMoveRight();
        }




        



        if (c == 'c')
        {
            this.Demo.TextWidthIncrease();
        }





        if (c == 'b')
        {
            this.Demo.Close();
        }



        return true;
    }
}