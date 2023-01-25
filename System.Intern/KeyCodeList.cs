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

        count = 0x100;



        this.List = new int[count];






        this.AddCode(0x20, ' ', ' ');


        this.AddCode(0xc0, '`', '~');


        this.AddCode(0xbd, '-', '_');


        this.AddCode(0xbb, '=', '+');


        this.AddCode(0xdb, '[', '{');


        this.AddCode(0xdd, ']', '}');


        this.AddCode(0xba, ';', ':');


        this.AddCode(0xde, '\'', '"');


        this.AddCode(0xbc, ',', '<');


        this.AddCode(0xbe, '.', '>');


        this.AddCode(0xbf, '/', '?');


        this.AddCode(0xdc, '\\', '|');





        this.AddCode(0x0d);





        this.AddCode(0x09);





        this.AddCode(0x10);





        this.AddCode(0x11);
        




        this.AddCode(0x08);





        this.AddCode(0x14);
    }





    private bool AddCode(byte code)
    {
        this.List[code] = this.Index;



        this.Index = this.Index + 1;


        return true;
    }





    public int Count
    {
        get
        {
            return this.List.Length;
        }
    }




    private int[] List { get; set; }




    private int Index { get; set; }
}