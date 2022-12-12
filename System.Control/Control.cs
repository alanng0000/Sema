namespace System.Control;



public class Control : InfraObject
{
    public static Control This { get; } = CreateGlobal();




    private static Control CreateGlobal()
    {
        Control global;


        global = new Control();


        global.Init();


        return global;
    }





    public virtual ControlEvent KeyInput
    {
        get
        {
            return this.KeyInputData;
        }
        set
        {
        }
    }



    protected ControlEvent KeyInputData { get; set; }






    public virtual ControlCharEvent CharInput
    {
        get
        {
            return this.CharInputData;
        }
        set
        {

        }
    }




    protected ControlCharEvent CharInputData { get; set; }






    public override bool Init()
    {
        base.Init();






        this.Keys = new Keys();


        this.Keys.Init();
        



        this.KeyStates = new bool[0x100];




        this.KeyInputData = new ControlEvent();


        this.KeyInputData.Init();





        this.CharInputData = new ControlCharEvent();


        this.CharInput.Init();




        return true;
    }




    public virtual bool GetKeyState(byte key)
    {
        return this.KeyStates[key];
    }




    public virtual bool SetKeyState(byte key, bool state)
    {
        this.KeyStates[key] = state;




        EventArg arg;

        arg = new EventArg();

        arg.Key = key;

        arg.State = state;



        this.KeyInput.Trigger(arg);



        return true;
    }





    public virtual bool KeyChar(char oc)
    {
        CharEventArg arg;

        arg = new CharEventArg();

        arg.Char = oc;



        this.CharInput.Trigger(arg);




        return true;
    }




    
    public Keys Keys { get; private set; }




    protected virtual bool[] KeyStates { get; set; }
}