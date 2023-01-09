namespace System.View;




public class ImageModeList : InfraObject
{
    public static ImageModeList This { get; } = CreateGlobal();




    private static ImageModeList CreateGlobal()
    {
        ImageModeList global;

        global = new ImageModeList();

        global.Init();


        return global;
    }






    private ImageMode ActualData { get; set; }



    private ImageMode StretchData { get; set; }



    private ImageMode ZoomData { get; set; }





    public override bool Init()
    {
        base.Init();



        this.ActualData = this.CreateMode();


        this.StretchData = this.CreateMode();


        this.ZoomData = this.CreateMode();



        return true;
    }




    private ImageMode CreateMode()
    {
        ImageMode mode;


        mode = new ImageMode();


        mode.Init();



        ImageMode ret;


        ret = mode;


        return ret;
    }




    public ImageMode Actual
    {
        get
        {
            return this.ActualData;
        }
        set
        {
        }
    }



    public ImageMode Stretch
    {
        get
        {
            return this.StretchData;
        }
        set
        {
        }
    }



    public ImageMode Zoom
    {
        get
        {
            return this.ZoomData;
        }
        set
        {
        }
    }
}