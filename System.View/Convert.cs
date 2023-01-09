namespace System.View;




class Convert : InfraObject
{
    public WinPictureBoxSizeMode ImageMode(ImageMode imageMode)
    {
        WinPictureBoxSizeMode t;

        t = WinPictureBoxSizeMode.Normal;



        ImageModeList imageModeList;


        imageModeList = ImageModeList.This;



        if (imageMode == imageModeList.Actual)
        {
            t = WinPictureBoxSizeMode.Normal;
        }


        if (imageMode == imageModeList.Stretch)
        {
            t = WinPictureBoxSizeMode.StretchImage;
        }


        if (imageMode == imageModeList.Zoom)
        {
            t = WinPictureBoxSizeMode.Zoom;
        }



        WinPictureBoxSizeMode ret;

        ret = t;

        return ret;
    }
}