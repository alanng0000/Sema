namespace System.Draw;




public class Image : InfraObject
{
    public Stream Stream { get; set; }




    public override bool Init()
    {
        base.Init();





        InternIntern intern;

        intern = InternIntern.This;




        ulong u;

        u = 0;



        object ou;

        ou = intern.ImageStream(this.Stream, ref u);
        



        this.InternStream = ou;





        ulong o;


        o = DrawExtern.Draw_Image_New();



        DrawExtern.Draw_Image_SetStream(o, u);



        DrawExtern.Draw_Image_Init(o);




        this.Intern = o;





        ulong sizeU;

        sizeU = DrawExtern.Draw_Image_GetSize(this.Intern);




        Convert convert;

        convert = Convert.This;



        this.SizeData = convert.Size(sizeU);




        return true;
    }





    private object InternStream { get; set; }





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