namespace Sema.Mode;




public class Path : InfraObject
{
    public static Path This { get; } = CreateGlobal();




    private static Path CreateGlobal()
    {
        Path global;


        global = new Path();


        global.Init();



        return global;
    }


    




    public override bool Init()
    {
        EnvironmentSpecialFolder fold;

        fold = EnvironmentSpecialFolder.UserProfile;



        string s;
        

        s = SystemEnvironment.GetFolderPath(fold);



        s = SystemPath.Combine(s, "Module");



        this.RootData = s;



        return true;
    }











    public string Module(Ref varRef)
    {
        Convert convert;


        convert = Convert.This;





        string u;

        u = convert.Int60BitListString(varRef.Int.Value);




        string v;

        v = convert.Int60BitListString(varRef.Ver.Value);





        string s;


        s = SystemPath.Combine(this.Root, u, v);




        string ret;

        ret = s;


        return ret;
    }






    public string ModuleDataName
    {
        get
        {
            return "_";
        }
        set
        {
        }
    }




    public string EntryName
    {
        get
        {
            return "_";
        }
        set
        {
        }
    }




    public string Root
    {
        get
        {
            return this.RootData;
        }
        set
        {
        }
    }




    private string RootData { get; set; }
}