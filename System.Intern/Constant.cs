namespace Sema.Intern;




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



        this.ControlKeyCount = 5;





        this.CharKeyCount = this.LetterKeyCount + this.DigitKeyCount + this.SignKeyCount;




        this.KeyCount = this.CharKeyCount + this.ControlKeyCount;
        




        this.LetterIndexEnd = this.LetterKeyCount;



        this.DigitIndexEnd = this.LetterIndexEnd + this.DigitKeyCount;

        



        return true;
    }
    
    



    public int KeyCount { get; private set; }




    public int LetterKeyCount { get; private set; }



    public int DigitKeyCount { get; private set; }



    public int SignKeyCount { get; private set; }



    public int ControlKeyCount { get; private set; }




    public int CharKeyCount { get; private set; }





    public int LetterIndexEnd { get; private set; }



    public int DigitIndexEnd { get; private set; }
}