namespace System.Module;




public class VerInfra : InfraObject
{
    public Ver GetCurrentVer(Int intent)
    {
        string u;
        
        u = this.VerPath(intent);




        string s;


        s = File.ReadAllText(u);




        ulong? uu;

        uu = this.StringVerValue(s);


        if (!uu.HasValue)
        {
            return null;
        }
      



        ulong value;

        value = uu.Value;





        Ver a;

        a = new Ver();

        a.Init();

        a.Value = value;



        Ver ret;

        ret = a;

        return ret;
    }




    private ulong? StringVerValue(string s)
    {
        ulong o;



        bool b;

        b = ulong.TryParse(s, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out o);



        if (!b)
        {
            return null;
        }



        ulong ret;

        ret = o;

        return ret;
    }





    private string VerPath(Int intent)
    {
        Convert convert;

        convert = Convert.This;




        ulong o;

        o = intent.Value;




        string u;

        u = convert.Int60BitListString(o);




        

        Path modulePath;


        modulePath = Path.This;





        string s;


        s = SystemPath.Combine(modulePath.Root, u);


        s = SystemPath.Combine(s, this.VerFileName);




        string ret;

        ret = s;


        return ret;
    }




    private string VerFileName
    {
        get
        {
            return "_";
        }
    }
}