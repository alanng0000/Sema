namespace System.View;




public class ListEventHandle : EventHandle
{
    public virtual List List { get; set; }



    public override bool Execute(object arg)
    {
        Change change;

        change = (Change)arg;




        CompObject item;

        item = change.Object;


        this.List.ItemChange(item);

        


        return true;
    }
}