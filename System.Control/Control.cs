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





    public override bool Init()
    {
        base.Init();

        


        int count;


        count = 0x100;




        this.KeyList = new Key[count];



        this.StateList = new bool[count];





        this.InputData = new EventEvent();


        this.InputData.Init();





        this.KeyArg = new KeyArg();


        this.KeyArg.Init();






        return true;
    }





    private KeyArg KeyArg { get; set; }






    public virtual bool Get(byte index)
    {
        return this.StateList[index];
    }





    public virtual bool Set(byte index, bool state)
    {
        this.StateList[index]= state;
        
        


        Key key;

        key = this.KeyList[index];




        this.KeyArg.Key = key;


        this.KeyArg.State = state;




        this.Input.Trigger(this.KeyArg);



        return true;
    }





    public Key Key(byte index)
    {
        return this.KeyList[index];
    }





    private char IntChar(int o)
    {
        return (char)o;
    }




    public bool IsLetterKey(byte index)
    {
        return 'A' <= index && index <= 'Z';
    }



    public bool IsDigitKey(byte index)
    {
        return '0' <= index && index <= '9';
    }




    public Key LetterKey(int letterIndex)
    {
        int cc;
        
        cc = 'A';


        return this.IndexKey(letterIndex, cc);
    }





    public Key DigitKey(int digitIndex)
    {
        int cc;
        
        cc = '0';


        return this.IndexKey(digitIndex, cc);
    }






    private Key IndexKey(int index, int start)
    {
        int k;

        k = start + index;



        byte o;

        o = (byte)k;




        Key key;

        key = this.Key(o);




        Key ret;

        ret = key;


        return ret;
    }






    public virtual EventEvent Input
    {
        get
        {
            return this.InputData;
        }
        set
        {
        }
    }



    protected EventEvent InputData { get; set; }




    protected virtual KeyList KeyList { get; set; }



    protected virtual bool[] StateList { get; set; }
}