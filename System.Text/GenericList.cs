namespace System.Text;






struct GenericList<T>
{
    public bool Init()
    {
        this.Data = new T[InitialCapacity];





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





    public T[] Data { get; private set; }


    





    public T Get(int index)
    {
        if (!this.CheckIndex(index))
        {
            return default(T);
        }




        return this.Data[index];
    }





    public bool Set(int index, T item)
    {
        if (!this.CheckIndex(index))
        {
            return true;
        }



        
        this.Data[index] = item;


        return true;
    }








    public bool Add(T[] item, InfraRange range)
    {
        int count;


        count = this.CountRange(range);



        int newCount;


        newCount = this.Count + count;




        if (!this.HasSpace(this.Capacity, newCount))
        {
            int capacity;


            capacity = this.NewCapacity(newCount);





            T[] d;


            d = new T[capacity];




            SystemArray.Copy(this.Data, 0, d, 0, this.Count);




            this.Data = d;
        }






        SystemArray.Copy(item, range.Start, this.Data, this.Count, count);






        this.Count = newCount;




        return true;
    }









    public bool Insert(int index, T[] item, InfraRange range)
    {
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




            T[] d;


            d = new T[capacity];



            SystemArray.Copy(this.Data, 0, d, 0, index);






            SystemArray.Copy(item, range.Start, d, index, count);




            int k;


            k = index + count;




            int remainCount;


            remainCount = this.Count - index;




            SystemArray.Copy(this.Data, index, d, k, remainCount);





            this.Data = d;
        }




        if (b)
        {
            int remainCount;


            remainCount = this.Count - index;




            this.MoveCharListToNext(index, remainCount, count);





            SystemArray.Copy(item, range.Start, this.Data, index, count);
        }




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




        this.MoveCharListToPrevious(index, count, previous);



        int k;

        k = rangeCount;



        this.Count = this.Count - k;



        return true;
    }






    private int CountRange(InfraRange range)
    {
        RangeInfra infra;

        infra = RangeInfra.This;



        return infra.Count(range);
    }






    public GenericIter<T> Iter()
    {
        GenericIter<T> iter;


        iter = new GenericIter<T>();


        iter.List = this;


        iter.Init();





        GenericIter<T> ret;


        ret = iter;


        return ret;
    }






    private bool MoveCharListToPrevious(int index, int count, int previous)
    {
        T[] array;


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







    private bool MoveCharListToNext(int index, int count, int next)
    {
        T[] array;


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






    private bool CheckRange(InfraRange range)
    {
        bool ba;


        ba = this.CheckIndex(range.Start);



        bool bb;


        bb = range.End < this.Count + 1;



        bool bc;


        bc = range.End < range.Start;



        if (!(ba & bb & !bc))
        {
            return false;
        }



        return true;
    }








    private bool HasSpace(int capacity, int count)
    {
        return !(capacity < count);
    }





    

    private static int InitialCapacity { get; } = 128;
}