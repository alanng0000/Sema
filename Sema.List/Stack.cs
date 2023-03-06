namespace Sema.List;





public class Stack : List
{
    private ListNode LastNode { get; set; }



    public override bool Init()
    {
        base.Init();



        this.LastNode = null;



        return true;
    }





    public override object Add(object item)
    {
        return null;
    }





    public override bool Remove(object key)
    {
        return false;
    }





    public virtual object Top
    {
        get
        {
            if (this.Empty())
            {
                return null;
            }



            object ret;


            ret = this.LastNode.Value;


            return ret;
        }

        set
        {
        }
    }




    public virtual bool Push(object item)
    {
        object o;


        o = base.Add(item);



        if (o == null)
        {
            return false;
        }




        ListNode node;


        node = (ListNode)o;



        this.LastNode = node;



        return true;
    }




    public virtual bool Pop()
    {
        if (this.Empty())
        {
            return false;
        }




        ListNode node;


        node = this.LastNode.Previous;





        bool b;


        b = base.Remove(this.LastNode);



        if (!b)
        {
            return false;
        }




        this.LastNode = node;



        return true;
    }




    private bool Empty()
    {
        return (this.Count == 0);
    }
}