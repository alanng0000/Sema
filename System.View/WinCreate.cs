namespace System.View;




class WinCreate : InfraObject
{
    public WinSize Size(Size size)
    {
        int width;

        width = size.Width;


        int height;

        height = size.Height;



        WinSize t;
        
        t = new WinSize(width, height);



        WinSize ret;

        ret = t;


        return ret;
    }



    public WinColor Color(Color color)
    {
        int alpha;

        alpha = color.Alpha;


        int red;

        red = color.Red;


        int green;

        green = color.Green;


        int blue;

        blue = color.Blue;



        WinColor t;
        
        t = WinColor.FromArgb(alpha, red, green, blue);



        WinColor ret;

        ret = t;

        
        return ret;
    }




    public WinFont Font(Font font)
    {
        WinFontFamily winFontFamily;

        winFontFamily = new WinFontFamily(font.Family);



        float winFontSize;

        winFontSize = font.Size;



        WinFontStyle winFontStyle;

        winFontStyle = this.FontStyle(font.Style);



        WinFont t;

        t = new WinFont(winFontFamily, winFontSize, winFontStyle);



        WinFont ret;

        ret = t;

        return ret;
    }



    public WinFontStyle FontStyle(FontStyle fontStyle)
    {
        WinFontStyle t;


        t = WinFontStyle.Regular;


        if (fontStyle.Bold)
        {
            t = t | WinFontStyle.Bold;
        }


        if (fontStyle.Italic)
        {
            t = t | WinFontStyle.Italic;
        }


        if (fontStyle.Underline)
        {
            t = t | WinFontStyle.Underline;
        }

        
        if (fontStyle.Strikeout)
        {
            t = t | WinFontStyle.Strikeout;
        }




        WinFontStyle ret;

        ret = t;


        return ret;
    }




    public WinPictureBoxSizeMode ImageMode(ImageMode imageMode)
    {
        WinPictureBoxSizeMode t;

        t = WinPictureBoxSizeMode.Normal;



        ImageModes imageModes;


        imageModes = ImageModes.This;



        if (imageMode == imageModes.Actual)
        {
            t = WinPictureBoxSizeMode.Normal;
        }


        if (imageMode == imageModes.Stretch)
        {
            t = WinPictureBoxSizeMode.StretchImage;
        }


        if (imageMode == imageModes.Zoom)
        {
            t = WinPictureBoxSizeMode.Zoom;
        }



        WinPictureBoxSizeMode ret;

        ret = t;

        return ret;
    }
}