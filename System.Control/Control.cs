namespace System.Control;



public class Control : InfraObject
{
    public static Control This { get; } = CreateGlobal();




    private static Control CreateGlobal()
    {
        Control global;


        global = new Control();


        global.Init();


        return global;
    }





    public virtual EventEvent Input
    {
        get
        {
            return this.InputData;
        }
        set
        {
        }
    }



    protected EventEvent InputData { get; set; }







    public override bool Init()
    {
        base.Init();

        


        int count;


        count = System.Control.KeyList.This.Count;




        this.KeyList = new bool[count];





        this.InputData = new EventEvent();


        this.InputData.Init();





        this.KeyArg = new KeyArg();


        this.KeyArg.Init();






        return true;
    }





    private KeyArg KeyArg { get; set; }






    public virtual bool Get(byte key)
    {
        return this.KeyList[key];
    }





    public virtual bool Set(byte key, bool state)
    {
        this.KeyList[key] = state;




        this.KeyArg.Key = key;


        this.KeyArg.State = state;




        this.Input.Trigger(this.KeyArg);



        return true;
    }






    protected virtual bool[] KeyList { get; set; }
}