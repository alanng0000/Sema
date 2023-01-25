namespace System.Intern;





public class KeyCodeList : InfraObject
{
    public static KeyCodeList This { get; } = CreateGlobal();




    private static KeyCodeList CreateGlobal()
    {
        KeyCodeList global;

        global = new KeyCodeList();

        global.Init();


        return global;
    }




    public override bool Init()
    {
        base.Init();




        int count;

        count = this.CodeCount;



        this.List = new int[count];




        Constant constant;

        constant = Constant.This;



        InfraConvert convert;


        convert = InfraConvert.This;




        int letterCount;

        letterCount = constant.LetterKeyCount;



        byte startCode;

        startCode = convert.CharByte('A');



        this.AddCodeRange(letterCount, startCode);




        int digitCount;

        digitCount = constant.DigitKeyCount;



        startCode = convert.CharByte('0');



        this.AddCodeRange(digitCount, startCode);





        this.AddCode(0x20);


        this.AddCode(0xc0);


        this.AddCode(0xbd);


        this.AddCode(0xbb);


        this.AddCode(0xdb);


        this.AddCode(0xdd);


        this.AddCode(0xba);


        this.AddCode(0xde);


        this.AddCode(0xbc);


        this.AddCode(0xbe);


        this.AddCode(0xbf);


        this.AddCode(0xdc);





        this.AddCode(0x0d);





        this.AddCode(0x09);





        this.AddCode(0x10);





        this.AddCode(0x11);
        




        this.AddCode(0x08);





        this.AddCode(0x14);





        this.KeyCount = this.CurrentIndex;

        



        return true;
    }






    public int Index(byte code)
    {
        return this.List[code];
    }






    private bool AddCodeRange(int count, byte startCode)
    {
        int u;


        byte ob;


        int i;

        i = 0;


        while (i < count)
        {
            u = startCode + i;


            ob = (byte)u;



            this.AddCode(ob);



            i = i + 1;
        }


        return true;
    }




    private bool AddCode(byte code)
    {
        this.List[code] = this.CurrentIndex;



        this.CurrentIndex = this.CurrentIndex + 1;


        return true;
    }




    private int CodeCount
    {
        get
        {
            return 0x100;
        }
    }




    public int Count
    {
        get
        {
            return this.List.Length;
        }
    }




    public int KeyCount
    {
        get; private set;
    }




    private int[] List { get; set; }




    private int CurrentIndex { get; set; }
}