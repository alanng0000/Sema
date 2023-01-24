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





    public override bool Init()
    {
        base.Init();

        





        this.KeyList = new KeyList();


        this.KeyList.Init();




        this.StateList = new bool[this.KeyList.Count];





        this.InputData = new EventEvent();


        this.InputData.Init();





        this.KeyArg = new KeyArg();


        this.KeyArg.Init();






        return true;
    }





    private KeyArg KeyArg { get; set; }






    public virtual bool Get(byte index)
    {
        return this.StateList[index];
    }





    public virtual bool Set(byte index, bool state)
    {
        this.StateList[index]= state;
        
        


        Key key;

        key = this.KeyList.Get(index);




        this.KeyArg.Key = key;


        this.KeyArg.State = state;




        this.Input.Trigger(this.KeyArg);



        return true;
    }





    public KeyList Key
    {
        get
        {
            return this.KeyList;
        }
    }





    private char IntChar(int o)
    {
        return (char)o;
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




    protected virtual KeyList KeyList { get; set; }



    protected virtual bool[] StateList { get; set; }
}