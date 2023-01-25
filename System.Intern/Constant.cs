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



        this.SignKeyCount = 12;



        this.ControlKeyCount = 6;






        this.LetterIndexEnd = this.LetterKeyCount;



        this.DigitIndexEnd = this.LetterIndexEnd + this.DigitKeyCount;





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



    public int SignKeyCount
    {
        get;
        private set;
    }



    public int ControlKeyCount
    {
        get;
        private set;
    }





    public int LetterIndexEnd { get; private set; }



    public int DigitIndexEnd { get; private set; }

}