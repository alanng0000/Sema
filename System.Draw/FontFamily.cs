namespace System.Draw;





public class FontFamily : InfraObject
{
    public override bool Init()
    {
        base.Init();




        this.InitInternName();






        this.WinFontFamily = new WinFontFamily(this.Name);



        return true;
    }




    private bool InitInternName()
    {
        InfraConvert convert;

        convert = InfraConvert.This;



        ulong length;

        length = convert.ULong(this.Name.Length);



        ulong oss;

        oss = InfraExtern.New(length);




        InternIntern ooo;

        ooo = InternIntern.This;


        ooo.CopyString(this.Name, oss);




        ulong ss;


        ss = InfraExtern.String_New();


        InfraExtern.String_Init(ss);



        InfraExtern.String_SetLength(ss, length);


        InfraExtern.String_SetData(ss, oss);



        this.InternName = ss;



        return true;
    }




    private bool InitInternFamily()
    {
        ulong oo;

        oo = DrawExtern.Draw_FontFamily_New();
    


        return true;
    }


    


    public string Name { get; set; }




    private ulong InternName { get; set; }




    private ulong InternFamily { get; set; }






    public virtual bool Final()
    {





        InfraExtern.String_Final(this.InternName);



        InfraExtern.String_Delete(this.InternName);





        this.WinFontFamily.Dispose();


        this.WinFontFamily = null;

        

        return true;
    }





    internal ulong Intern { get; set; }
}