namespace Demo;




class Exe : ExeExe
{
    static int Main()
    {
        Exe exe;

        exe = new Exe();

        exe.Init();



        // ulong draw;

        // draw = System.Internal.DrawExtern.Draw_Draw_New();


        // System.Internal.DrawExtern.Draw_Draw_Delete(draw);



        // string s;

        // s = "DEMO NOW Extern\n";



        // ulong length;

        // length = (ulong)s.Length;



        // ulong data;

        // data = InfraExtern.New(length);



        // Internal oo;

        // oo = Internal.This;


        // oo.CopyString(s, data);





        // ulong ss;
        

        // ss = InfraExtern.String_New();


        // InfraExtern.String_Init(ss);



        // InfraExtern.String_SetLength(ss, length);


        // InfraExtern.String_SetData(ss, data);




        // ulong console;

        // console = InfraExtern.Console_New();



        // InfraExtern.Console_Init(console);



        // InfraExtern.Console_Write(console, ss);



        // InfraExtern.Console_Final(console);



        // InfraExtern.Console_Delete(console);





        // InfraExtern.String_Final(ss);


        // InfraExtern.String_Delete(ss);




        // InfraExtern.Delete(data);




        int o;

        o = exe.Execute();


        return o;
    }
    




    protected override int ExecuteWork()
    {
        string title;

        title = "DEMO System Frame Infra";



        ulong length;

        length = (ulong)title.Length;




        ulong oss;

        oss = InfraExtern.New(length);




        Internal ooo;

        ooo = Internal.This;


        ooo.CopyString(title, oss);




        ulong ss;


        ss = InfraExtern.String_New();


        InfraExtern.String_Init(ss);



        InfraExtern.String_SetLength(ss, length);


        InfraExtern.String_SetData(ss, oss);




        Delegate dd;

        dd = new FrameDrawHandleMethod(DrawExtern.Draw_FrameDrawHandle);




        ulong drawHandle;

        drawHandle = ooo.MethodPointer(dd);





        ulong frame;


        frame = InfraExtern.Frame_New();



        InfraExtern.Frame_SetTitle(frame, ss);




        InfraExtern.Frame_Init(frame);





        ulong handle;

        handle = InfraExtern.Frame_GetHandle(frame);



        ulong size;

        size = InfraExtern.Frame_GetSize(frame);




        ulong draw;


        draw = DrawExtern.Draw_Draw_New();




        DrawExtern.Draw_Draw_SetHandle(draw, handle);



        DrawExtern.Draw_Draw_SetSize(draw, size);




        DrawExtern.Draw_Draw_Init(draw);





        DrawDrawMethod del;

        del = new DrawDrawMethod(this.DrawExecute);



        Delegate dda;

        dda = del;



        ulong drawMethod;


        drawMethod = ooo.MethodPointer(dda);




        DrawExtern.Draw_Draw_SetMethod(draw, drawMethod);





        this.SetBrush();





        InfraExtern.Frame_SetDrawHandle(frame, drawHandle);



        InfraExtern.Frame_SetDrawHandleArg(frame, draw);




        InfraExtern.Frame_Execute(frame);







        DrawExtern.Draw_Brush_Final(this.Brush);



        DrawExtern.Draw_Brush_Delete(this.Brush);





        DrawExtern.Draw_Draw_Final(draw);




        DrawExtern.Draw_Draw_Delete(draw);







        InfraExtern.Frame_Final(frame);



        InfraExtern.Frame_Delete(frame);





        InfraExtern.String_Final(ss);



        InfraExtern.String_Delete(ss);




        InfraExtern.Delete(oss);



        return 0;
    }




    private ulong Brush { get; set; }





    private bool SetBrush()
    {
        ulong brush;


        brush = DrawExtern.Draw_Brush_New();



        DrawExtern.Draw_Brush_Init(brush);




        ulong brushU;

        brushU = DrawExtern.Draw_ColorBrush_Create();



        ulong gg;


        gg = DrawExtern.Draw_Global();



        ulong constant;

        constant = DrawExtern.Draw_Global_Constant(gg);



        ulong typeU;

        typeU = DrawExtern.Draw_Constant_ColorBrushType(constant);




        DrawExtern.Draw_Brush_SetType(brush, typeU);



        DrawExtern.Draw_Brush_SetValue(brush, brushU);




        this.Brush = brush;




        return true;
    }




    private ulong DrawExecute(ulong draw)
    {
        DrawExtern.Draw_Draw_Rect(draw, 100, 100, 400, 400, this.Brush);



        return 0;
    }
}