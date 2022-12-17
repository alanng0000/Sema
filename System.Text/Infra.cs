namespace System.Text;




public class Infra : InfraObject
{
    public override bool Init()
    {
        base.Init();




        this.Quote = '\"';



        this.BackSlash = '\\';




        this.Ranges = new RangeInfra();



        this.Ranges.Init();




        return true;
    }






    private RangeInfra Ranges { get; set; }




    public Text Text
    {
        get; set;
    }





    public bool Equal(Range range, string other)
    {
        int count;
            
        count = range.Count;



        if (!(count == other.Length))
        {
            return false;
        }



        int row;

        row = range.Pos.Row;
        


        Line line;

        line = this.Text.Lines.Get(row);



        Chars chars;

        chars = line.Chars;




        int start;

        start = range.Pos.Col;



        int i;

        i = 0;

        while (i < count)
        {
            if (chars.Get(start + i) != other[i])
            {
                return false;
            }


            i++;
        }


        return true;
    }




    public string Substring(Range range)
    {
        if (!this.Check(range))
        {
            return null;
        }
        



        Line line;

        line = this.Text.Lines.Get(range.Pos.Row);



        string s;


        s = new string(line.Chars.Data, range.Pos.Col, range.Count);

        
        return s;
    }





    public char Char(Pos pos)
    {
        Line line;

        line = this.Text.Lines.Get(pos.Row);



        char oc;

        oc = line.Chars.Data[pos.Col];


        return oc;
    }





    public bool StartWith(Range range, char oc)
    {
        if (!this.Check(range))
        {
            return false;
        }



        if (range.Count < 1)
        {
            return false;
        }



        char occ;

        occ = this.Char(range.Pos);



        bool ret;

        ret = (occ == oc);


        return ret;
    }





    public bool EndWith(Range range, char oc)
    {
        if (!this.Check(range))
        {
            return false;
        }



        if (range.Count < 1)
        {
            return false;
        }




        Pos t;


        t = range.Pos;


        t.Col = t.Col + range.Count - 1;
        


        char occ;

        occ = this.Char(t);




        bool ret;

        ret = (occ == oc);


        return ret;
    }






    public bool Check(Range range)
    {
        int row;

        row = range.Pos.Row;



        if (!this.CheckRow(row))
        {
            return false;
        }




        Line line;

        line = this.Text.Lines.Get(row);



        int col;

        col = range.Pos.Col;



        if (!this.CheckCol(line, col))
        {
            return false;
        }





        int count;

        count = range.Count;




        if (count < 0)
        {
            return false;
        }
        



        if (!(count < 1))
        {
            int u;

            u = count - 1;



            int k;

            k = col + u;

            


            if (!this.CheckCol(line, k))
            {
                return false;
            }
        }




        return true;
    }






    private bool CheckRow(int row)
    {
        return (0 <= row & row < this.Text.Lines.Count);
    }





    private bool CheckCol(Line line, int col)
    {
        return (0 <= col & col < line.Chars.Count);
    }


    





    public string Value(Range range)
    {
        if (range.Count < 2)
        {
            return null;
        }




        if (!this.IsQuote(range.Pos))
        {
            return null;
        }





        int count;


        count = range.Count - 1;






        StringBuilder sb;


        sb = new StringBuilder();




        int start;



        start = range.Pos.Col + 1;




        int index;





        Pos pos;

        pos = new Pos();

        pos.Row = range.Pos.Row;




        Pos posA;

        posA = new Pos();

        posA.Row = range.Pos.Row;




        char c;




        bool b;



        bool bb;



        bool bc;



        int j;




        char u;




        char escapeValue;




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



                    
                    if (u == Quote)
                    {
                        escapeValue = u;
                    }
                    else if (u == 't')
                    {
                        escapeValue = '\t';
                    }
                    else if (u == 'n')
                    {
                        escapeValue = '\n';
                    }
                    else if (u == this.BackSlash)
                    {
                        escapeValue = u;
                    }
                    else
                    {
                        return null;
                    }


                    sb.Append(escapeValue);



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





    public ulong? IntValue(Range range)
    {
        ulong j;


        j = 0;




        int count;


        count = range.Count;




        Pos pos;


        pos = new Pos();


        pos.Row = range.Pos.Row;





        int start;


        start = range.Pos.Col;





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




            char ob;


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





    public ulong Digit(char o)
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






    public bool IsAlphanumeric(char o)
    {
        return this.IsLetter(o) | this.IsDigit(o);
    }




    public bool IsDigit(char o)
    {
        return '0' <= o && o <= '9';
    }





    public bool IsHexDigit(char o)
    {
        if ('a' <= o && o <= 'f')
        {
            return true;
        }


        return this.IsDigit(o);
    }




    public bool IsLetter(char o)
    {
        return this.IsLowerLetter(o) | this.IsUpperLetter(o);
    }




    public bool IsLowerLetter(char o)
    {
        return 'a' <= o & o <= 'z';
    }



    public bool IsUpperLetter(char o)
    {
        return 'A' <= o & o <= 'Z';
    }





    private char Quote;




    private char BackSlash;





    private bool IsQuote(Pos pos)
    {
        char oc;




        oc = this.Char(pos);




        bool b;



        b = (oc == Quote);




        bool ret;



        ret = b;



        return ret;
    }
}