namespace Demo;




class Exe : ExeExe
{
    protected override int ExecuteWork()
    {
        return 0;
    }





    static int Main(string[] arg)
    {
        Exe exe;

        exe = new Exe();

        exe.Init();



        int u;

        u = exe.Execute();



        int ret;

        ret = u;

        return ret;
    }
}