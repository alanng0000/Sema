namespace System.View;




public class Grid : View
{
    public override bool Init()
    {
        base.Init();




        this.RowField = new Field();


        this.RowField.Object = this;


        this.RowField.Init();




        this.ColsField = new Field();


        this.ColsField.Object = this;


        this.ColsField.Init();




        this.ChildsField = new Field();


        this.ChildsField.Object = this;


        this.ChildsField.Init();





        List row;

        row = new List();

        row.Init();



        this.Row = row;




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




    public virtual Field RowField { get; set; }




    public virtual List Row
    {
        get
        {
            return (List)this.RowField.Get();
        }

        set
        {
            this.RowField.Set(value);
        }
    }





    protected virtual bool ChangeRow(Change change)
    {
        if (this.Null(this.Row) | this.Null(this.Cols) | this.Null(this.Childs))
        {
            return true;
        }




        this.UpdateLayout();




        this.Trigger(this.RowField);



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
        if (this.Null(this.Row) | this.Null(this.Cols) | this.Null(this.Childs))
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
        if (this.Null(this.Row) | this.Null(this.Cols) | this.Null(this.Childs))
        {
            return true;
        }

        



        this.Trigger(this.ChildsField);



        return true;
    }






    protected override bool ExecuteChildDraw(DrawDraw draw)
    {
        if (this.Null(this.Childs))
        {
            return true;
        }






        int left;
        
        left = this.Pos.Left;



        int up;

        up = this.Pos.Up;



        left = left + draw.Pos.Left;


        up = up + draw.Pos.Up;




        int width;

        width = this.Size.Width;



        int height;

        height = this.Size.Height;




        DrawPos pos;

        pos = new DrawPos();

        pos.Init();

        pos.Left = left;

        pos.Up = up;




        DrawRect rect;

        rect = new DrawRect();

        rect.Init();

        rect.Pos.Left = left;

        rect.Pos.Up = up;

        rect.Size.Width = width;

        rect.Size.Height = height;




        DrawRect u;

        u = draw.Area;



        this.DrawInfra.BoundArea(u, ref rect);






        DrawPos un;

        un = draw.Pos;





        draw.Pos = pos;




        draw.Area = rect;



        draw.SetClip();








        ListIter iter;


        iter = this.Childs.Iter();





        while (iter.Next())
        {
            GridChild child;


            child = (GridChild)iter.Value;




            this.DrawGridChild(draw, child);
        }






        draw.Pos = un;



        draw.Area = u;



        draw.SetClip();





        return true;
    }






    private bool UpdateLayout()
    {
        this.SetChildLeftArray();



        this.SetChildUpArray();




        return true;
    }







    protected virtual bool DrawGridChild(DrawDraw draw, GridChild child)
    {
        View view;



        view = child.View;




        if (this.Null(view))
        {
            return true;
        }




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





        left = left + draw.Pos.Left;


        up = up + draw.Pos.Up;



    


        DrawPos pos;

        pos = new DrawPos();

        pos.Init();

        pos.Left = left;

        pos.Up = up;







        DrawRect rect;

        rect = new DrawRect();

        rect.Init();

        rect.Pos.Left = left;

        rect.Pos.Up = up;

        rect.Size.Width = width;

        rect.Size.Height = height;




        DrawRect u;

        u = draw.Area;




        this.DrawInfra.BoundArea(u, ref rect);






        DrawPos un;

        un = draw.Pos;





        draw.Pos = pos;




        draw.Area = rect;



        draw.SetClip();








        view.ExecuteDraw(draw);








        draw.Pos = un;




        draw.Area = u;



        draw.SetClip();







        return true;
    }







    protected virtual bool CheckRange(GridRange range)
    {
        GridPos start;


        start = range.Start;




        GridPos end;


        end = range.End;




        bool baa;

        baa = start.Row < this.Row.Count;



        bool bab;

        bab = this.Row.Count < end.Row;



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



            //global::System.Console.Write("Grid SetChildLeftArray()" + ", " + "left" + ": " + left + "\n");



            i = i + 1;
        }



        return true;
    }






    private bool SetChildUpArray()
    {
        this.ChildUpArray = new int[this.Row.Count];




        ListIter iter;


        iter = this.Row.Iter();




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



            //global::System.Console.Write("Grid SetChildUpArray()" + ", " + "up" + ": " + up + "\n");




            i = i + 1;
        }



        return true;
    }






    private int[] ChildLeftArray { get; set; }



    private int[] ChildUpArray { get; set; }





    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);




        if (this.RowField == field)
        {
            this.ChangeRow(change);
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
}