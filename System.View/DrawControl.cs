namespace System.View;




class DrawControl : WinControl
{
    public Draw Draw { get; set; }




    public bool Init()
    {
        this.DoubleBuffered = true;




        this.Text = "";


        this.BackColor = WinColor.White;


        this.ForeColor = WinColor.Transparent;


        this.Margin = new WinPadding(0);


        this.Padding = new WinPadding(0);


        this.Location = new WinPoint(0, 0);

        


        return true;
    }




    protected override void OnPaint(WinPaintEventArgs e)
    {
        this.Draw.SetGraphicsDefault(e.Graphics);




        this.Draw.LocalOps(e.Graphics, e.ClipRectangle);
    }
}