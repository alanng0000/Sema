namespace Sema.Comp;





public class Field : InfraObject
{
    public virtual Object Object { get; set; }





    public FieldHandle Handle { get; set; }






    public override bool Init()
    {
        base.Init();




        this.Handle = new FieldHandle();



        this.Handle.Init();



        this.Handle.Field = this;







        this.SetChangeArg = new Change();



        this.SetChangeArg.Init();





        return true;
    }






    protected Object Value { get; set; }





    public Object Get()
    {
        return this.Value;
    }





    public bool Set(Object value)
    {
        if (!this.Null(this.Value))
        {
            this.Value.Changed.Handle.RemoveHandle(this.Handle);
        }




        this.Value = value;




        if (!this.Null(this.Value))
        {
            this.Value.Changed.Handle.AddHandle(this.Handle);
        }





        this.SetChange();




        return true;
    }






    protected bool BoolValue { get; set; }




    public bool GetBool()
    {
        return this.BoolValue;
    }




    public bool SetBool(bool value)
    {
        this.BoolValue = value;





        this.SetChange();





        return true;
    }







    protected int IntValue { get; set; }




    public int GetInt()
    {
        return this.IntValue;
    }




    public bool SetInt(int value)
    {
        if (value < 0)
        {
            value = 0;
        }
        



        this.IntValue = value;





        this.SetChange();





        return true;
    }








    protected string StringValue { get; set; }




    public string GetString()
    {
        return this.StringValue;
    }




    public bool SetString(string value)
    {
        this.StringValue = value;





        this.SetChange();





        return true;
    }








    protected int AxisIntValue { get; set; }




    public int GetAxisInt()
    {
        return this.AxisIntValue;
    }




    public bool SetAxisInt(int value)
    {
        this.AxisIntValue = value;





        this.SetChange();





        return true;
    }
    







    protected float FloatValue { get; set; } = 0;




    public float GetFloat()
    {
        return this.FloatValue;
    }




    public bool SetFloat(float value)
    {
        this.FloatValue = value;





        this.SetChange();





        return true;
    }





    protected object ObjectValue { get; set; }




    public object GetObject()
    {
        return this.ObjectValue;
    }





    public bool SetObject(object value)
    {
        this.ObjectValue = value;





        this.SetChange();





        return true;
    }






    public virtual bool Change(Change change)
    {
        this.Object.Change(this, change);



        return true;
    }






    protected bool SetChange()
    {
        this.Change(this.SetChangeArg);


        return true;
    }





    private Change SetChangeArg { get; set; }






    private bool Null(object o)
    {
        return ObjectInfra.This.Null(o);
    }
}