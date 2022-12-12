namespace System.List;






public struct StackIter : IIter
{
    private ListNode CurrentNode { get; set; }




    private ListNode LastNode { get; set; }




    private bool Last { get; set; }





    internal bool Init(ListNode lastNode)
    {
        this.CurrentNode = null;




        this.LastNode = lastNode;




        this.Last = true;




        return true;
    }




    public bool Next()
    {
        if (this.Last)
        {
            if (this.Null(this.LastNode))
            {
                return false;
            }




            this.CurrentNode = this.LastNode;




            this.Last = false;




            return true;
        }





        if (this.Null(this.CurrentNode.Previous))
        {
            return false;
        }





        this.CurrentNode = this.CurrentNode.Previous;




        return true;
    }






    public object Key
    {
        get
        {
            return null;
        }

        set
        {
        }
    }





    public object Value
    {
        get
        {
            return this.CurrentNode.Value;
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