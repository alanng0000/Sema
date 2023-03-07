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






    protected Object Valu { get; set; }





    public Object Get()
    {
        return this.Valu;
    }





    public bool Set(Object valu)
    {
        if (!this.Null(this.Valu))
        {
            this.Valu.Changed.Handle.RemoveHandle(this.Handle);
        }




        this.Valu = valu;




        if (!this.Null(this.Valu))
        {
            this.Valu.Changed.Handle.AddHandle(this.Handle);
        }





        this.SetChange();




        return true;
    }






    protected bool BoolValu { get; set; }




    public bool GetBool()
    {
        return this.BoolValu;
    }




    public bool SetBool(bool valu)
    {
        this.BoolValu = valu;





        this.SetChange();





        return true;
    }







    protected int IntValu { get; set; }




    public int GetInt()
    {
        return this.IntValu;
    }




    public bool SetInt(int valu)
    {
        if (valu < 0)
        {
            valu = 0;
        }
        



        this.IntValu = valu;





        this.SetChange();





        return true;
    }








    protected string StringValu { get; set; }




    public string GetString()
    {
        return this.StringValu;
    }




    public bool SetString(string valu)
    {
        this.StringValu = valu;





        this.SetChange();





        return true;
    }








    protected int AxisIntValu { get; set; }




    public int GetAxisInt()
    {
        return this.AxisIntValu;
    }




    public bool SetAxisInt(int valu)
    {
        this.AxisIntValu = valu;





        this.SetChange();





        return true;
    }
    







    protected float FloatValu { get; set; } = 0;




    public float GetFloat()
    {
        return this.FloatValu;
    }




    public bool SetFloat(float valu)
    {
        this.FloatValu = valu;





        this.SetChange();





        return true;
    }





    protected object ObjectValu { get; set; }




    public object GetObject()
    {
        return this.ObjectValu;
    }





    public bool SetObject(object valu)
    {
        this.ObjectValu = valu;





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
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}