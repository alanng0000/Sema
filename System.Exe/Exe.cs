namespace System.Exe;




public class Exe : InfraObject
{
    public int Execute()
    {
        Extern.Infra_Form_Init();



        int o;

        o = this.ExecuteWork();




        Extern.Infra_Form_Final();
        



        int ret;

        ret = o;

        return ret;
    }







    protected virtual int ExecuteWork()
    {
        return 0;
    }
}