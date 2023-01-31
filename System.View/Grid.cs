namespace System.View;




public class Grid : View
{
    public override bool Init()
    {
        base.Init();




        this.RowField = new Field();


        this.RowField.Object = this;


        this.RowField.Init();




        this.ColField = new Field();


        this.ColField.Object = this;


        this.ColField.Init();




        this.ChildField = new Field();


        this.ChildField.Object = this;


        this.ChildField.Init();





        this.DestField = new Field();


        this.DestField.Object = this;


        this.DestField.Init();






        List row;

        row = new List();

        row.Init();



        this.Row = row;




        List col;

        col = new List();

        col.Init();



        this.Col = col;




        List child;

        child = new List();

        child.Init();



        this.Child = child;
        




        Rect dest;

        dest = new Rect();

        dest.Init();


        this.Dest = dest;






        this.ChildPosList = new IntList();


        this.ChildPosList.Init();





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
        if (this.Null(this.Row) | this.Null(this.Col) | this.Null(this.Child))
        {
            return true;
        }




        this.UpdateLayout();




        this.Trigger(this.RowField);



        return true;
    }





    public virtual Field ColField { get; set; }




    public virtual List Col
    {
        get
        {
            return (List)this.ColField.Get();
        }

        set
        {
            this.ColField.Set(value);
        }
    }





    protected virtual bool ChangeCol(Change change)
    {
        if (this.Null(this.Row) | this.Null(this.Col) | this.Null(this.Child))
        {
            return true;
        }




        this.UpdateLayout();
        



        this.Trigger(this.ColField);



        return true;
    }




    public new virtual Field ChildField { get; set; }




    public new virtual List Child
    {
        get
        {
            return (List)this.ChildField.Get();
        }

        set
        {
            this.ChildField.Set(value);
        }
    }





    protected new virtual bool ChangeChild(Change change)
    {
        if (this.Null(this.Row) | this.Null(this.Col) | this.Null(this.Child))
        {
            return true;
        }

        



        this.Trigger(this.ChildField);



        return true;
    }






    public virtual Field DestField { get; set; }




    public virtual Rect Dest
    {
        get
        {
            return (Rect)this.DestField.Get();
        }
        set
        {
            this.DestField.Set(value);
        }
    }





    protected virtual bool ChangeDest(Change change)
    {
        this.Trigger(this.DestField);



        return true;
    }







    protected override bool DrawChild(DrawDraw draw)
    {
        if (this.Null(this.Child))
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



        DrawInfra infra;

        infra = DrawInfra.This;


        infra.BoundArea(u, ref rect);






        DrawPos un;

        un = draw.Pos;





        draw.Pos = pos;




        draw.Area = rect;



        draw.Clip();








        ListIter iter;


        iter = this.Child.Iter();





        while (iter.Next())
        {
            GridChild child;


            child = (GridChild)iter.Value;




            this.DrawGridChild(draw, child);
        }






        draw.Pos = un;



        draw.Area = u;



        draw.Clip();





        return true;
    }






    private bool UpdateLayout()
    {
        int count;

        count = this.Col.Count + this.Row.Count;




        this.ChildPosList.SetCount(count);





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



        DrawInfra infra;

        infra = DrawInfra.This;


        infra.BoundArea(u, ref rect);






        DrawPos un;

        un = draw.Pos;





        draw.Pos = pos;




        draw.Area = rect;



        draw.Clip();








        view.Draw(draw);








        draw.Pos = un;




        draw.Area = u;



        draw.Clip();







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

        bba = start.Col < this.Col.Count;



        bool bbb;

        bbb = this.Col.Count < end.Col;



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
        return this.GridPosPixelPos(col, 0);
    }



    private int GridRowUp(int row)
    {
        return this.GridPosPixelPos(row, this.Col.Count);
    }




    private int GridPosPixelPos(int pos, int start)
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


            int index;

            index = start + t;


            u = this.ChildPosList.Data[index];
        }
        


        int ret;

        ret = u;


        return ret;
    }







    private bool SetChildLeftArray()
    {
        int start;

        start = 0;




        ListIter iter;


        iter = this.Col.Iter();




        int left;


        left = 0;



        int i;


        i = 0;


        while (iter.Next())
        {
            GridCol gridCol;


            gridCol = (GridCol)iter.Value;



            left = left + gridCol.Width;



            int index;

            index = start + i;



            this.ChildPosList.Data[index] = left;




            i = i + 1;
        }



        return true;
    }






    private bool SetChildUpArray()
    {
        int start;

        start = this.Col.Count;




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



            int index;

            index = start + i;



            this.ChildPosList.Data[index] = up;




            i = i + 1;
        }



        return true;
    }







    private IntList ChildPosList { get; set; }







    public override bool Change(Field field, Change change)
    {
        base.Change(field, change);




        if (this.RowField == field)
        {
            this.ChangeRow(change);
        }


        if (this.ColField == field)
        {
            this.ChangeCol(change);
        }


        if (this.ChildField == field)
        {
            this.ChangeChild(change);
        }



        return true;
    }
}