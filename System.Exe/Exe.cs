namespace System.Exe;




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
        this.ExecuteThread();




        int ret;

        ret = this.Result;


        return ret;
    }




    private bool InitDllFoldPath()
    {
        EnvironmentSpecialFolder fold;

        fold = EnvironmentSpecialFolder.UserProfile;




        string s;
        

        s = SystemEnvironment.GetFolderPath(fold);



        s = Path.Combine(s, "Project", "Out");




        Extern.SetDllDirectoryW(s);




        return true;
    }






    private bool ExecuteThread()
    {
        Thread thread;


        thread = new Thread(this.ThreadWork);




        bool b;


        b = thread.TrySetApartmentState(ApartmentState.STA);


        if (!b)
        {
            return false;
        }




        thread.Start();



        thread.Join();


        
        return true;
    }





    private int Result { get; set; }





    protected virtual int ExecuteWork()
    {
        return 0;
    }

    




    private void ThreadWork()
    {
        int o;


        o = this.ExecuteWork();



        this.Result = o;
    }
}