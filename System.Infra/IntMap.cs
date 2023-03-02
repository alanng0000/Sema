namespace System.Infra;



class IntMap : Object
{
    private BlockEntry Root;



    private ulong NewInt()
    {
        return 0;
    }



    private ulong? GetNewInt(BlockEntry entry, int level)
    {
        if (level == 4)
        {

        }



        ulong key;

        key = entry.Key;



        BlockEntry[] value;

        value = entry.Value;


        if (value == null)
        {
            return null;
        }



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



        int index;



        ulong? uu;



        int kk;

        kk = level + 1;



        int count;

        count = j;



        BlockEntry e;



        int i;

        i = 0;

        while (i < count)
        {
            index = start + i;


            e = value[index];




            uu = this.GetNewInt(e, kk);


            if (uu.HasValue)
            {
                return uu;
            }



            i = i + 1;
        }




        return null;
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




    private int LevelCount
    {
        get
        {
            return 4;
        }
        set
        {
        }
    }
}