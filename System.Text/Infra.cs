namespace System.Text;




public class Infra : InfraObject
{
    public override bool Init()
    {
        base.Init();




        this.Quote = (byte)'\"';



        this.BackSlash = (byte)'\\';




        this.Ranges = new RangeInfra();



        this.Ranges.Init();




        return true;
    }






    private RangeInfra Ranges { get; set; }




    public Text Text
    {
        get; set;
    }






    private int Count(InfraRange range)
    {
        return this.Ranges.Count(range);
    }





    public bool Equal(int row, InfraRange range, string other)
    {
        int count;
        
        count = this.Ranges.Count(range);




        if (!(count == other.Length))
        {
            return false;
        }


        


        Line line;

        line = this.Line(row);




        CharList varChar;

        varChar = line.Char;




        int start;

        start = range.Start;



        byte oba;

        byte obb;


        char oc;



        int i;

        i = 0;

        while (i < count)
        {
            oba = varChar.Get(start + i);


            oc = other[i];


            obb = (byte)oc;



            if (!(oba == obb))
            {
                return false;
            }



            i = i + 1;
        }


        return true;
    }




    public string Substring(int row, InfraRange range)
    {
        if (!this.Check(row, range))
        {
            return null;
        }
        



        Line line;

        line = this.Line(row);



        int count;

        count = this.Count(range);



        

        string s;


        s = Encoding.ASCII.GetString(line.Char.Data, range.Start, count);

        
        return s;
    }





    public byte Char(Pos pos)
    {
        Line line;

        line = this.Line(pos.Row);



        byte ob;

        ob = line.Char.Data[pos.Col];


        return ob;
    }





    public bool StartWith(int row, InfraRange range, byte ob)
    {
        if (!this.Check(row, range))
        {
            return false;
        }



        if (this.Count(range) < 1)
        {
            return false;
        }



        byte obb;

        obb = this.Char(this.Pos(row, range.Start));



        bool ret;

        ret = (obb == ob);


        return ret;
    }





    public bool EndWith(int row, InfraRange range, byte ob)
    {
        if (!this.Check(row, range))
        {
            return false;
        }



        if (this.Count(range) < 1)
        {
            return false;
        }




        Pos t;


        t = this.Pos(row, range.End - 1);
        
        


        byte obb;

        obb = this.Char(t);




        bool ret;

        ret = (obb == ob);


        return ret;
    }






    public bool Check(int row, InfraRange range)
    {
        if (!this.CheckRow(row))
        {
            return false;
        }




        Line line;

        line = this.Line(row);



        int col;

        col = range.Start;



        if (!this.CheckCol(line, col))
        {
            return false;
        }



        col = range.End - 1;

            


        if (!this.CheckCol(line, col))
        {
            return false;
        }
        




        return true;
    }






    public Line Line(int row)
    {
        return (Line)this.Text.Line.Get(row);
    }





    public bool CheckRow(int row)
    {
        return (0 <= row & row < this.Text.Line.Count);
    }





    public bool CheckCol(Line line, int col)
    {
        return (0 <= col & col < line.Char.Count);
    }





    private Pos Pos(int row, int col)
    {
        Pos pos;

        pos = new Pos();

        pos.Init();

        pos.Row = row;

        pos.Col = col;


        return pos;
    }





    public string Value(int row, InfraRange range)
    {
        if (this.Count(range) < 2)
        {
            return null;
        }




        if (!this.IsQuote(this.Pos(row, range.Start)))
        {
            return null;
        }





        int count;


        count = this.Count(range) - 1;






        StringBuilder sb;


        sb = new StringBuilder();




        int start;



        start = range.Start + 1;




        int index;





        Pos pos;

        pos = this.Pos(row, 0);




        Pos posA;

        posA = this.Pos(row, 0);




        byte c;




        bool b;



        bool bb;



        bool bc;



        int j;




        byte u;




        byte escapeValue;




        char oc;




        int i;


        i = 0;





        while (i < count)
        {
            index = start + i;



            pos.Col = index;



            c = this.Char(pos);



            b = (c == this.BackSlash);
            
            

            if (b)
            {
                j = i + 1;



                bb = (j < count - 1);



                if (bb)
                {
                    posA.Col = start + j;



                    u = this.Char(posA);



                    
                    if (u == this.Quote)
                    {
                        escapeValue = u;
                    }
                    else if (u == 't')
                    {
                        escapeValue = this.Tab;
                    }
                    else if (u == 'n')
                    {
                        escapeValue = this.LineEnd;
                    }
                    else if (u == this.BackSlash)
                    {
                        escapeValue = u;
                    }
                    else
                    {
                        return null;
                    }



                    oc = (char)escapeValue;



                    sb.Append(oc);



                    i = i + 1;
                }



                if (!bb)
                {
                    return null;
                }
            }




            if (!b)
            {
                bb = (c == this.Quote);




                bc = (i == count - 1);




                if (bb)
                {
                    if (!bc)
                    {
                        return null;
                    }
                }
                



                if (!bb)
                {
                    if (bc)
                    {
                        return null;
                    }



                    sb.Append(c);
                }
            }




            i = i + 1;
        }




        string ret;

        ret = sb.ToString();


        return ret;
    }





    public ulong? IntValue(int row, InfraRange range)
    {
        ulong j;


        j = 0;




        int count;


        count = this.Count(range);




    
        int start;


        start = range.Start;



        Pos pos;

        pos = this.Pos(row, 0);




        ulong magnitude;


        magnitude = 1;





        int i;


        i = 0;



        while (i < count)
        {
            int index;


            index = count - i - 1;




            int sc;


            sc = start + index;



            pos.Col = sc;




            byte ob;


            ob = this.Char(pos);




            if (!this.IsDigit(ob))
            {
                return null;
            }




            if (magnitude >= 1000000000000)
            {
                return null;
            }




            ulong digit;


            digit = this.Digit(ob);





            ulong t;



            t = digit * magnitude;





            j = j + t;




            magnitude = magnitude * 10;




            i = i + 1;
        }





        ulong value;



        value = j;




        ulong ret;


        ret = value;


        return ret;
    }





    public string EscapeString(string s)
    {
        string t;
        
        
        t = s;


        t = t.Replace("\\", "\\\\");


        t = t.Replace("\"", "\\\"");


        t = t.Replace("\t", "\\t");


        t = t.Replace("\n", "\\n");


        t = t.Replace("\r", "\\r");


        string ret;
        ret = t;

        return ret;
    }





    public ulong Digit(byte o)
    {
        ulong u;


        u = o;




        ulong h;


        h = '0';

        


        ulong t;


        t = (u - h);




        ulong ret;


        ret = t;


        return ret;
    }






    public bool IsAlphanumeric(byte o)
    {
        return this.IsLetter(o) | this.IsDigit(o);
    }




    public bool IsDigit(byte o)
    {
        return '0' <= o && o <= '9';
    }





    public bool IsHexDigit(byte o)
    {
        if ('a' <= o && o <= 'f')
        {
            return true;
        }


        return this.IsDigit(o);
    }




    public bool IsLetter(byte o)
    {
        return this.IsLowerLetter(o) | this.IsUpperLetter(o);
    }




    public bool IsLowerLetter(byte o)
    {
        return 'a' <= o & o <= 'z';
    }



    public bool IsUpperLetter(byte o)
    {
        return 'A' <= o & o <= 'Z';
    }





    private byte Quote;




    private byte BackSlash;




    private byte Tab;




    private byte LineEnd;


    




    private bool IsQuote(Pos pos)
    {
        byte oc;




        oc = this.Char(pos);




        bool b;



        b = (oc == Quote);




        bool ret;



        ret = b;



        return ret;
    }
}