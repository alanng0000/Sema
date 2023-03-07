namespace Sema.Mode;




public class Mode : InfraObject
{
    public Ref Ref { get; set; }



    public ListArray Case { get; set; }



    public ListArray Import { get; set; }



    public ListArray Export { get; set; }



    public ListArray Base { get; set; }



    public ListArray Member { get; set; }

    

    public ListArray State { get; set; }
}