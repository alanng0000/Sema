namespace Sema.Text;






struct GenericList<TItem>
{
    public bool Init()
    {
        this.Data = new TItem[InitialCapacity];





        return true;
    }





    public int Count
    {
        get; private set;
    }





    private int Capacity
    { 
        get
        { 
            return this.Data.Length; 
        } 
    }





    public TItem[] Data { get; private set; }


    





    public TItem Get(int index)
    {
        if (!this.CheckIndex(index))
        {
            return default(TItem);
        }




        return this.Data[index];
    }








    public bool Insert(InfraRange range)
    {
        if (!this.CheckInsertRange(range))
        {
            return true;
        }




        int count;


        count = this.CountRange(range);





        int newCount;


        newCount = this.Count + count;




        bool b;


        b = this.HasSpace(this.Capacity, newCount);



        if (!b)
        {
            int capacity;


            capacity = this.NewCapacity(newCount);




            TItem[] d;


            d = new TItem[capacity];



            SystemArray.Copy(this.Data, 0, d, 0, range.Start);






            int k;


            k = range.Start + count;




            int remainCount;


            remainCount = this.Count - range.Start;




            SystemArray.Copy(this.Data, range.Start, d, k, remainCount);





            this.Data = d;
        }




        if (b)
        {
            int remainCount;


            remainCount = this.Count - range.Start;




            this.MoveItemListToNext(range.Start, remainCount, count);
        }





        SystemArray.Fill(this.Data, default(TItem), range.Start, count);





        this.Count = newCount;




        return true;
    }
    






    private int NewCapacity(int count)
    {
        int capacity;


        capacity = this.Capacity;


        capacity = capacity * 2;




        if (!this.HasSpace(capacity, count))
        {
            capacity = count;
        }



        int ret;

        ret = capacity;


        return ret;
    }








    public bool Remove(InfraRange range)
    {
        if (!this.CheckRange(range))
        {
            return true;
        }




        int rangeCount;

        rangeCount = this.CountRange(range);




        int index;


        index = range.End;



        int t;


        t = this.Count - index;




        int count;


        count = t;




        int previous;


        previous = rangeCount;




        this.MoveItemListToPrevious(index, count, previous);



        int k;

        k = rangeCount;



        this.Count = this.Count - k;



        return true;
    }






    public bool Set(int index, TItem[] item, InfraRange range)
    {
        int count;
        
        count = this.CountRange(range);



        RangeInfra infra;

        infra = RangeInfra.This;



        InfraRange o;

        o = infra.Range(index, index + count);



        if (!this.CheckRange(o))
        {
            return true;
        }




        SystemArray.Copy(item, range.Start, this.Data, index, count);




        return true;
    }











    private int CountRange(InfraRange range)
    {
        RangeInfra infra;

        infra = RangeInfra.This;



        return infra.Count(range);
    }






    public GenericIter<TItem> Iter()
    {
        GenericIter<TItem> iter;


        iter = new GenericIter<TItem>();


        iter.List = this;


        iter.Init();





        GenericIter<TItem> ret;


        ret = iter;


        return ret;
    }






    private bool MoveItemListToPrevious(int index, int count, int previous)
    {
        TItem[] array;


        array = this.Data;




        int k;

        k = index - previous;



        int i;

        i = 0;



        while (i < count)
        {
            array[k + i] = array[index + i];



            i = i + 1;
        }





        return true;
    }







    private bool MoveItemListToNext(int index, int count, int next)
    {
        TItem[] array;


        array = this.Data;




        int e;

        e = index + count;



        int k;
        
        k = 0;



        int i;

        i = 0;


        while (i < count)
        {
            k = e - i - 1;


            array[k + next] = array[k];



            i = i + 1;
        }


        return true;
    }







    private bool CheckIndex(int index)
    {
        return index < this.Count;
    }







    private bool CheckInsertRange(InfraRange range)
    {
        bool ba;


        ba = range.Start < this.Count + 1;



        bool bb;


        bb = range.End < range.Start;



        return (ba & !bb);
    }






    private bool CheckRange(InfraRange range)
    {
        bool ba;


        ba = range.End < this.Count + 1;



        bool bb;


        bb = range.End < range.Start;



        return (ba & !bb);
    }








    private bool HasSpace(int capacity, int count)
    {
        return !(capacity < count);
    }





    

    private static int InitialCapacity { get; } = 128;
}