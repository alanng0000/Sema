namespace System.Control;



public class KeyList : InfraObject
{
    public static KeyList This { get; } = CreateGlobal();




    private static KeyList CreateGlobal()
    {
        KeyList global;

        global = new KeyList();

        global.Init();


        return global;
    }




    public Key LetterA { get; private set; }


    public Key LetterB { get; private set; }


    public Key LetterC { get; private set; }


    public Key LetterD { get; private set; }


    public Key LetterE { get; private set; }


    public Key LetterF { get; private set; }


    public Key LetterG { get; private set; }


    public Key LetterH { get; private set; }


    public Key LetterI { get; private set; }


    public Key LetterJ { get; private set; }


    public Key LetterK { get; private set; }


    public Key LetterL { get; private set; }


    public Key LetterM { get; private set; }


    public Key LetterN { get; private set; }


    public Key LetterO { get; private set; }


    public Key LetterP { get; private set; }


    public Key LetterQ { get; private set; }


    public Key LetterR { get; private set; }


    public Key LetterS { get; private set; }


    public Key LetterT { get; private set; }


    public Key LetterU { get; private set; }


    public Key LetterV { get; private set; }


    public Key LetterW { get; private set; }


    public Key LetterX { get; private set; }


    public Key LetterY { get; private set; }


    public Key LetterZ { get; private set; }











    public Key Enter { get; private set; }




    public Key Tab { get; private set; }




    public Key Shift { get; private set; }




    public Key Control { get; private set; }




    public Key Backspace { get; private set; }









    public override bool Init()
    {
        base.Init();



        int count;


        count = 26 + 10 + 5;




        this.List = new Key[count];





        this.LetterA = this.AddKey(this.CharByte('A'));

        this.LetterB = this.AddKey(this.CharByte('B'));

        this.LetterC = this.AddKey(this.CharByte('C'));

        this.LetterD = this.AddKey(this.CharByte('D'));

        this.LetterE = this.AddKey(this.CharByte('E'));

        this.LetterF = this.AddKey(this.CharByte('F'));

        this.LetterG = this.AddKey(this.CharByte('G'));

        this.LetterH = this.AddKey(this.CharByte('H'));

        this.LetterI = this.AddKey(this.CharByte('I'));

        this.LetterJ = this.AddKey(this.CharByte('J'));

        this.LetterK = this.AddKey(this.CharByte('K'));

        this.LetterL = this.AddKey(this.CharByte('L'));

        this.LetterM = this.AddKey(this.CharByte('M'));

        this.LetterN = this.AddKey(this.CharByte('N'));

        this.LetterO = this.AddKey(this.CharByte('O'));

        this.LetterP = this.AddKey(this.CharByte('P'));

        this.LetterQ = this.AddKey(this.CharByte('Q'));

        this.LetterR = this.AddKey(this.CharByte('R'));

        this.LetterS = this.AddKey(this.CharByte('S'));

        this.LetterT = this.AddKey(this.CharByte('T'));

        this.LetterU = this.AddKey(this.CharByte('U'));

        this.LetterV = this.AddKey(this.CharByte('V'));

        this.LetterW = this.AddKey(this.CharByte('W'));

        this.LetterX = this.AddKey(this.CharByte('X'));

        this.LetterY = this.AddKey(this.CharByte('Y'));

        this.LetterZ = this.AddKey(this.CharByte('Z'));




        this.Enter = this.AddKey(0x0d);






        this.Tab = this.AddKey(0x09);





        this.Shift = this.AddKey(0x10);





        this.Control = this.AddKey(0x11);
        




        this.Backspace = this.AddKey(0x08);





        this.InitCodeList();





        return true;
    }





    private bool InitCodeList()
    {
        this.CodeList = new Key[this.List.Length];



        int count;

        count = this.List.Length;



        int i;

        i = 0;

        while (i < count)
        {
            Key key;


            key = this.List[i];



            this.CodeList[key.Code] = key;



            i = i + 1;
        }


        return true;
    }




    private Key AddKey(byte code)
    {
        Key key;

        key = new Key();

        key.Init();

        key.Index = this.Index;

        key.Code = code;




        this.List[key.Index] = key;
        



        this.Index = this.Index + 1;
        


    
    
        Key ret;

        ret = key;

        return ret;
    }






    public Key Get(int index)
    {
        return this.List[index];
    }





    public bool IsLetterKey(int index)
    {
        return 0 <= index && index <= 25;
    }



    public bool IsDigitKey(int index)
    {
        return 26 <= index && index <= 35;
    }




    public Key LetterKey(int letterIndex)
    {
        int cc;
        
        cc = 0;


        return this.IndexKey(letterIndex, cc);
    }





    public Key DigitKey(int digitIndex)
    {
        int cc;
        
        cc = 26;


        return this.IndexKey(digitIndex, cc);
    }






    private Key IndexKey(int index, int start)
    {
        int k;

        k = start + index;




        Key key;

        key = this.Get(k);




        Key ret;

        ret = key;


        return ret;
    }





    private byte CharByte(char o)
    {
        InfraConvert convert;

        convert = InfraConvert.This;


        return convert.CharByte(o);
    }





    public int Count
    {
        get
        {
            return this.List.Length;
        }
    }






    private Key[] List { get; set; }



    private Key[] CodeList { get; set; }




    private int Index { get; set; }
}