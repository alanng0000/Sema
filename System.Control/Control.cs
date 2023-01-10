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

        



        this.KeyList = new bool[0x100];





        this.KeyInputData = new EventEvent();


        this.KeyInputData.Init();





        this.CharInputData = new EventEvent();


        this.CharInput.Init();





        this.KeyArg = new KeyArg();


        this.KeyArg.Init();





        this.CharArg = new CharArg();


        this.CharArg.Init();






        return true;
    }





    private KeyArg KeyArg { get; set; }



    private CharArg CharArg { get; set; }





    public virtual bool Get(byte key)
    {
        return this.KeyList[key];
    }





    public virtual bool Set(byte key, bool state)
    {
        bool a;


        a = this.KeyList[key];



        if (a == state)
        {
            return true;
        }
        



        this.KeyList[key] = state;




        this.KeyArg.Key = key;

        this.KeyArg.State = state;




        this.KeyInput.Trigger(this.KeyArg);



        return true;
    }








    public virtual bool KeyChar(char oc)
    {
        this.CharArg.Char = oc;



        this.CharInput.Trigger(this.CharArg);




        return true;
    }






    protected virtual bool[] KeyList { get; set; }
}