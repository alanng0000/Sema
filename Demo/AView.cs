namespace Demo;




class AView : View
{
    public override bool Init()
    {
        base.Init();








        ColorBrush blueBrush;

        blueBrush = new ColorBrush();

        blueBrush.Color.Alpha = Constant.This.ColorCompMax;

        blueBrush.Color.Blue = Constant.This.ColorCompMax;

        blueBrush.Init();






        this.Pos.Left = 100;

        this.Pos.Up = 100;

        this.Size.Width = 800;

        this.Size.Height = 600;


        this.Back = blueBrush;





        ColorBrush transparentBrush;

        transparentBrush = new ColorBrush();

        transparentBrush.Color = Constant.This.TransparentColor;

        transparentBrush.Init();




        ColorBrush greenBrush;

        greenBrush = new ColorBrush();

        greenBrush.Color.Alpha = Constant.This.ColorCompMax;

        greenBrush.Color.Green = Constant.This.ColorCompMax;

        greenBrush.Init();




        ColorBrush redBrush;

        redBrush = new ColorBrush();

        redBrush.Color.Alpha = Constant.This.ColorCompMax;

        redBrush.Color.Red = Constant.This.ColorCompMax;

        redBrush.Init();






        ColorBrush yellowBrush;

        yellowBrush = new ColorBrush();

        yellowBrush.Color.Alpha = Constant.This.ColorCompMax;

        yellowBrush.Color.Red = Constant.This.ColorCompMax;

        yellowBrush.Color.Green = Constant.This.ColorCompMax;

        yellowBrush.Init();






        View viewA;

        viewA = new View();

        viewA.Init();

        viewA.Size.Width = 500;

        viewA.Size.Height = 400;

        viewA.Back = greenBrush;






        Text text;

        text = new Text();

        text.Init();

        text.Pos.Left = 50;

        text.Pos.Up = 100;

        text.Size.Width = 400;

        text.Size.Height = 100;


        text.Back = redBrush;



        text.Dest.Pos.Left = 40;

        text.Dest.Pos.Up = 30;

        text.Dest.Size.Width = 500;

        text.Dest.Size.Height = 20;




        string s;

        s = "AAABBB HHHH KKKKOOOOOOOMMMMMMMMMMM";



        text.Value.Span.String = s;


        text.Value.Span.Range.End = s.Length;



        FontStyle fontStyle;

        fontStyle = new FontStyle();

        fontStyle.Init();

        fontStyle.Underline = true;




        Font font;

        font = new Font();

        font.Family = "Cascadia Mono";

        font.Size = 30;

        font.Style = fontStyle;


        font.Init();



        text.Font = font;





        View uView;


        uView = new View();


        uView.Init();


        uView.Size.Width = 500;


        uView.Size.Height = 100;


        uView.Back = redBrush;






        Grid grid;


        grid = new Grid();


        grid.Init();


        grid.Size.Width = 500;


        grid.Size.Height = 500;


        grid.Back = yellowBrush;




        GridRow rowA;

        rowA = new GridRow();

        rowA.Init();


        rowA.Height = 400;




        GridRow rowB;

        rowB = new GridRow();

        rowB.Init();


        rowB.Height = 100;




        GridCol colA;

        colA = new GridCol();

        colA.Init();


        colA.Width = 200;
        



        GridCol colB;

        colB = new GridCol();

        colB.Init();


        colB.Width = 600;




        grid.Rows.Add(rowA);


        grid.Rows.Add(rowB);



        grid.Cols.Add(colA);


        grid.Cols.Add(colB);







        GridChild childA;

        childA = new GridChild();

        childA.Init();

        childA.View = text;

        childA.Range.End.Row = 1;

        childA.Range.End.Col = 1;




        GridChild childB;

        childB = new GridChild();

        childB.Init();

        childB.View = viewA;

        childB.Range.Start.Col = 1;

        childB.Range.End.Row = 1;

        childB.Range.End.Col = 2;




        GridChild childC;

        childC = new GridChild();

        childC.Init();

        childC.View = uView;

        childC.Range.Start.Row = 1;

        childC.Range.End.Row = 2;

        childC.Range.End.Col = 2;




        grid.Childs.Add(childA);


        grid.Childs.Add(childB);


        grid.Childs.Add(childC);
        





        this.Child = grid;





        this.Grid = grid;




        this.Text = text;




        
        this.ColA = colA;






        return true;
    }




    public Grid Grid { get; set; }




    public Text Text { get; set; }




    public GridCol ColA { get; set; }
}