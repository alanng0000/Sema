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
            this.Demo.MoveUp();
        }


        if (c == 's')
        {
            this.Demo.MoveDown();
        }


        if (c == 'a')
        {
            this.Demo.MoveLeft();
        }


        if (c == 'd')
        {
            this.Demo.MoveRight();
        }



        return true;
    }
}