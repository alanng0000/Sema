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




    public ulong? New()
    {
        return this.GetNewInt(ref this.RootEntry, 0, 0);
    }





    private ulong? GetNewInt(ref BlockEntry entry, int level, int index)
    {
        Constant constant;

        constant = Constant.This;



        Convert convert;

        convert = Convert.This;




        int cc;

        cc = constant.BlockLevelCount;



        if (level == cc)
        {
            ulong ooo;

            ooo = convert.ULong(index);


            return ooo;
        }




        ulong key;

        key = entry.Key;



        BlockEntry[] v;

        v = entry.Value;


        if (v == null)
        {
            v = new BlockEntry[constant.BlockEntryCount];


            entry.Value = v;
        }




        int? u;

        u = this.GetKeyAvailableBitIndex(key);


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




            uu = this.GetNewInt(ref e, ll, aa);



            v[aa] = e;



            if (uu.HasValue)
            {
                if (this.IsBlockEntryArrayUse(v, start, count))
                {
                    ulong ua;

                    ua = 1;
                    
                    ua = ua << k;



                    key = key | ua;



                    entry.Key = key;
                }




                kk = cc - level;


                kk = kk * jj;



                au = convert.ULong(index);


                au = au << kk;

                


                nn = uu.Value;


                au = au | nn;



                return au;
            }



            i = i + 1;
        }




        return null;
    }

    




    private bool IsBlockEntryArrayUse(BlockEntry[] array, int start, int count)
    {
        Constant constant;

        constant = Constant.This;




        ulong cc;

        cc = constant.BlockEntryKeyAllUse;




        int aa;
        



        ulong a;




        int i;

        i = 0;

        while (i < count)
        {
            aa = start + i;



            a = array[aa].Key;



            if (!(a == cc))
            {
                return false;
            }


            i = i + 1;
        }



        return true;
    }




    private int? GetKeyAvailableBitIndex(ulong key)
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






    public bool Remove(ulong varInt)
    {





        return true;
    }




    private bool RemoveInt(ulong varInt, ref BlockEntry entry, int level, int index)
    {
        Constant constant;

        constant = Constant.This;



        Convert convert;

        convert = Convert.This;




        int cc;

        cc = constant.BlockLevelCount;



        if (level == cc)
        {
            return true;
        }




        int j;

        j = constant.BlockEntryIndexBitCount;




        int k;

        k = cc - 1 - level;


        k = k * j;




        ulong jj;

        jj = convert.ULong(constant.BlockEntryCount);

        jj = jj - 1;




        ulong uu;


        uu = varInt;


        uu = uu >> k;


        uu = uu & jj;




        int aa;

        aa = convert.SInt32(uu);




        BlockEntry[] v;

        v = entry.Value;



        BlockEntry e;


        e = v[aa];


        this.RemoveInt(varInt, ref e, level + 1, aa);


        v[aa] = e;





        ulong key;

        key = entry.Key;




        int uuu;

        uuu = index / constant.BlockEntryKeyBitCount;




        ulong ua;

        ua = 1;
        
        ua = ua << uuu;

        ua = ~ua;



        key = key & ua;


        entry.Key = key;
        



        return true;
    }
}