namespace System.Infra;



class IntMap : Object
{
    private BlockEntry Root;



    private ulong NewInt()
    {
        return 0;
    }



    private ulong? GetNewInt(ulong key, BlockEntry[] array)
    {
        int? u;

        u = this.GetKeyAvailableInt(key);


        if (!u.HasValue)
        {
            return null;
        }



        int k;

        k = u.Value;



        Constant constant;

        constant = Constant.This;




        int j;

        j = constant.BlockEntryValueLoopCount;


        

        int start;

        start = k * j;



        int count;

        count = j;



        int i;

        i = 0;

        while (i < count)
        {
            
            


            i = i + 1;
        }




        return 0;
    }




    private int? GetKeyAvailableInt(ulong key)
    {
        Constant constant;

        constant = Constant.This;



        int count;

        count = constant.BlockEntryKeyBitCount;



        
        ulong k;


        
        int i;

        i = 0;

        while (i < count)
        {
            k = key >> i;


            k = k & 1;


            if (k == 0)
            {
                return i;
            }



            i = i + 1;
        }



        return null;
    }
}