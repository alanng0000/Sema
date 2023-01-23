namespace System.View;



public class Frame : CompObject
{
    public override bool Init()
    {
        base.Init();
        



    



        ulong length;

        length = (ulong)title.Length;




        ulong oss;

        oss = InfraExtern.New(length);




        Intern ooo;

        ooo = Intern.This;


        ooo.CopyString(title, oss);




        ulong ss;


        ss = InfraExtern.String_New();


        InfraExtern.String_Init(ss);



        InfraExtern.String_SetLength(ss, length);


        InfraExtern.String_SetData(ss, oss);





        Delegate dda;

        dda = new FrameKeyHandleMethod(this.KeyHandle);




        Delegate ddb;

        ddb = new FrameDrawHandleMethod(DrawExtern.Draw_FrameDrawHandle);




        ulong keyHandle;

        keyHandle = ooo.MethodPointer(dda);




        ulong drawHandle;

        drawHandle = ooo.MethodPointer(ddb);






        this.Size = convert.Size(rect.Size);







        this.Pos = new DrawPos();


        this.Pos.Init();


        this.Pos.Left = 0;


        this.Pos.Up = 0;





        this.Area = new DrawRect();


        this.Area.Init();



        this.Area.Pos = this.Pos;



        this.Area.Size.Width = this.Size.Width;


        this.Area.Size.Height = this.Size.Height;







        this.ViewField = new Field();


        this.ViewField.Object = this;


        this.ViewField.Init();





        this.Draw = new DrawDraw();



        this.Draw.Init();




        return true;
    }








    public virtual string Title { get; set; }





    private ulong Intern { get; set; }






    public ControlControl Control { get; set; }






    public DrawSize Size
    {
        get; private set;
    }





    internal DrawDraw Draw { get; set; }








    internal bool ExecuteDraw()
    {
        this.Draw.Pos = this.Pos;



        this.Draw.Area = this.Area;


        this.Draw.SetClip();


        



        View view;


        view = this.View;



        

        if (this.Null(view))
        {
            return true;
        }






        view.Draw(this.Draw);





        return true;
    }






    private DrawPos Pos;




    private DrawRect Area;






    public virtual bool Execute()
    {
        





        return true;
    }






    public virtual bool Update()
    {
        this.Form.Invalidate();



        return true;
    }






    public virtual bool Visible
    {
        get
        {
            return this.Form.Visible;
        }
        set
        {
            this.Form.Visible = value;
        }
    }






    public virtual bool Close()
    {
        this.Form.Close();
        


        return true;
    }






    public virtual Field ViewField { get; set; }





    public virtual View View
    {
        get
        {
            return (View)this.ViewField.Get();
        }

        set
        {
            this.ViewField.Set(value);
        }
    }





    protected virtual bool ChangeView(Change change)
    {
        this.Trigger(this.ViewField);


        return true;
    }






    public override bool Change(Field field, Change change)
    {
        if (this.ViewField == field)
        {
            this.ChangeView(change);
        }



        return true;
    }







    private bool Null(object o)
    {
        ObjectInfra infra;

        infra = ObjectInfra.This;


        return infra.Null(o);
    }
}