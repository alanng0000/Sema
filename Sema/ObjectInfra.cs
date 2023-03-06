namespace Sema;



public class ObjectInfra : Object
{
    public static ObjectInfra This { get; } = CreateGlobal();




    private static ObjectInfra CreateGlobal()
    {
        ObjectInfra global;

        global = new ObjectInfra();

        global.Init();


        return global;
    }





    public bool Null(object o)
    {
        return o == null;
    }
}