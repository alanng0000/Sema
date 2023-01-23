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
        // Demo demo;


        // demo = new Demo();


        // demo.Init();



        // int o;


        // o = demo.Execute();


        // return o;


        return 0;
    }
}