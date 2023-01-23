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

        



        InternIntern intern;

        intern = InternIntern.This;



        ulong ou;

        ou = intern.IStreamIUnknown(this.ComStream);
        




        ulong o;


        o = DrawExtern.Draw_Image_New();



        DrawExtern.Draw_Image_SetStream(o, ou);



        DrawExtern.Draw_Image_Init(o);




        this.Intern = o;




        ulong sizeU;

        sizeU = DrawExtern.Draw_Image_GetSize(this.Intern);




        Convert convert;

        convert = Convert.This;



        this.SizeData = convert.Size(sizeU);




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
        DrawExtern.Draw_Image_Final(this.Intern);



        DrawExtern.Draw_Image_Delete(this.Intern);
        



        return true;
    }
}