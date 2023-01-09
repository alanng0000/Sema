namespace System.Exe;




public class Exe : InfraObject
{
    public bool Execute()
    {
        this.ExecuteThread();





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







    protected virtual bool ExecuteMain()
    {
        return true;
    }

    




    private void ThreadWork()
    {
        this.ExecuteMain();
    }
}