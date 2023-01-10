namespace System.Control;



public class Key : InfraObject
{
    public static Key This { get; } = CreateGlobal();




    private static Key CreateGlobal()
    {
        Key global;

        global = new Key();

        global.Init();


        return global;
    }






    public byte Left { get; private set; }




    public byte Up { get; private set; }




    public byte Right { get; private set; }




    public byte Down { get; private set; }




    public byte Space { get; private set; }





    public byte Enter { get; private set; }





    public byte Tab { get; private set; }





    public byte Shift { get; private set; }





    public byte Control { get; private set; }





    public byte Home { get; private set; }





    public byte End { get; private set; }





    public byte PageUp { get; private set; }




    public byte PageDown { get; private set; }





    public byte Backspace { get; private set; }





    public byte LeftSquare { get; private set; }




    public byte RightSquare { get; private set; }




    public byte Semicolon { get; private set; }




    public byte SingleQuote { get; private set; }




    public byte EqualSign { get; private set; }




    public byte Dash { get; private set; }




    public byte Comma { get; private set; }




    public byte Dot { get; private set; }




    public byte Slash { get; private set; }




    public byte BackSlash { get; private set; }




    public byte BackTick { get; private set; }







    public override bool Init()
    {
        base.Init();










        this.Code = 0x25;



        this.Left = this.AddCode();


        this.Up = this.AddCode();


        this.Right = this.AddCode();


        this.Down = this.AddCode();



        



        this.Code = 0x20;



        this.Space = this.AddCode();






        this.Code = 0x0d;



        this.Enter = this.AddCode();






        this.Code = 0x09;



        this.Tab = this.AddCode();






        this.Code = 0x10;



        this.Shift = this.AddCode();





        this.Code = 0x11;



        this.Control = this.AddCode();
        







        this.Code = 0x24;



        this.Home = this.AddCode();





        this.Code = 0x23;



        this.End = this.AddCode();






        this.Code = 0x21;



        this.PageUp = this.AddCode();





        this.Code = 0x22;



        this.PageDown = this.AddCode();






        this.Code = 0x08;



        this.Backspace = this.AddCode();






        this.Code = 0xdb;



        this.LeftSquare = this.AddCode();





        this.Code = 0xdd;
    


        this.RightSquare = this.AddCode();






        this.Code = 0xba;



        this.Semicolon = this.AddCode();






        this.Code = 0xde;



        this.SingleQuote = this.AddCode();
        




        this.Code = 0xbb;


        this.EqualSign = this.AddCode();





        this.Code = 0xbd;


        this.Dash = this.AddCode();





        this.Code = 0xbc;


        this.Comma = this.AddCode();





        this.Code = 0xbe;


        this.Dot = this.AddCode();





        this.Code = 0xbf;


        this.Slash = this.AddCode();





        this.Code = 0xdc;


        this.BackSlash = this.AddCode();





        this.Code = 0xc0;



        this.BackTick = this.AddCode();





        return true;
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






    private byte AddCode()
    {
        int k;

        k = this.Code;



        byte o;

        o = (byte)k;


        

        this.Code = this.Code + 1;


    
    
        byte ret;

        ret = o;

        return ret;
    }








    private int Code { get; set; }
}