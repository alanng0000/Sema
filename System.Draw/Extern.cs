namespace System.Draw;






static class Extern
{
    const string Dll = "Draw.dll";





    [DllImport(Dll)]
    public static extern void Draw_Method_Color(ulong bufferPointer, uint bufferStride, uint rectRow, uint rectCol, uint rectWidth, uint rectHeight, uint color);
}