namespace System.Text;





public struct GenericIter<T>
{
    internal GenericList<T> List { get; set; }




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




    public T Value
    {
        get
        {
            return this.List.Get(this.CurrentIndex);
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


        if (!(index < this.List.Count))
        {
            return false;
        }


        return true;
    }
}