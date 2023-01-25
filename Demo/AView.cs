namespace Demo;




class AView : View
{
    public override bool Init()
    {
        base.Init();



        DrawConstant constant;

        constant = DrawConstant.This;



        DrawInfra infra;

        infra = DrawInfra.This;




        ColorBrush blueBrush;

        blueBrush = new ColorBrush();

        blueBrush.Init();

        blueBrush.Color = infra.CreateColor(constant.ColorCompMax, 0, 0, constant.ColorCompMax);





        this.Pos.Left = 100;

        this.Pos.Up = 100;

        this.Size.Width = 800;

        this.Size.Height = 600;


        this.Back = blueBrush;





        ColorBrush transparentBrush;

        transparentBrush = new ColorBrush();

        transparentBrush.Init();

        transparentBrush.Color = constant.TransparentColor;




        ColorBrush greenBrush;

        greenBrush = new ColorBrush();

        greenBrush.Init();

        greenBrush.Color = infra.CreateColor(constant.ColorCompMax, 0, constant.ColorCompMax, 0);




        ColorBrush redBrush;

        redBrush = new ColorBrush();

        redBrush.Init();

        redBrush.Color = infra.CreateColor(constant.ColorCompMax, constant.ColorCompMax, 0, 0);






        ColorBrush yellowBrush;

        yellowBrush = new ColorBrush();

        yellowBrush.Init();

        yellowBrush.Color = infra.CreateColor(constant.ColorCompMax, constant.ColorCompMax, constant.ColorCompMax, 0);






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

        text.Dest.Size.Height = 80;




        string s;

        s = "AAABBB HHHH KKKKOOOOOOOMMMMMMMMMMM";



        text.Value.Span.String = s;


        text.Value.Span.Range.Start = 3;


        text.Value.Span.Range.End = s.Length;





        FontFamily fontFamily;

        fontFamily = new FontFamily();

        fontFamily.Name = "Cascadia Mono";

        fontFamily.Init();





        FontStyle fontStyle;

        fontStyle = new FontStyle();

        fontStyle.Init();

        fontStyle.Underline = true;




        Font font;

        font = new Font();

        font.Family = fontFamily;

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




        string imageFileName;

        imageFileName = "sun_and_cloud.img";




        Stream stream;

        stream = new FileStream(imageFileName, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);



        ulong streamSize;

        streamSize = (ulong)stream.Length;



        DrawImage drawImage;

        drawImage = new DrawImage();

        drawImage.Stream = stream;

        drawImage.StreamSize = streamSize;

        drawImage.Init();



        stream.Dispose();






        Image image;

        image = new Image();

        image.Init();


        image.Value = drawImage;


        image.Size.Width = 500;

        image.Size.Height = 100;


        image.Dest.Size.Width = 500;

        image.Dest.Size.Height = 100;



        image.Source.Pos.Left = 1900;

        image.Source.Pos.Up = 1000;


        image.Source.Size.Width = 500;

        image.Source.Size.Height = 100;







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




        grid.Row.Add(rowA);


        grid.Row.Add(rowB);



        grid.Col.Add(colA);


        grid.Col.Add(colB);







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




        grid.Child.Add(childA);


        grid.Child.Add(childB);


        grid.Child.Add(childC);





        uView.Child = image;





        this.Child = grid;





        this.Grid = grid;




        this.Text = text;




        this.Image = image;




        
        this.ColA = colA;





        this.FontFamily = fontFamily;


        this.Font = font;




        this.DrawImage = drawImage;



        
        this.BlueBrush = blueBrush;


        this.GreenBrush = greenBrush;


        this.RedBrush = redBrush;


        this.TransparentBrush = transparentBrush;


        this.YellowBrush = yellowBrush;





        return true;
    }




    public Grid Grid { get; set; }




    public Text Text { get; set; }




    public Image Image { get; set; }





    public GridCol ColA { get; set; }





    private ColorBrush BlueBrush { get; set; }


    private ColorBrush TransparentBrush { get; set; }


    private ColorBrush GreenBrush { get; set; }


    private ColorBrush RedBrush { get; set; }


    private ColorBrush YellowBrush { get; set; }




    private DrawImage DrawImage { get; set; }




    private FontFamily FontFamily { get; set; }



    private Font Font { get; set; }





    public virtual bool Final()
    {
        this.DrawImage.Final();




        this.Font.Final();



        this.FontFamily.Final();





        this.BlueBrush.Final();


        this.GreenBrush.Final();


        this.RedBrush.Final();


        this.TransparentBrush.Final();


        this.YellowBrush.Final();




        return true;
    }
}