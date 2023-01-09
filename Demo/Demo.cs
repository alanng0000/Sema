namespace Demo;




class Demo : Object
{
    public bool Execute()
    {
        this.ExecuteA();



        this.ExecuteFrame();





        return true;
    }





    private bool ExecuteFrame()
    {
        string title;


        title = "Demo Frame";




        byte[] array;


        array = this.StringByteList(title);




        ulong length;

        length = (ulong)array.Length;




        ulong p;
        
        p = Extern.New(length);



        IntPtr ptr;

        ptr = (IntPtr)p;



        Marshal.Copy(array, 0, ptr, array.Length);






        ulong ss;


        ss = Extern.String_New();



        Extern.String_Init(ss);



        Extern.String_SetLength(ss, length);


        Extern.String_SetData(ss, p);





        FrameControlHandleMethod m;



        m = this.FrameControlHandle;
        




        this.ControlHandleMethodDelegate = m;





        IntPtr fp;


        fp = Marshal.GetFunctionPointerForDelegate(this.ControlHandleMethodDelegate);



        ulong oo;


        oo = (ulong)fp;










        ulong frame;


        frame = Extern.Frame_New();



        Extern.Frame_SetTitle(frame, ss);



        Extern.Frame_Init(frame);



        Extern.Frame_SetControlHandle(frame, oo);



        Extern.Frame_SetVisible(frame, 1);



        Extern.Frame_Execute(frame);



        Extern.Frame_Final(frame);



        Extern.Frame_Delete(frame);






        Extern.String_Final(ss);



        Extern.String_Delete(ss);





        Extern.Delete(p);





        return true;
    }




    private System.Delegate ControlHandleMethodDelegate { get; set; }





    delegate ulong FrameControlHandleMethod(ulong o, ulong key, ulong value);





    private ulong FrameControlHandle(ulong o, ulong key, ulong value)
    {
        string s;

        s = key.ToString() + ", " + value.ToString() + "\n";


        System.Console.Write(s);



        return 1;
    }







    private byte[] StringByteList(string s)
    {
        int count;

        count = s.Length;



        byte[] array;

        array = new byte[count];



        int i;

        i = 0;

        while (i < count)
        {
            char oc;

            oc = s[i];



            byte ob;

            ob = (byte)oc;



            array[i] = ob;



            i = i + 1;
        }



        byte[] ret;

        ret = array;


        return ret;
    }







    private bool ExecuteA()
    {
        string s;


        s = "2222 DEMO SUCCESS\n";




        byte[] array;

        array = this.StringByteList(s);





        ulong length;

        length = (ulong)array.Length;



        ulong p;
        
        p = Extern.New(length);



        IntPtr ptr;

        ptr = (IntPtr)p;



        Marshal.Copy(array, 0, ptr, array.Length);




        ulong ss;


        ss = Extern.String_New();



        Extern.String_Init(ss);



        Extern.String_SetLength(ss, length);


        Extern.String_SetData(ss, p);





        ulong console;


        console = Extern.Console_New();



        Extern.Console_Init(console);



        Extern.Console_Write(console, ss);



        Extern.Console_Final(console);



        Extern.Console_Delete(console);






        Extern.String_Final(ss);



        Extern.String_Delete(ss);





        Extern.Delete(p);

    


        


        return true;
    }
}