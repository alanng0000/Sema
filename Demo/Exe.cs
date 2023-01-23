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





        ulong frame;


        frame = InfraExtern.Frame_New();



        InfraExtern.Frame_SetTitle(frame, ss);




        InfraExtern.Frame_Init(frame);




        InfraExtern.Frame_SetVisible(frame, 1);




        InfraExtern.Frame_Execute(frame);




        InfraExtern.Frame_Final(frame);



        InfraExtern.Frame_Delete(frame);





        InfraExtern.String_Final(ss);



        InfraExtern.String_Delete(ss);




        InfraExtern.Delete(oss);



        return 0;
    }
}