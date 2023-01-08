namespace System.Exe;




public class Exe : InfraObject
{
    public int Execute()
    {
        this.ExecuteThread();



        int ret;

        ret = this.Result;


        return ret;
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
        Extern.Draw_Method_Init();




        int o;

        o = this.ExecuteWork();




        this.Result = o;
    }
}