namespace System.View;




public class Image : View
{
    public override bool Init()
    {
        this.WinPictureBox = new WinPictureBox();


        this.WinPictureBox.Text = "";


        this.WinPictureBox.BackColor = WinColor.Transparent;


        this.WinPictureBox.ForeColor = WinColor.Transparent;


        this.WinPictureBox.Margin = new WinPadding(0);


        this.WinPictureBox.Padding = new WinPadding(0);


        this.WinPictureBox.Location = new WinPoint(0, 0);


        this.WinPictureBox.BorderStyle = WinBorderStyle.None;


        this.WinPictureBox.SizeMode = WinPictureBoxSizeMode.Normal;




        this.ValueField = new Field();


        this.ValueField.Object = this;


        this.ValueField.Init();




        this.ModeField = new Field();


        this.ModeField.Object = this;


        this.ModeField.Init();
        



        base.Init();


        

        this.Internal.Controls.Add(this.WinPictureBox);





        this.Value = null;





        this.Mode = ImageModes.This.Actual;




        return true;
    }





    public virtual Field ValueField { get; set; }




    public virtual Stream Value
    {
        get
        {
            return (Stream)this.ValueField.GetObject();
        }

        set
        {
            this.ValueField.SetObject(value);
        }
    }





    protected virtual bool ChangeValue(Change change)
    {
        if (!this.Null(this.WinPictureBox.Image))
        {
            this.WinPictureBox.Image.Dispose();


            this.WinPictureBox.Image = null;
        }




        WinBitmap bitmap;


        bitmap = null;



        if (!this.Null(this.Value))
        {
            bitmap = new WinBitmap(this.Value);
        }



        this.WinPictureBox.Image = bitmap;
        


        this.Trigger(this.ValueField);



        return true;
    }





    public WinBitmap Bitmap
    {
        get
        {
            return (WinBitmap)this.WinPictureBox.Image;
        }
    }






    public virtual Field ModeField { get; set; }



    public virtual ImageMode Mode
    {
        get
        {
            return (ImageMode)this.ModeField.GetObject();
        }

        set
        {
            this.ModeField.SetObject(value);
        }
    }




    protected virtual bool ChangeMode(Change change)
    {
        WinPictureBoxSizeMode t;


        t = this.WinCreate.ImageMode(this.Mode);



        this.WinPictureBox.SizeMode = t;
        



        this.Trigger(this.ModeField);



        return true;
    }





    protected override bool ChangeSize(Change change)
    {
        this.WinPictureBox.Size = this.WinCreate.Size(this.Size);




        base.ChangeSize(change);




        return true;
    }





    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);



        if (this.ValueField == field)
        {
            this.ChangeValue(change);
        }


        if (this.ModeField == field)
        {
            this.ChangeMode(change);
        }



        return true;
    }




    public override View Child
    {
        get
        {
            return null;
        }

        set
        {
        }
    }




    private bool Null(object o)
    {
        return o == null;
    }




    private WinPictureBox WinPictureBox { get; set; }
}