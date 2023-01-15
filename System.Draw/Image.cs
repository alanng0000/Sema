namespace System.Draw;




public class Image : InfraObject
{
    public Stream Stream { get; set; }




    public override bool Init()
    {
        base.Init();



        this.WinBitmap = new WinBitmap(this.Stream);




        Convert convert;

        convert = Convert.This;



        this.SizeData = convert.Size(this.WinBitmap.Size);




        return true;
    }




    public Size Size
    {
        get
        {
            return this.SizeData;
        }
    }




    private Size SizeData;





    internal WinBitmap WinBitmap { get; set; }







    public bool Close()
    {
        this.WinBitmap.Dispose();


        this.WinBitmap = null;

        

        return true;
    }
}