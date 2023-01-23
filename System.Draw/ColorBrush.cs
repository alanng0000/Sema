namespace System.Draw;





public class ColorBrush : Brush
{
    public Color Color;




    public override bool Init()
    {
        base.Init();



        Convert convert;

        convert = Convert.This;




        ulong internColor;


        internColor = convert.InternColor(this.Color);




        ulong o;


        o = DrawExtern.Draw_Brush_New();


        DrawExtern.Draw_Brush_Init(o);




        ulong gg;

        gg = DrawExtern.Draw_Global();



        ulong cc;

        cc = DrawExtern.Draw_Global_Constant(gg);



        ulong type;

        type = DrawExtern.Draw_Constant_ColorBrushType(cc);




        ulong cuBrush;

        cuBrush = DrawExtern.Draw_ColorBrush_Create();




        DrawExtern.Draw_Brush_SetType(o, type);


        DrawExtern.Draw_Brush_SetValue(o, cuBrush);



        DrawExtern.Draw_ColorBrush_SetColor(o, internColor);




        this.Intern = o;




        return true;
    }





    public override bool Final()
    {
        DrawExtern.Draw_Brush_Final(this.Intern);



        DrawExtern.Draw_Brush_Delete(this.Intern);





        base.Final();




        return true;
    }
}