namespace Sema.Mode;




public class VerInfra : InfraObject
{
    public Ver GetCurrentVer(Int varInt)
    {
        Path path;

        path = Path.This;



        string u;
        

        u = path.ModeInt(varInt);


        u = SystemPath.Combine(u, path.VerName);




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
}