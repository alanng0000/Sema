namespace System.Draw;





public class ColorBrush : Brush
{
    public override bool Init()
    {
        base.Init();




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




        this.Intern = o;




        return true;
    }





    public Color Color
    {
        get
        {
            return this.ColorData;
        }
        set
        {
            this.ColorData = value;



            this.SetColor();
        }
    }





    private Color ColorData;





    private bool SetColor()
    {        
        Convert convert;

        convert = Convert.This;



        ulong internColor;


        internColor = convert.InternColor(this.ColorData);




        DrawExtern.Draw_ColorBrush_SetColor(this.Intern, internColor);




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