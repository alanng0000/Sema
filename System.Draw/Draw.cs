namespace System.Draw;




public class Draw : InfraObject
{
    public override bool Init()
    {
        base.Init();





        return true;
    }




    public ulong Buffer { get; set; }




    public uint BufferStride { get; set; }





    public Size Size;



    

    public bool Rect(Brush brush, Rect rect)
    {
        if (brush is ColorBrush)
        {
            ColorBrush colorBrush;


            colorBrush = (ColorBrush)brush;



            this.ColorRect(colorBrush, rect);
        }



        return true;
    }





    private bool ColorRect(ColorBrush brush, Rect rect)
    {
        uint color;


        color = this.ColorInt(ref brush.Color);



        ulong bufferPointer;

        bufferPointer = this.Buffer;

        uint bufferStride;

        bufferStride = this.BufferStride;


        return true;
    }







    public bool Text(char[] charList, InfraRange range, Font font, Color color, Pos pos)
    {
        



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
