namespace System.Infra;



class IntMap : Object
{
    private BlockEntry RootEntry;



    public override bool Init()
    {
        base.Init();


        this.RootEntry = new BlockEntry();


        return true;
    }




    public ulong? NewInt()
    {
        return this.GetNewInt(ref this.RootEntry, 0, 0);
    }





    private ulong? GetNewInt(ref BlockEntry entry, int level, ulong index)
    {
        Constant constant;

        constant = Constant.This;



        Convert convert;

        convert = Convert.This;




        int cc;

        cc = constant.BlockLevelCount;



        if (level == cc)
        {
            return index;
        }




        ulong key;

        key = entry.Key;



        BlockEntry[] v;

        v = entry.Value;


        if (v == null)
        {
            v = new BlockEntry[constant.BlockEntryCount];


            entry.Value = v;


            
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



        int oo;

        oo = constant.BlockEntryValueLoopCount;


        

        int start;

        start = k * oo;



        int aa;




        ulong? uu;



        ulong nn;



        ulong au;



        int ll;

        ll = level + 1;



        int ce;

        ce = cc - 1;



        int kk;



        int jj;

        jj = constant.BlockEntryIndexBitCount;



        int count;

        count = oo;



        BlockEntry e;



        int i;

        i = 0;

        while (i < count)
        {
            aa = start + i;


            e = v[aa];




            uu = this.GetNewInt(ref e, ll, index);
            


            v[aa] = e;



            if (uu.HasValue)
            {
                if (this.IsBlockAllEntryUse(v))
                {

                }




                kk = ce - level;


                kk = kk * jj;



                au = convert.ULong(i);


                au = au << kk;

                


                nn = uu.Value;


                au = au | nn;



                return au;
            }



            i = i + 1;
        }




        return null;
    }




    private bool IsBlockAllEntryUse(BlockEntry[] array)
    {
        Constant constant;

        constant = Constant.This;



        int count;

        count = constant.BlockEntryCount;



        ulong cc;

        cc = constant.BlockEntryKeyAllUse;



        ulong a;



        int i;

        i = 0;

        while (i < count)
        {
            a = array[i].Key;


            if (!(a == cc))
            {
                return false;
            }


            i = i + 1;
        }



        return true;
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