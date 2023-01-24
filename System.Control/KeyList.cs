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


        count = 0x100;




        this.List = new Key[count];







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





        this.Index = this.Index + 1;
        


    
    
        Key ret;

        ret = key;

        return ret;
    }






    public Key Get(int index)
    {
        return this.List[index];
    }







    public bool IsLetterKey(byte index)
    {
        return 0 <= index && index <= 25;
    }



    public bool IsDigitKey(byte index)
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