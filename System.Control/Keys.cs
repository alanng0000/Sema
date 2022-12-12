namespace System.Control;



public class Keys : InfraObject
{
    public byte Enter { get; private set; }





    public byte Tab { get; private set; }





    public byte Shift { get; private set; }





    public byte Control { get; private set; }





    public byte Backspace { get; private set; }







    public override bool Init()
    {
        base.Init();






        this.IsKeyArray = new bool[0x100];







        this.Code = 0x0d;



        this.Enter = this.AddCode();






        this.Code = 0x09;



        this.Tab = this.AddCode();






        this.Code = 0x10;



        this.Shift = this.AddCode();





        this.Code = 0x11;



        this.Control = this.AddCode();
        






        this.Code = 0x08;



        this.Backspace = this.AddCode();







        return true;
    }







    private byte AddCode()
    {
        int k;

        k = this.Code;



        byte o;

        o = (byte)k;


        

        this.Code = this.Code + 1;





        this.IsKeyArray[o] = true;



    
    
        byte ret;

        ret = o;

        return ret;
    }






    public bool IsKey(byte o)
    {
        return this.IsKeyArray[o];
    }






    private bool[] IsKeyArray { get; set; }
    




    private int Code { get; set; }
}