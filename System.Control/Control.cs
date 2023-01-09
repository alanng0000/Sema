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





    public virtual EventEvent KeyInput
    {
        get
        {
            return this.KeyInputData;
        }
        set
        {
        }
    }



    protected EventEvent KeyInputData { get; set; }






    public virtual EventEvent CharInput
    {
        get
        {
            return this.CharInputData;
        }
        set
        {

        }
    }




    protected EventEvent CharInputData { get; set; }






    public override bool Init()
    {
        base.Init();






        this.Keys = new Keys();


        this.Keys.Init();
        



        this.KeyStates = new bool[0x100];




        this.KeyInputData = new EventEvent();


        this.KeyInputData.Init();





        this.CharInputData = new EventEvent();


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