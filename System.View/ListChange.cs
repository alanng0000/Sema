namespace Sema.View;



public class ListChange : Change
{
    public virtual List List { get; set; }



    public virtual ListChangeKind Kind { get; set; }




    public virtual CompObject Item { get; set; }
}