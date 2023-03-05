namespace System.Infra;



public class Convert : Object
{
    public static Convert This { get; } = CreateGlobal();




    private static Convert CreateGlobal()
    {
        Convert global;


        global = new Convert();


        global.Init();



        return global;
    }







    public ulong ULong(int a)
    {
        return (ulong)a;
    }




    public int SInt32(ulong a)
    {
        return (int)a;
    }




    public byte Byte(ulong a)
    {
        return (byte)a;
    }




    public byte CharByte(char a)
    {
        return (byte)a;
    }




    public char ByteChar(byte a)
    {
        return (char)a;
    }
}