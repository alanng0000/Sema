namespace Sema.View;



public class Frame : CompObject
{
    public override bool Init()
    {
        base.Init();
        



        string title;

        title = this.Title;




        FrameControlHandleMethod controlHandleMethod;

        controlHandleMethod = new FrameControlHandleMethod(this.ControlHandle);



        FrameDrawHandleMethod drawHandleMethod;

        drawHandleMethod = new FrameDrawHandleMethod(this.DrawHandle);





    
        InfraConvert infraConvert;


        infraConvert = InfraConvert.This;




        ulong length;

        length = infraConvert.ULong(title.Length);




        ulong oss;

        oss = InfraExtern.New(length);





        InternIntern intern;


        intern = InternIntern.This;



        intern.CopyString(title, oss);




        ulong ss;


        ss = InfraExtern.String_New();


        InfraExtern.String_Init(ss);



        InfraExtern.String_SetLength(ss, length);


        InfraExtern.String_SetData(ss, oss);






        Delegate controlDelegate;

        controlDelegate = controlHandleMethod;





        Delegate drawDelegate;

        drawDelegate = drawHandleMethod;





        ulong controlHandle;

        controlHandle = intern.MethodPointer(controlDelegate);




        ulong drawHandle;

        drawHandle = intern.MethodPointer(drawDelegate);






        ulong frame;


        frame = InfraExtern.Frame_New();



        InfraExtern.Frame_SetTitle(frame, ss);




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





        InfraExtern.Frame_SetControlHandle(frame, controlHandle);




        InfraExtern.Frame_SetDrawHandle(frame, drawHandle);





        
        this.InternTitleData = oss;



        this.InternTitle = ss;



        this.Intern = frame;




        this.ControlDelegate = controlDelegate;



        this.DrawDelegate = drawDelegate;





        this.Size = size;




        this.DrawOp = draw;






        DrawInfra infra;

        infra = DrawInfra.This;



        this.Pos = infra.CreatePos(0, 0);




        this.Area = infra.CreateRect(this.Pos, this.Size);







        this.ViewField = new Field();


        this.ViewField.Object = this;


        this.ViewField.Init();






        return true;
    }





    public virtual bool Final()
    {
        this.DrawOp.Final();
        




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





    private DrawDraw DrawOp { get; set; }







    private Delegate ControlDelegate { get; set; }




    private Delegate DrawDelegate { get; set; }
    





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




        byte code;

        code = ko;



        bool state;

        state = vo;




        KeyCodeList keyCodeList;

        keyCodeList = KeyCodeList.This;


        

        int? u;

        u = keyCodeList.Index(code);



        if (u.HasValue)
        {
            int index;

            index = u.Value;



            this.ControlChange(index, state);
        }





        ulong ret;
        
        ret = intern.InternBool(true);

        return ret;
    }





    protected virtual bool ControlChange(int index, bool state)
    {
        this.Control.Set(index, state);


        return true;
    }





    public DrawSize Size
    {
        get; private set;
    }







    private bool ExecuteDraw()
    {
        DrawConstant constant;


        constant = DrawConstant.This;




        this.DrawOp.Clear(constant.WhiteColor);






        this.DrawOp.Pos = this.Pos;



        this.DrawOp.Area = this.Area;


        this.DrawOp.Clip();


        



        this.Draw(this.DrawOp);






        this.DrawOp.Result();





        return true;
    }





    protected virtual bool Draw(DrawDraw draw)
    {
        View view;


        view = this.View;



        

        if (this.Null(view))
        {
            return true;
        }





        view.Draw(draw);




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