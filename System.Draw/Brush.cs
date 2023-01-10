namespace System.Draw;




public class Brush : InfraObject
{
    internal WinBrush WinBrush { get; set; }



    public bool Close()
    {
        this.WinBrush.Dispose();


        this.WinBrush = null;

        

        return true;
    }
}