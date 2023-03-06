namespace Sema.List;





public class List : InfraObject
{
    private ListNode First { get; set; }





    private ListNode Last { get; set; }





    private int ItemCount { get; set; }





    private ListNodeRef NodeRef { get; set; }






    public override bool Init()
    {
        base.Init();




        this.NodeRef = new ListNodeRef();



        this.NodeRef.Init();




        return true;
    }






    public virtual int Count
    {
        get
        {
            return this.ItemCount;
        }

        set
        {

        }
    }






    public virtual object Add(object item)
    {
        ListNode node;




        node = new ListNode();




        node.Init();




        node.Ref = this.NodeRef;




        node.Value = item;





        if (! this.Null(this.Last))
        {

            node.Previous = this.Last;




            this.Last.Next = node;
        }




        if (this.Null(this.First))
        {
            this.First = node;
        }




        
        this.Last = node;





        this.ItemCount = this.ItemCount + 1;





        object ret;



        ret = node;



        return ret;
    }






    public virtual object Insert(object key, object item)
    {
        if (this.Null(key))
        {
            return null;
        }





        ListNode t;




        t = this.Node(key);





        if (this.Null(t))
        {
            return null;
        }





        ListNode node;




        node = new ListNode();




        node.Init();




        node.Ref = this.NodeRef;




        node.Value = item;





        if (this.First == t)
        {
            this.First = node;
        }





        if (! this.Null(t.Previous))
        {
            t.Previous.Next = node;



            node.Previous = t.Previous;
        }





        node.Next = t;



        t.Previous = node;





        this.ItemCount = this.ItemCount + 1;






        object ret;


        ret = node;


        return ret;
    }





    public virtual bool Remove(object key)
    {
        if (this.Null(key))
        {
            return false;
        }





        ListNode node;



        node = this.Node(key);




        if (this.Null(node))
        {
            return false;
        }






        if (this.First == node)
        {
            this.First = node.Next;
        }





        if (this.Last == node)
        {
            this.Last = node.Previous;
        }






        if (! this.Null(node.Next))
        {
            node.Next.Previous = node.Previous;
        }





        if (! this.Null(node.Previous))
        {
            node.Previous.Next = node.Next;
        }






        node.Ref = null;





        this.ItemCount = this.ItemCount - 1;




        return true;
    }





    public virtual bool Clear()
    {
        this.First = null;




        this.Last = null;




        this.ItemCount = 0;





        this.NodeRef = new ListNodeRef();



        this.NodeRef.Init();





        return true;
    }





    public virtual bool Contain(object key)
    {
        if (this.Null(key))
        {
            return false;
        }




        ListNode node;



        node = this.Node(key);




        if (this.Null(node))
        {
            return false;
        }




        return true;
    }







    public virtual object Get(object key)
    {
        if (this.Null(key))
        {
            return null;
        }





        ListNode node;



        node = this.Node(key);





        if (this.Null(node))
        {
            return null;
        }





        object t;


        t = node.Value;




        object ret;


        ret = t;


        return ret;
    }





    public virtual bool Set(object key, object value)
    {
        if (this.Null(key))
        {
            return true;
        }





        ListNode node;



        node = this.Node(key);





        if (this.Null(node))
        {
            return true;
        }






        node.Value = value;




        return true;
    }





    public ListIter Iter()
    {
        ListIter iter;


        iter = new ListIter();




        iter.Init(this.First);





        ListIter ret;


        ret = iter;


        return ret;
    }






    public virtual IIter IIter()
    {
        return this.Iter();
    }






    private ListNode Node(object key)
    {
        bool b;


        b = (key is ListNode);




        if (! b)
        {
            return null;
        }





        ListNode node;



        node = (ListNode)key;






        bool bb;


        bb = (node.Ref == this.NodeRef);




        if (! bb)
        {
            return null;
        }





        ListNode ret;


        ret = node;


        return ret;
    }





    private bool Null(object o)
    {
        return o == null;
    }
}