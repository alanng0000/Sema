namespace System.List;





public struct ArrayIter : IIter
{
    internal Array Array { get; set; }




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


        b = this.Array.Contain(this.Index);





        if (b)
        {
            this.CurrentIndex = this.Index;




            this.Index = this.Index + 1;
        }



        return b;
    }





    public object Value
    {
        get
        {
            return this.Array.Get(this.CurrentIndex);
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




    object IIter.Key
    {
        get
        {
            return this.CurrentIndex;
        }

        set
        {
        }
    }
}