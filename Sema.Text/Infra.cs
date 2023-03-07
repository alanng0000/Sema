namespace Sema.Text;




public class Infra : InfraObject
{
    public Text Text
    {
        get; set;
    }






    private int Count(InfraRange range)
    {
        RangeInfra infra;

        infra = RangeInfra.This;



        return infra.Count(range);
    }





    public bool Equal(int row, InfraRange range, string other)
    {
        int count;
        
        count = this.Count(range);




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



        char oca;

        char ocb;




        int i;

        i = 0;

        while (i < count)
        {
            oca = varChar.Get(start + i);


            ocb = other[i];



            if (!(oca == ocb))
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


        s = new string(line.Char.Data, range.Start, count);

        
        return s;
    }





    public char Char(Pos pos)
    {
        Line line;

        line = this.Line(pos.Row);



        char oc;

        oc = line.Char.Data[pos.Col];


        return oc;
    }





    public bool StartWith(int row, InfraRange range, char oc)
    {
        if (!this.Check(row, range))
        {
            return false;
        }



        if (this.Count(range) < 1)
        {
            return false;
        }



        char occ;

        occ = this.Char(this.Pos(row, range.Start));



        bool ret;

        ret = (occ == oc);


        return ret;
    }





    public bool EndWith(int row, InfraRange range, char oc)
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
        
        


        char occ;

        occ = this.Char(t);




        bool ret;

        ret = (occ == oc);


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





    public Pos Pos(int row, int col)
    {
        Pos pos;

        pos = new Pos();

        pos.Init();

        pos.Row = row;

        pos.Col = col;


        return pos;
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





        ulong valu;



        valu = j;




        ulong ret;


        ret = valu;


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
}