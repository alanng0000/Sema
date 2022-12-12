namespace System.Compose;




public class GenericEventHandle<T> : InfraObject where T : struct
{
    private static ulong NewId { get; set; }



    private static object IdLock = new object();




    public override bool Init()
    {
        base.Init();
        



        lock (IdLock)
        {
            this.Id = NewId;



            NewId = NewId + 1;
        }

        
        return true;
    }



    private ulong Id { get; set; }




    internal ulong LocalId
    {
        get
        {
            return this.Id;
        }
    }



    public virtual bool Execute(T arg)
    {
        return true;
    }
}