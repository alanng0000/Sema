namespace Demo;




class Handle : EventHandle
{
    public Demo Demo { get; set; }



    public override bool Execute(object arg)
    {
        CharEventArg o;

        o = (CharEventArg)arg;



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
        




        if (c == 'b')
        {
            this.Demo.Close();
        }



        return true;
    }
}