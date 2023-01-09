namespace Demo;




class Exe : ExeExe
{
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