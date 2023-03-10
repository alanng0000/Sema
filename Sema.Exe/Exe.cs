namespace Sema.Exe;




public class Exe : InfraObject
{
    public override bool Init()
    {
        base.Init();



        this.InitDllFoldPath();



        return true;
    }





    public int Execute()
    {
        InfraExtern.Infra_Form_Init();



        DrawExtern.Draw_Init();





        this.Result = this.ExecuteWork();





        DrawExtern.Draw_Final();



        InfraExtern.Infra_Form_Final();




        int ret;

        ret = this.Result;


        return ret;
    }




    private bool InitDllFoldPath()
    {
        EnvironmentSpecialFolder fold;

        fold = EnvironmentSpecialFolder.UserProfile;




        string s;
        

        s = Environment.GetFolderPath(fold);



        s = Path.Combine(s, "Out");




        this.AddPathToEnvironment(s);



        return true;
    }





    private bool AddPathToEnvironment(string path)
    {
        string s;
        

        s = Environment.GetEnvironmentVariable("PATH");


        if (s == null)
        {
            s = "";
        }


        s = s + ";" + path;



        Environment.SetEnvironmentVariable("PATH", s);



        return true;
    }





    private int Result { get; set; }





    protected virtual int ExecuteWork()
    {
        return 0;
    }
}