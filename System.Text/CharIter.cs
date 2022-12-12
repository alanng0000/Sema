namespace System.Text;





public struct CharIter
{
    internal Chars Chars { get; set; }




    private int Index { get; set; }




    private int CurrentIndex { get; set; }




    public bool Init()
    {
        this.Index = 0;



        this.CurrentIndex = -1;



        return true;
    }





    public bool Next()
    {
        bool b;


        b = this.CheckIndex(this.Index);





        if (b)
        {
            this.CurrentIndex = this.Index;




            this.Index = this.Index + 1;
        }



        return b;
    }




    public char Value
    {
        get
        {
            return this.Chars.Get(this.CurrentIndex);
        }

        set
        {
        }
    }



    public int Key
    {
        get
        {
            return this.CurrentIndex;
        }

        set
        {
        }
    }




    private bool CheckIndex(int index)
    {
        if (index < 0)
        {
            return false;
        }


        if (!(index < this.Chars.Count))
        {
            return false;
        }


        return true;
    }
}