namespace System.List;





public class Map : List
{
    private Tree Tree { get; set; }





    public Compare Compare { get; set; }





    private List List { get; set; }






    public override bool Init()
    {
        this.Tree = new Tree();



        this.Tree.Compare = this.Compare;



        this.Tree.Init();





        this.List = new List();



        this.List.Init();




        return true;
    }





    public override object Get(object key)
    {
        if (this.Null(key))
        {
            return null;
        }




        ListNode node;



        node = this.ListNode(key);





        if (this.Null(node))
        {
            return null;
        }





        Pair pair;



        pair = (Pair)node.Value;





        object ret;



        ret = pair.Value;



        return ret;
    }





    public override bool Set(object key, object value)
    {
        if (this.Null(key))
        {
            return true;
        }





        ListNode node;



        node = this.ListNode(key);




        if (this.Null(node))
        {
            return true;
        }





        Pair pair;



        pair = (Pair)node.Value;




        pair.Value = value;
        



        return true;
    }





    private ListNode ListNode(object key)
    {
        Tree.NodeResult t;


        t = this.Tree.Node(key);



        if (!t.HasNode)
        {
            return null;
        }




        ListNode listNode;



        listNode = (ListNode)t.Node.Value;




        ListNode ret;


        ret = listNode;

        
        return ret;
    }






    public override int Count
    {
        get
        {
            return this.List.Count;
        }

        set
        {
        }
    }





    public override object Add(object item)
    {
        if (this.Null(item))
        {
            return null;
        }




        Pair pair;



        pair = this.Pair(item);





        if (this.Null(pair))
        {
            return null;
        }






        ListNode u;



        u = this.ListNode(pair.Key);




        if (!this.Null(u))
        {
            return null;
        }





        object o;



        o = this.List.Add(pair);





        ListNode node;


        node = (ListNode)o;




        this.Tree.Insert(pair.Key, node);





        object ret;


        ret = pair.Key;


        return ret;
    }








    public override object Insert(object key, object item)
    {
        if (this.Null(key))
        {
            return false;
        }




        ListNode node;



        
        node = this.ListNode(key);




        if (this.Null(node))
        {
            return false;
        }







        if (this.Null(item))
        {
            return null;
        }




        Pair pair;



        pair = this.Pair(item);





        if (this.Null(pair))
        {
            return null;
        }






        ListNode u;



        u = this.ListNode(pair.Key);




        if (!this.Null(u))
        {
            return null;
        }





        object o;



        o = this.List.Insert(node, pair);





        ListNode oo;


        oo = (ListNode)o;




        this.Tree.Insert(pair.Key, oo);





        object ret;


        ret = pair.Key;


        return ret;
    }





    public override bool Remove(object key)
    {
        if (this.Null(key))
        {
            return false;
        }




        ListNode node;



        
        node = this.ListNode(key);




        if (this.Null(node))
        {
            return false;
        }





        this.List.Remove(node);





        this.Tree.Remove(key);






        return true;
    }






    public override bool Clear()
    {
        this.Tree.Clear();




        this.List.Clear();





        return true;
    }






    public override bool Contain(object key)
    {
        if (this.Null(key))
        {
            return false;
        }




        ListNode node;


        node = this.ListNode(key);



        bool b;


        b = (! this.Null(node));




        bool ret;


        ret = b;


        return ret;
    }






    public new MapIter Iter()
    {
        ListIter listIter;



        listIter = this.List.Iter();






        MapIter mapIter;



        mapIter = new MapIter();



        mapIter.Init(listIter);





        
        MapIter ret;


        ret = mapIter;


        return ret;
    }







    public override IIter IIter()
    {
        return this.Iter();
    }








    private Pair Pair(object item)
    {
        bool b;


        b = item is Pair;




        if (! b)
        {
            return null;
        }




        Pair pair;


        pair = (Pair)item;



        if (this.Null(pair.Key))
        {
            return null;
        }





        Pair ret;


        ret = pair;


        return ret;
    }





    private bool Null(object o)
    {
        return o == null;
    }
}