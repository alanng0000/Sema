namespace System.View;




public class Grid : View
{
    public override bool Init()
    {
        base.Init();




        this.RowsField = new Field();


        this.RowsField.Object = this;


        this.RowsField.Init();




        this.ColsField = new Field();


        this.ColsField.Object = this;


        this.ColsField.Init();




        this.ChildsField = new Field();


        this.ChildsField.Object = this;


        this.ChildsField.Init();





        List rows;

        rows = new List();

        rows.Init();



        this.Rows = rows;




        List cols;

        cols = new List();

        cols.Init();



        this.Cols = cols;




        List childs;

        childs = new List();

        childs.Init();



        this.Childs = childs;
        



        return true;
    }




    public virtual Field RowsField { get; set; }




    public virtual List Rows
    {
        get
        {
            return (List)this.RowsField.Get();
        }

        set
        {
            this.RowsField.Set(value);
        }
    }





    protected virtual bool ChangeRows(Change change)
    {
        if (this.Null(this.Rows) | this.Null(this.Cols) | this.Null(this.Childs))
        {
            return true;
        }




        this.UpdateLayout();




        this.Trigger(this.RowsField);



        return true;
    }





    public virtual Field ColsField { get; set; }




    public virtual List Cols
    {
        get
        {
            return (List)this.ColsField.Get();
        }

        set
        {
            this.ColsField.Set(value);
        }
    }





    protected virtual bool ChangeCols(Change change)
    {
        if (this.Null(this.Rows) | this.Null(this.Cols) | this.Null(this.Childs))
        {
            return true;
        }




        this.UpdateLayout();
        



        this.Trigger(this.ColsField);



        return true;
    }




    public virtual Field ChildsField { get; set; }




    public virtual List Childs
    {
        get
        {
            return (List)this.ChildsField.Get();
        }

        set
        {
            this.ChildsField.Set(value);
        }
    }





    protected virtual bool ChangeChilds(Change change)
    {
        if (this.Null(this.Rows) | this.Null(this.Cols) | this.Null(this.Childs))
        {
            return true;
        }



        bool ba;

        
        ba = false;



        bool bb;


        bb = false;



        ListChange t;

        t = null;



        if (change is ListChange)
        {
            t = (ListChange)change;


            ba = (t.Kind == ListChangeKinds.This.Item);


            bb = (t.Kind == ListChangeKinds.This.Add);
        }



        if (ba)
        {
            return true;
        }




        if (bb)
        {
            GridChild child;
            
            
            child = (GridChild)t.Item;



            this.AddGridChild(child);
        }



        if (!bb)
        {
            this.UpdateLayout();
        }
        



        this.Trigger(this.ChildsField);



        return true;
    }





    private bool UpdateLayout()
    {
        this.SetChildLeftArray();



        this.SetChildUpArray();



        this.SetChildControls();



        return true;
    }






    private bool SetChildControls()
    {
        IEnumerator enumerator;


        enumerator = this.Internal.Controls.GetEnumerator();



        while (enumerator.MoveNext())
        {
            ViewControl control;


            control = (ViewControl)enumerator.Current;


            control.View.Clip = false;
        }






        this.Internal.Controls.Clear();





        ListIter iter;


        iter = this.Childs.Iter();





        while (iter.Next())
        {
            GridChild child;


            child = (GridChild)iter.Value;




            this.AddGridChild(child);
        }




        return true;
    }





    protected virtual bool AddGridChild(GridChild child)
    {
        GridRange range;


        range = child.Range;




        if (!this.CheckRange(range))
        {
            return true;
        }




        GridPos start;


        start = range.Start;




        GridPos end;


        end = range.End;





        int left;


        left = this.GridColLeft(start.Col);

        


        int up;


        up = this.GridRowUp(start.Row);




        int right;


        right = this.GridColLeft(end.Col);




        int down;


        down = this.GridRowUp(end.Row);
        




        int width;


        width = right - left;



        int height;


        height = down - up;







        View view;



        view = child.View;














        return true;
    }





    protected virtual bool CheckRange(GridRange range)
    {
        GridPos start;


        start = range.Start;




        GridPos end;


        end = range.End;




        bool baa;

        baa = start.Row < this.Rows.Count;



        bool bab;

        bab = this.Rows.Count < end.Row;



        bool bac;


        bac = end.Row < start.Row;




        bool ba;


        ba = baa & !bab & !bac;





        bool bba;

        bba = start.Col < this.Cols.Count;



        bool bbb;

        bbb = this.Cols.Count < end.Col;



        bool bbc;


        bbc = end.Col < start.Col;




        bool bb;


        bb = bba & !bbb & !bbc;
        



        bool ret;
        
        ret = ba & bb;


        return ret;
    }





    private int GridColLeft(int col)
    {
        return this.GridPosPixelPos(col, this.ChildLeftArray);
    }



    private int GridRowUp(int row)
    {
        return this.GridPosPixelPos(row, this.ChildUpArray);
    }




    private int GridPosPixelPos(int pos, int[] pixelPosArray)
    {
        int t;


        t = pos;



        bool b;



        int u;


        u = 0;




        b = (t < 1);


        if (!b)
        {
            t = t - 1;


            u = pixelPosArray[t];
        }
        


        int ret;

        ret = u;


        return ret;
    }







    private bool SetChildLeftArray()
    {
        this.ChildLeftArray = new int[this.Cols.Count];




        ListIter iter;


        iter = this.Cols.Iter();




        int left;


        left = 0;



        int i;


        i = 0;


        while (iter.Next())
        {
            GridCol gridCol;


            gridCol = (GridCol)iter.Value;



            left = left + gridCol.Width;



            this.ChildLeftArray[i] = left;



            global::System.Console.Write("Grid SetChildLeftArray()" + ", " + "left" + ": " + left + "\n");



            i = i + 1;
        }



        return true;
    }






    private bool SetChildUpArray()
    {
        this.ChildUpArray = new int[this.Rows.Count];




        ListIter iter;


        iter = this.Rows.Iter();




        int up;


        up = 0;



        int i;


        i = 0;


        while (iter.Next())
        {
            GridRow gridRow;


            gridRow = (GridRow)iter.Value;



            up = up + gridRow.Height;



            this.ChildUpArray[i] = up;



            global::System.Console.Write("Grid SetChildUpArray()" + ", " + "up" + ": " + up + "\n");




            i = i + 1;
        }



        return true;
    }






    private int[] ChildLeftArray { get; set; }



    private int[] ChildUpArray { get; set; }





    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);




        if (this.RowsField == field)
        {
            this.ChangeRows(change);
        }


        if (this.ColsField == field)
        {
            this.ChangeCols(change);
        }


        if (this.ChildsField == field)
        {
            this.ChangeChilds(change);
        }



        return true;
    }





    
    public override View Child
    {
        get
        {
            return null;
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