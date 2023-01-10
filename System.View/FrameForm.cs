namespace System.View;




public class FrameForm : WinForm, WinIMessageFilter
{
    public Frame Frame { get; set; }






    private int WM_KEYDOWN { get; } = 0x0100;




    private int WM_KEYUP { get; } = 0x0101;




    private int WM_CHAR { get; } = 0x0102;





    private int WM_MOUSEMOVE { get; } = 0x0200;






    private byte VK_CAPITAL { get; } = 0x14;







    public bool Init()
    {
        this.DoubleBuffered = true;




        this.WindowState = WinFormWindowState.Maximized;



        this.FormBorderStyle = WinFormBorderStyle.None;



        this.BackColor = WinColor.White;




        this.Text = this.Frame.Title;

        



        return true;
    }






    protected override void OnPaint(WinPaintEventArgs e)
    {
        WinGraphics g;


        g = e.Graphics;



        DrawDraw draw;

        draw = this.Frame.Draw;



        draw.SetWin(g);




        this.Frame.ExecuteDraw();
    }








    bool WinIMessageFilter.PreFilterMessage(ref WinMessage m)
    {
        bool ba;

        ba = (m.Msg == this.WM_KEYDOWN);



        bool bb;

        bb = (m.Msg == this.WM_KEYUP);



        if (ba | bb)
        {
            byte key;


            key = this.Key(m.WParam);





            bool state;
            

            state = ba;




            //if (key == this.VK_CAPITAL)
            //{
            //    bool b;


            //    b = this.ToggledOn(key);



            //    ControlControl.This.CapsLock = b;
            //}





            ControlControl.This.SetKeyState(key, state);





            return false;
        }






        if (m.Msg == this.WM_CHAR)
        {
            
            char oc;
            
            oc = this.Char(m.WParam);





            ulong charCode;


            charCode = this.CharCode(oc);





            bool b;


            b = 
            (
                (0x08 <= charCode & charCode <= 0x0d) |
                (charCode == 0x1b)
            );



            if (b)
            {
                return true;
            }






            ControlControl.This.KeyChar(oc);





            return true;
        }





        if (m.Msg == this.WM_MOUSEMOVE)
        {
            return true;
        }



        

        
        return false;
    }









    //private bool ToggledOn(byte key)
    //{
    //    short o;
        
    //    o = GetKeyState(key);




    //    ushort k;

    //    k = (ushort)o;




    //    ulong n;


    //    n = k;




    //    ulong i;


    //    i = 0x1;



        
    //    n = n & i;




    //    bool b;


    //    b = !(n == 0);




    //    bool toggledOn;


    //    toggledOn = b;




    //    bool ret;


    //    ret = toggledOn;


    //    return ret;
    //}










    private ulong CharCode(char oc)
    {
        return oc;
    }







    private char Char(IntPtr o)
    {
        long u;


        u = o.ToInt64();




        ulong m;


        m = (ulong)u;




        char oc;


        oc = (char)m;




        char ret;


        ret = oc;



        return ret;
    }





    private byte Key(IntPtr o)
    {
        long t;

        t = o.ToInt64();



        byte u;

        u = (byte)t;



        byte key;

        key = u;



        byte ret;

        ret = key;


        return ret;
    }





    //[DllImport("user32.dll")]
    //private static extern short GetKeyState(int nVirtKey);
}