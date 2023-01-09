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

        



        this.KeyStateList = new bool[0x100];





        this.KeyInputData = new EventEvent();


        this.KeyInputData.Init();





        this.CharInputData = new EventEvent();


        this.CharInput.Init();





        this.KeyEventArg = new KeyEventArg();


        this.KeyEventArg.Init();





        this.CharEventArg = new CharEventArg();


        this.CharEventArg.Init();






        return true;
    }





    private KeyEventArg KeyEventArg { get; set; }



    private CharEventArg CharEventArg { get; set; }





    public virtual bool GetKeyState(byte key)
    {
        return this.KeyStateList[key];
    }




    public virtual bool SetKeyState(byte key, bool state)
    {
        this.KeyStateList[key] = state;




        this.KeyEventArg.Key = key;

        this.KeyEventArg.State = state;



        this.KeyInput.Trigger(this.KeyEventArg);



        return true;
    }








    public virtual bool KeyChar(char oc)
    {
        this.CharEventArg.Char = oc;



        this.CharInput.Trigger(this.CharEventArg);




        return true;
    }






    protected virtual bool[] KeyStateList { get; set; }
}