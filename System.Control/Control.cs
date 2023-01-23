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


        count = System.Control.KeyList.This.Count;




        this.KeyList = new bool[count];





        this.InputData = new EventEvent();


        this.InputData.Init();





        this.KeyArg = new KeyArg();


        this.KeyArg.Init();






        return true;
    }





    private KeyArg KeyArg { get; set; }






    public virtual bool Get(byte key)
    {
        return this.KeyList[key];
    }





    public virtual bool Set(byte key, bool state)
    {
        this.KeyList[key] = state;




        this.KeyArg.Key = key;


        this.KeyArg.State = state;




        this.Input.Trigger(this.KeyArg);



        return true;
    }





    public KeyChar Char(byte key)
    {
        return this.KeyCharList[key];
    }





    private char IntChar(int o)
    {
        return (char)o;
    }




    public bool IsLetterKey(byte key)
    {
        return 'A' <= key && key <= 'Z';
    }



    public bool IsDigitKey(byte key)
    {
        return '0' <= key && key <= '9';
    }




    public int LetterIndex(byte key)
    {
        return this.KeyIndex(key, 'A');
    }



    public int DigitIndex(byte key)
    {
        return this.KeyIndex(key, '0');
    }




    private int KeyIndex(byte key, int start)
    {
        int k;


        k = key;


        k = k - start;



        int ret;


        ret = k;


        return ret;
    }




    public byte LetterKey(int index)
    {
        int cc;
        
        cc = 'A';


        return this.IndexKey(index, cc);
    }





    public byte DigitKey(int index)
    {
        int cc;
        
        cc = '0';


        return this.IndexKey(index, cc);
    }






    private byte IndexKey(int index, int start)
    {
        int k;

        k = start + index;



        byte o;

        o = (byte)k;




        byte ret;

        ret = o;


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




    protected virtual bool[] KeyList { get; set; }




    private KeyChar[] KeyCharList { get; set; }
}