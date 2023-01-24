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










    public Key Enter { get; private set; }




    public Key Tab { get; private set; }




    public Key Shift { get; private set; }




    public Key Control { get; private set; }




    public Key Backspace { get; private set; }









    public override bool Init()
    {
        base.Init();






        this.Code = 0x0d;



        this.Enter = this.AddKey();






        this.Code = 0x09;



        this.Tab = this.AddKey();






        this.Code = 0x10;



        this.Shift = this.AddKey();





        this.Code = 0x11;



        this.Control = this.AddKey();
        





        this.Code = 0x08;



        this.Backspace = this.AddKey();






        return true;
    }







    private Key AddKey()
    {
        int k;

        k = this.Code;



        byte o;

        o = (byte)k;


        

        this.Code = this.Code + 1;




        Key key;

        key = new Key();

        key.Init();

        key.Index = o;


    
    
        Key ret;

        ret = key;

        return ret;
    }








    private int Code { get; set; }
}