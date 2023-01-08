namespace System.Draw;




public class Draw : InfraObject
{
    public override bool Init()
    {
        base.Init();



        Pos pos;

        pos = new Pos();

        pos.Init();




        this.Area = new Rect();


        this.Area.Init();


        this.Area.Pos = pos;


        this.Area.Size = this.Size;
        




        return true;
    }





    public ulong Buffer { get; set; }




    public uint BufferStride { get; set; }





    public Size Size;




    private Rect Area;



    

    public bool Rect(Brush brush, Rect rect)
    {
        this.BoundArea(ref this.Area, ref rect);




        if (brush is ColorBrush)
        {
            ColorBrush colorBrush;


            colorBrush = (ColorBrush)brush;



            this.ColorRect(ref colorBrush.Color, ref rect);
        }



        return true;
    }





    private bool ColorRect(ref Color color, ref Rect rect)
    {
        Color c;


        c = color;




        bool isOpaque;

        isOpaque = false;




        if (c.Alpha == byte.MaxValue)
        {
            isOpaque = true;
        }



        if (isOpaque)
        {
            c.Alpha = 0;
        }



        
        




        uint colorInt;


        colorInt = this.ColorInt(ref c);




        ulong bufferPointer;

        bufferPointer = this.Buffer;


        uint bufferStride;

        bufferStride = this.BufferStride;



        uint rectRow;

        rectRow = this.UInt(rect.Pos.Up);


        uint rectCol;

        rectCol = this.UInt(rect.Pos.Left);


        uint rectWidth;

        rectWidth = this.UInt(rect.Size.Width);


        uint rectHeight;

        rectHeight = this.UInt(rect.Size.Height);





        DrawColorMethod method;


        method = Extern.Draw_Method_Color;




        if (isOpaque)
        {
            method = Extern.Draw_Method_OpaqueColor;
        }





        method(bufferPointer, bufferStride, rectRow, rectCol, rectWidth, rectHeight, colorInt);





        return true;
    }






    delegate void DrawColorMethod(ulong bufferPointer, uint bufferStride, uint rectRow, uint rectCol, uint rectWidth, uint rectHeight, uint color);





    public bool Text(byte[] charList, InfraRange range, Font font, Color color, Pos pos)
    {
        



        return true;
    }








    private uint UInt(int a)
    {
        return (uint)a;
    }






    private bool BoundArea(ref Rect bound, ref Rect area)
    {
        int left;

        left = area.Pos.Left;



        int up;

        up = area.Pos.Up;




        int width;

        width = area.Size.Width;



        int height;

        height = area.Size.Height;




        int right;

        right = left + width;



        int down;

        down = up + height;





        int boundRight;

        boundRight = bound.Pos.Left + bound.Size.Width;



        int boundDown;

        boundDown = bound.Pos.Up + bound.Size.Height;





        if (left < bound.Pos.Left)
        {
            left = bound.Pos.Left;
        }



        if (up < bound.Pos.Up)
        {
            up = bound.Pos.Up;
        }





        if (boundRight < right)
        {
            right = boundRight;
        }



        if (boundDown < down)
        {
            down = boundDown;
        }






        int w;


        w = IntOp.This.Sub(right, left);





        int h;


        h = IntOp.This.Sub(down, up);





        area.Pos.Left = left;


        area.Pos.Up = up;


        area.Size.Width = w;


        area.Size.Height = h;




        return true;
    }






    private uint ColorInt(ref Color color)
    {
        int i;

        i = 0;



        uint k;


        k = 0;



        k = k | this.ColorIntComp(color.Blue, i);


        i = i + 1;


        k = k | this.ColorIntComp(color.Green, i);


        i = i + 1;


        k = k | this.ColorIntComp(color.Red, i);


        i = i + 1;


        k = k | this.ColorIntComp(color.Alpha, i);





        uint ret;

        ret = k;


        return ret;
    }




    private int BitPerByte { get { return 8; } }




    private uint ColorIntComp(byte comp, int index)
    {
        int o;

        o = this.BitPerByte;



        uint k;

        k = comp;

        k = k << (index * o);



        uint ret;

        ret = k;


        return ret;
    }
}
