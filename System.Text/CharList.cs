namespace System.Text;






public class CharList : InfraObject
{
    public override bool Init()
    {
        base.Init();




        this.Data = new byte[InitialCapacity];




        this.AddInsertOneChars = new byte[1];




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





    public byte[] Data { get; private set; }





    private byte[] AddInsertOneChars { get; set; }





    public byte Get(int index)
    {
        if (!this.CheckIndex(index))
        {
            return 0;
        }




        return this.Data[index];
    }





    public bool Set(int index, byte item)
    {
        if (!this.CheckIndex(index))
        {
            return true;
        }



        
        this.Data[index] = item;


        return true;
    }








    public bool Add(byte item)
    {
        this.AddInsertOneChars[0] = item;




        InfraRange range;

        range = new InfraRange();

        range.Init();

        range.Start = 0;

        range.End = range.Start + 1;




        this.AddRange(this.AddInsertOneChars, range);




        return true;
    }








    public bool AddRange(byte[] items, InfraRange range)
    {
        int count;


        count = this.CountRange(range);



        int newCount;


        newCount = this.Count + count;




        if (!this.HasSpace(this.Capacity, newCount))
        {
            int capacity;


            capacity = this.NewCapacity(newCount);





            byte[] d;


            d = new byte[capacity];




            SystemArray.Copy(this.Data, 0, d, 0, this.Count);




            this.Data = d;
        }






        SystemArray.Copy(items, range.Start, this.Data, this.Count, count);






        this.Count = newCount;




        return true;
    }









    public bool Insert(int index, byte item)
    {
        this.AddInsertOneChars[0] = item;




        InfraRange range;

        range = new InfraRange();

        range.Start = 0;

        range.End = range.Start + 1;




        this.InsertRange(index, this.AddInsertOneChars, range);




        return true;
    }







    public bool InsertRange(int index, byte[] items, InfraRange range)
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




            byte[] d;


            d = new byte[capacity];



            SystemArray.Copy(this.Data, 0, d, 0, index);






            System.Array.Copy(items, range.Start, d, index, count);




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




            this.MoveCharsToNext(index, remainCount, count);





            SystemArray.Copy(items, range.Start, this.Data, index, count);
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






    public bool Remove(int index)
    {
        InfraRange range;

        range = new InfraRange();

        range.Start = index;

        range.End = index + 1;



        this.RemoveRange(range);



        return true;
    }






    public bool RemoveRange(InfraRange range)
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




        this.MoveCharsToPrevious(index, count, previous);



        int k;

        k = rangeCount;



        this.Count = this.Count - k;



        return true;
    }





    private int CountRange(InfraRange range)
    {
        return range.End - range.Start;
    }





    public CharIter Iter()
    {
        CharIter iter;


        iter = new CharIter();


        iter.Chars = this;


        iter.Init();





        CharIter ret;


        ret = iter;


        return ret;
    }






    private bool MoveCharsToPrevious(int index, int count, int previous)
    {
        byte[] array;


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







    private bool MoveCharsToNext(int index, int count, int next)
    {
        byte[] array;


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





    

    private static int InitialCapacity { get; } = 256;
}