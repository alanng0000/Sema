namespace Demo;




class Exe : ExeExe
{
    static int Main()
    {
        Exe exe;

        exe = new Exe();

        exe.Init();




        int o;

        o = exe.Execute();


        return o;
    }
    




    protected override int ExecuteWork()
    {
        Demo demo;


        demo = new Demo();


        demo.Init();



        int o;

        o = demo.Execute();


        return o;
    }
}