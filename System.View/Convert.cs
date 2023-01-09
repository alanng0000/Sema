namespace System.View;




class Convert : InfraObject
{
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