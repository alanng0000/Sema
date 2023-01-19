namespace System.List;




public class GenericList<TItem> : InfraObject
{
    public override bool Init()
    {
        base.Init();

        


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






    public bool SetCount(int value)
    {
        int newCount;


        newCount = value;




        if (!this.HasSpace(this.Capacity, newCount))
        {
            int capacity;


            capacity = this.NewCapacity(newCount);





            TItem[] d;


            d = new TItem[capacity];





            this.Data = d;
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






    private bool HasSpace(int capacity, int count)
    {
        return !(capacity < count);
    }





    

    private static int InitialCapacity { get; } = 256;
}