namespace Sema.List;






public struct ListIter : IIter
{
    private ListNode CurrentNode { get; set; }




    private ListNode FirstNode { get; set; }




    private bool First { get; set; }





    internal bool Init(ListNode firstNode)
    {
        this.CurrentNode = null;




        this.FirstNode = firstNode;




        this.First = true;




        return true;
    }




    public bool Next()
    {
        if (this.First)
        {
            if (this.Null(this.FirstNode))
            {
                return false;
            }




            this.CurrentNode = this.FirstNode;




            this.First = false;




            return true;
        }





        if (this.Null(this.CurrentNode.Next))
        {
            return false;
        }





        this.CurrentNode = this.CurrentNode.Next;




        return true;
    }




    public object Key
    {
        get
        {
            return this.CurrentNode;
        }
        

        set
        {
        }
    }



    public object Valu
    {
        get
        {
            return this.CurrentNode.Valu;
        }


        set
        {
        }
    }





    private bool Null(object o)
    {
        return o == null;
    }
}