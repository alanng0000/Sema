namespace System.Module;




class CountByteOp : ByteOp
{
    public Write Write { get; set; }



    public override bool Execute(byte ob)
    {
        int k;


        k = this.Write.Index;



        k = k + 1;



        this.Write.Index = k;



        return true;
    }
}