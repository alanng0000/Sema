namespace Demo;




class Demo : Object
{
    public bool Execute()
    {
        this.ExecuteA();



        




        return true;
    }





    private bool ExecuteA()
    {
        string s;


        s = "2222 DEMO SUCCESS\n";




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





        ulong length;

        length = (ulong)count;



        ulong p;
        
        p = Extern.New(length);



        IntPtr ptr;

        ptr = (IntPtr)p;



        Marshal.Copy(array, 0, ptr, count);




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