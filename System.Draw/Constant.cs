namespace System.Draw;



class Constant : InfraObject
{
    public static Constant This { get; } = CreateGlobal();




    private static Constant CreateGlobal()
    {
        Constant global;

        global = new Constant();

        global.Init();


        return global;
    }






    public override bool Init()
    {
        base.Init();



        this.InitTextFormatFlag();



        return true;
    }





    public WinTextFormatFlags TextFormatFlag { get; private set; }








    private bool InitTextFormatFlag()
    {
        this.TextFormatFlag = 
        
        WinTextFormatFlags.Left | 
        WinTextFormatFlags.Top | 
        WinTextFormatFlags.NoPadding |
        WinTextFormatFlags.NoPrefix;


        return true;
    }
}