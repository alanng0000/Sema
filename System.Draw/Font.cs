namespace System.Draw;





public class Font : InfraObject
{
    public override bool Init()
    {
        base.Init();




        InfraConvert infraConvert;


        infraConvert = InfraConvert.This;





        ulong family;


        family = this.Family.Intern;


        


        int end;

        end = 100;


        if (!(this.Size < end))
        {
            this.Size = end - 1;
        }





        ulong size;

        size = infraConvert.ULong(this.Size);




        Convert convert;

        convert = Convert.This;




        ulong style;


        style = convert.InternFontStyle(this.Style);





        ulong oo;


        oo = DrawExtern.Draw_Font_New();



        DrawExtern.Draw_Font_SetFamily(oo, family);


        DrawExtern.Draw_Font_SetSize(oo, size);


        DrawExtern.Draw_Font_SetStyle(oo, style);



        DrawExtern.Draw_Font_Init(oo);




        this.Intern = oo;




        return true;
    }






    public virtual bool Final()
    {
        DrawExtern.Draw_Font_Final(this.Intern);



        DrawExtern.Draw_Font_Delete(this.Intern);


        

        return true;
    }

    




    public FontFamily Family { get; set; }




    public int Size { get; set; }




    public FontStyle Style { get; set; }





    internal ulong Intern { get; set; }
}
