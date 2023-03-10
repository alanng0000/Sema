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
        

        s = Environment.GetFolderPath(fold);



        s = SystemPath.Combine(s, "Mode");



        this.RootData = s;



        return true;
    }











    public string Mode(Ref varRef)
    {
        Convert convert;


        convert = Convert.This;





        string u;

        u = convert.Int60BitListString(varRef.Int.Valu);




        string v;

        v = convert.Int60BitListString(varRef.Ver.Valu);





        string s;


        s = SystemPath.Combine(this.Root, u, v);




        string ret;

        ret = s;


        return ret;
    }






    public string ModeInt(Int varInt)
    {
        Convert convert;

        convert = Convert.This;




        ulong o;

        o = varInt.Valu;




        string u;

        u = convert.Int60BitListString(o);





        string s;


        s = SystemPath.Combine(this.Root, u);





        string ret;

        ret = s;


        return ret;
    }









    public string ModeDataName
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






    public string VerName
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