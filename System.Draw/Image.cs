namespace System.Draw;




public class Image : InfraObject
{
    public Stream Stream { get; set; }




    public override bool Init()
    {
        base.Init();



        this.ComStream = new ComStream();


        this.ComStream.Stream = this.Stream;


        this.ComStream.Init();

        



        Convert convert;

        convert = Convert.This;



        this.SizeData = convert.Size(this.WinBitmap.Size);




        return true;
    }




    private ComStream ComStream { get; set; }





    public Size Size
    {
        get
        {
            return this.SizeData;
        }
    }




    private Size SizeData;





    internal ulong Intern { get; set; }






    public virtual bool Final()
    {
        

        return true;
    }
}