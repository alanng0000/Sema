namespace System.View;





class FrameDrawHandle : DrawHandle
{
    public Frame Frame { get; set; }




    public override bool Execute(DrawDraw draw)
    {
        this.Frame.ExecuteDraw();



        return true;
    }
}