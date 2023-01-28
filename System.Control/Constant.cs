namespace System.Control;




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





        InternConstant constant;


        constant = InternConstant.This;





        this.LetterKeyCount = constant.LetterKeyCount;



        this.DigitKeyCount = constant.DigitKeyCount;



        this.SignKeyCount = constant.SignKeyCount;



        this.ControlKeyCount = constant.ControlKeyCount;




        this.KeyCount = constant.KeyCount;
        




        this.LetterIndexEnd = constant.LetterIndexEnd;



        this.DigitIndexEnd = constant.DigitIndexEnd;





        return true;
    }
    



    public int KeyCount { get; private set; }




    public int LetterKeyCount { get; private set; }



    public int DigitKeyCount { get; private set; }



    public int SignKeyCount { get; private set; }



    public int ControlKeyCount { get; private set; }





    public int LetterIndexEnd { get; private set; }



    public int DigitIndexEnd { get; private set; }
}