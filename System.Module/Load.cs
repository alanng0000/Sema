namespace System.Module;




public class Load : InfraObject
{
    public override bool Init()
    {
        base.Init();



        
        this.InitRootPath();




        return true;
    }





    private bool InitRootPath()
    {
        string s;


        s = File.ReadAllText(this.PathFileName);



        this.RootPath = s;



        return true;
    }






    private string RootPath { get; set; }




    private string PathFileName
    {
        get
        {
            return "Path.txt";
        }
        set
        {
        }
    }




    private string DataFileName
    {
        get
        {
            return "_";
        }
        set
        {
        }
    }




    public string ModuleName { get; set; }



    public ulong ModuleVer { get; set; }




    public InfraData Result { get; set; }




    public bool Execute()
    {
        string modulePath;

        modulePath = this.ModulePath();





        return true;
    }





    private string ModulePath()
    {
        string u;

        u = this.ModuleVer.ToString();




        string s;


        s = Path.Combine(this.RootPath, this.ModuleName, u);


        s = Path.Combine(s, this.DataFileName);




        string ret;

        ret = s;


        return ret;
    }
}