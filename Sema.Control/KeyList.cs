namespace Sema.Control;



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




    public Key Digit0 { get; private set; }


    public Key Digit1 { get; private set; }


    public Key Digit2 { get; private set; }


    public Key Digit3 { get; private set; }


    public Key Digit4 { get; private set; }


    public Key Digit5 { get; private set; }


    public Key Digit6 { get; private set; }


    public Key Digit7 { get; private set; }


    public Key Digit8 { get; private set; }


    public Key Digit9 { get; private set; }




    public Key Space { get; private set; }


    public Key BackTick { get; private set; }


    public Key Dash { get; private set; }


    public Key EqualSign { get; private set; }


    public Key LeftSquare { get; private set; }


    public Key RightSquare { get; private set; }


    public Key SemiColon { get; private set; }


    public Key SingleQuote { get; private set; }


    public Key Comma { get; private set; }


    public Key Dot { get; private set; }


    public Key Slash { get; private set; }


    public Key BackSlash { get; private set; }







    public Key Enter { get; private set; }




    public Key Tab { get; private set; }




    public Key Shift { get; private set; }




    public Key Control { get; private set; }




    public Key Backspace { get; private set; }




    public Key CapLock { get; private set; }







    public Key LeftUp
    {
        get
        {
            return this.LetterW;
        }
        set
        {
        }
    }



    public Key LeftDown
    {
        get
        {
            return this.LetterS;
        }
        set
        {
        }
    }




    public Key LeftLeft
    {
        get
        {
            return this.LetterA;
        }
        set
        {
        }
    }



    public Key LeftRight
    {
        get
        {
            return this.LetterD;
        }
        set
        {
        }
    }






    public Key RightUp
    {
        get
        {
            return this.LetterI;
        }
        set
        {
        }
    }



    public Key RightDown
    {
        get
        {
            return this.LetterK;
        }
        set
        {
        }
    }




    public Key RightLeft
    {
        get
        {
            return this.LetterJ;
        }
        set
        {
        }
    }



    public Key RightRight
    {
        get
        {
            return this.LetterL;
        }
        set
        {
        }
    }






    public override bool Init()
    {
        base.Init();





        InternConstant constant;


        constant = InternConstant.This;




        int count;


        count = constant.KeyCount;



        this.List = new Key[count];





        this.LetterA = this.AddLetterKey();

        this.LetterB = this.AddLetterKey();

        this.LetterC = this.AddLetterKey();

        this.LetterD = this.AddLetterKey();

        this.LetterE = this.AddLetterKey();

        this.LetterF = this.AddLetterKey();

        this.LetterG = this.AddLetterKey();

        this.LetterH = this.AddLetterKey();

        this.LetterI = this.AddLetterKey();

        this.LetterJ = this.AddLetterKey();

        this.LetterK = this.AddLetterKey();

        this.LetterL = this.AddLetterKey();

        this.LetterM = this.AddLetterKey();

        this.LetterN = this.AddLetterKey();

        this.LetterO = this.AddLetterKey();

        this.LetterP = this.AddLetterKey();

        this.LetterQ = this.AddLetterKey();

        this.LetterR = this.AddLetterKey();

        this.LetterS = this.AddLetterKey();

        this.LetterT = this.AddLetterKey();

        this.LetterU = this.AddLetterKey();

        this.LetterV = this.AddLetterKey();

        this.LetterW = this.AddLetterKey();

        this.LetterX = this.AddLetterKey();

        this.LetterY = this.AddLetterKey();

        this.LetterZ = this.AddLetterKey();




        this.Digit0 = this.AddDigitKey(')');

        this.Digit1 = this.AddDigitKey('!');

        this.Digit2 = this.AddDigitKey('@');

        this.Digit3 = this.AddDigitKey('#');

        this.Digit4 = this.AddDigitKey('$');

        this.Digit5 = this.AddDigitKey('%');

        this.Digit6 = this.AddDigitKey('^');

        this.Digit7 = this.AddDigitKey('&');

        this.Digit8 = this.AddDigitKey('*');

        this.Digit9 = this.AddDigitKey('(');
        




        this.Space = this.AddSignKey(' ', ' ');


        this.BackTick = this.AddSignKey('`', '~');


        this.Dash = this.AddSignKey('-', '_');


        this.EqualSign = this.AddSignKey('=', '+');


        this.LeftSquare = this.AddSignKey('[', '{');


        this.RightSquare = this.AddSignKey(']', '}');


        this.SemiColon = this.AddSignKey(';', ':');


        this.SingleQuote = this.AddSignKey('\'', '"');


        this.Comma = this.AddSignKey(',', '<');


        this.Dot = this.AddSignKey('.', '>');


        this.Slash = this.AddSignKey('/', '?');


        this.BackSlash = this.AddSignKey('\\', '|');





        this.Enter = this.AddKey();





        this.Tab = this.AddKey();





        this.Shift = this.AddKey();





        this.Control = this.AddKey();
        




        this.Backspace = this.AddKey();
        






        return true;
    }







    private Key AddLetterKey()
    {
        Key key;

        key = this.AddKey();



        KeyChar oo;

        oo = new KeyChar();

        oo.Init();




        int u;

        u = this.LetterIndex + 'a';


        int v;

        v = this.LetterIndex + 'A';




        char defaultChar;

        defaultChar = (char)u;



        char shiftChar;

        shiftChar = (char)v;



        oo.Default = defaultChar;

        oo.Shift = shiftChar;



        key.Char = oo;



        this.LetterIndex = this.LetterIndex + 1;




        Key ret;

        ret = key;

        return ret;
    }





    private Key AddDigitKey(char shiftChar)
    {
        Key key;

        key = this.AddKey();



        KeyChar oo;

        oo = new KeyChar();

        oo.Init();



        int u;

        u = this.DigitIndex + '0';



        char defaultChar;

        defaultChar = (char)u;



        oo.Default = defaultChar;

        oo.Shift = shiftChar;




        key.Char = oo;




        this.DigitIndex = this.DigitIndex + 1;




        Key ret;

        ret = key;

        return ret;
    }





    private Key AddSignKey(char defaultChar, char shiftChar)
    {
        Key key;

        key = this.AddKey();



        KeyChar oo;

        oo = new KeyChar();

        oo.Init();



        oo.Default = defaultChar;

        oo.Shift = shiftChar;




        key.Char = oo;




        Key ret;

        ret = key;

        return ret;
    }






    private int LetterIndex { get; set; }




    private int DigitIndex { get; set; }





    private Key AddKey()
    {
        Key key;

        key = new Key();

        key.Init();

        key.Index = this.Index;




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
        InternConstant constant;

        constant = InternConstant.This;



        return !(index < 0) & index < constant.LetterIndexEnd;
    }





    public bool IsDigitKey(int index)
    {
        InternConstant constant;

        constant = InternConstant.This;



        return !(index < constant.LetterIndexEnd) & index < constant.DigitIndexEnd;
    }





    public Key LetterKey(int letterIndex)
    {
        int cc;
        
        cc = 0;


        return this.IndexKey(letterIndex, cc);
    }





    public Key DigitKey(int digitIndex)
    {
        InternConstant constant;

        constant = InternConstant.This;



        int cc;
        
        cc = constant.LetterIndexEnd;


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







    public int Count
    {
        get
        {
            return this.List.Length;
        }
        set
        {
        }
    }







    private Key[] List { get; set; }




    private int Index { get; set; }
}