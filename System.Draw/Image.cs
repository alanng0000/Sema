namespace System.Draw;




public class Image : InfraObject
{
    public Stream Stream { get; set; }


    public ulong StreamSize { get; set; }




    public override bool Init()
    {
        base.Init();






        ulong buffer;


        buffer = InfraExtern.New(this.StreamSize);




        InternIntern intern;


        intern = InternIntern.This;



        intern.ReadStream(this.Stream, buffer, this.StreamSize);





        ulong data;


        data = InfraExtern.Data_New();



        InfraExtern.Data_Init(data);



        InfraExtern.Data_SetSize(data, this.StreamSize);



        InfraExtern.Data_SetValue(data, buffer);








        ulong o;


        o = DrawExtern.Draw_Image_New();



        DrawExtern.Draw_Image_SetData(o, data);



        DrawExtern.Draw_Image_Init(o);




        this.Intern = o;



        this.InternData = data;



        this.InternDataValue = buffer;





        ulong sizeU;

        sizeU = DrawExtern.Draw_Image_GetSize(this.Intern);




        Convert convert;

        convert = Convert.This;



        this.SizeData = convert.Size(sizeU);




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





    internal ulong Intern { get; set; }



    private ulong InternData { get; set; }


    
    private ulong InternDataValue { get; set; }






    public virtual bool Final()
    {
        DrawExtern.Draw_Image_Final(this.Intern);



        DrawExtern.Draw_Image_Delete(this.Intern);




        InfraExtern.Data_Final(this.InternData);



        InfraExtern.Data_Delete(this.InternData);




        InfraExtern.Delete(this.InternDataValue);



        return true;
    }
}