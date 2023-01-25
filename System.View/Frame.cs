namespace System.View;



public class Frame : CompObject
{
    public override bool Init()
    {
        base.Init();
        



    
        InfraConvert infraConvert;


        infraConvert = InfraConvert.This;



        ulong length;

        length = infraConvert.ULong(this.Title.Length);




        ulong oss;

        oss = InfraExtern.New(length);




        this.InternTitleData = oss;





        InternIntern intern;


        intern = InternIntern.This;



        intern.CopyString(this.Title, this.InternTitleData);




        ulong ss;


        ss = InfraExtern.String_New();


        InfraExtern.String_Init(ss);



        InfraExtern.String_SetLength(ss, length);


        InfraExtern.String_SetData(ss, oss);




        this.InternTitle = ss;





        Delegate dda;

        dda = new FrameControlHandleMethod(this.ControlHandle);



        this.ControlHandleMethod = dda;




        Delegate ddb;

        ddb = new FrameDrawHandleMethod(this.DrawHandle);



        this.DrawHandleMethod = ddb;





        ulong controlHandle;

        controlHandle = intern.MethodPointer(this.ControlHandleMethod);




        ulong drawHandle;

        drawHandle = intern.MethodPointer(this.DrawHandleMethod);







        ulong frame;


        frame = InfraExtern.Frame_New();



        InfraExtern.Frame_SetTitle(frame, this.InternTitle);




        InfraExtern.Frame_Init(frame);





        ulong video;

        video = InfraExtern.Frame_GetHandle(frame);



        ulong sizeU;

        sizeU = InfraExtern.Frame_GetSize(frame);




        DrawConvert drawConvert;


        drawConvert = DrawConvert.This;




        DrawSize size;


        size = drawConvert.Size(sizeU);




        DrawDraw draw;


        draw = new DrawDraw();



        draw.Video = video;



        draw.Size = size;



        draw.Init();





        this.Draw = draw;





        InfraExtern.Frame_SetControlHandle(frame, controlHandle);




        InfraExtern.Frame_SetDrawHandle(frame, drawHandle);





        this.Intern = frame;






        this.Size = this.Draw.Size;






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






        return true;
    }





    public virtual bool Final()
    {
        this.Draw.Final();
        




        InfraExtern.Frame_Final(this.Intern);



        InfraExtern.Frame_Delete(this.Intern);





        InfraExtern.String_Final(this.InternTitle);



        InfraExtern.String_Delete(this.InternTitle);




        InfraExtern.Delete(this.InternTitleData);



        return true;
    }







    public virtual string Title { get; set; }





    public ControlControl Control { get; set; }






    private ulong Intern { get; set; }




    private ulong InternTitle { get; set; }




    private ulong InternTitleData { get; set; }





    private DrawDraw Draw { get; set; }









    private SystemDelegate ControlHandleMethod { get; set; }




    private SystemDelegate DrawHandleMethod { get; set; }
    




    private ulong DrawHandle(ulong arg)
    {
        this.ExecuteDraw();




        InternIntern intern;

        intern = InternIntern.This;



        ulong ret;
        
        ret = intern.InternBool(true);

        return ret;
    }





    private ulong ControlHandle(ulong frame, ulong key, ulong value)
    {
        InfraConvert convert;

        convert = InfraConvert.This;



        InternIntern intern;

        intern = InternIntern.This;




        byte ko;

        ko = convert.Byte(key);



        bool vo;

        vo = intern.Bool(value);




        ControlKey u;

        u = this.Control.Key.CodeGet(ko);




        int index;

        index = u.Index;



        bool state;

        state = vo;



        this.Control.Set(index, state);






        ulong ret;
        
        ret = intern.InternBool(true);

        return ret;
    }







    public DrawSize Size
    {
        get; private set;
    }







    protected virtual bool ExecuteDraw()
    {
        DrawConstant constant;


        constant = DrawConstant.This;




        this.Draw.Clear(constant.WhiteColor);






        this.Draw.Pos = this.Pos;



        this.Draw.Area = this.Area;


        this.Draw.Clip();


        



        View view;


        view = this.View;



        

        if (this.Null(view))
        {
            return true;
        }






        view.Draw(this.Draw);






        this.Draw.Result();





        return true;
    }






    private DrawPos Pos;




    private DrawRect Area;






    public virtual bool Execute()
    {
        InfraExtern.Frame_Execute(this.Intern);




        return true;
    }






    public virtual bool Update()
    {
        InfraExtern.Frame_Update(this.Intern);



        return true;
    }






    public virtual bool Visible
    {
        get
        {
            return this.GetVisible();
        }
        set
        {
            this.SetVisible(value);
        }
    }





    private bool GetVisible()
    {
        ulong o;


        o = InfraExtern.Frame_GetVisible(this.Intern);




        InternIntern intern;


        intern = InternIntern.This;




        bool b;


        b = intern.Bool(o);



        
        bool ret;

        ret = b;


        return ret;
    }





    private bool SetVisible(bool value)
    {
        InternIntern intern;


        intern = InternIntern.This;



        ulong o;


        o = intern.InternBool(value);



        InfraExtern.Frame_SetVisible(this.Intern, o);



        return true;
    }





    public virtual bool Close()
    {
        InfraExtern.Frame_Close(this.Intern);



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