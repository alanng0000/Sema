namespace Sema.Mode;




class WriteByteOp : ByteOp
{
    public Write Write { get; set; }



    public override bool Execute(byte ob)
    {
        byte[] o;


        o = this.Write.Data.Valu;


        

        int k;


        k = this.Write.Index;




        o[k] = ob;





        k = k + 1;



        this.Write.Index = k;



        return true;
    }
}