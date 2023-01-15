namespace System.Draw;





public class Infra : InfraObject
{
    public bool BoundArea(Rect bound, ref Rect area)
    {
        int left;

        left = area.Pos.Left;



        int up;

        up = area.Pos.Up;




        int width;

        width = area.Size.Width;



        int height;

        height = area.Size.Height;




        int right;

        right = left + width;



        int down;

        down = up + height;





        int boundRight;

        boundRight = bound.Pos.Left + bound.Size.Width;



        int boundDown;

        boundDown = bound.Pos.Up + bound.Size.Height;





        if (left < bound.Pos.Left)
        {
            left = bound.Pos.Left;
        }



        if (up < bound.Pos.Up)
        {
            up = bound.Pos.Up;
        }





        if (boundRight < right)
        {
            right = boundRight;
        }



        if (boundDown < down)
        {
            down = boundDown;
        }




        IntOp intOp;

        intOp = IntOp.This;




        int w;


        w = intOp.Sub(right, left);





        int h;


        h = intOp.Sub(down, up);





        area.Pos.Left = left;


        area.Pos.Up = up;


        area.Size.Width = w;


        area.Size.Height = h;




        return true;
    }
}