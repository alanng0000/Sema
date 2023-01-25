namespace System.Intern;




public class Constant : InfraObject
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




        this.LetterKeyCount = 26;



        this.DigitKeyCount = 10;




        return true;
    }




    public int LetterKeyCount
    {
        get;
        private set;
    }



    public int DigitKeyCount
    {
        get;
        private set;
    }
}