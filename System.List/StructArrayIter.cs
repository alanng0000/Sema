namespace System.List;





public struct StructArrayIter<TItem> : IIter where TItem : struct
{
    internal StructArray<TItem> Array { get; set; }




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





    public TItem Value
    {
        get
        {
            return this.GetValue();
        }

        set
        {
        }
    }







    object IIter.Value
    {
        get
        {
            return this.GetValue();
        }

        set
        {
        }
    }








    public int Key
    {
        get
        {
            return this.GetKey();
        }

        set
        {

        }
    }




    object IIter.Key
    {
        get
        {
            return this.GetKey();
        }

        set
        {
        }
    }





    private TItem GetValue()
    {
        return this.Array.Get(this.CurrentIndex);
    }



    private int GetKey()
    {
        return this.CurrentIndex;
    }
}