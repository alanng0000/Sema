namespace Demo;




class Handle : EventHandle
{
    public Demo Demo { get; set; }



    public override bool Execute(object arg)
    {
        CharEventArg o;

        o = (CharEventArg)arg;



        if (o.Char == 'a')
        {
            this.Demo.Aa();
        }



        return true;
    }
}