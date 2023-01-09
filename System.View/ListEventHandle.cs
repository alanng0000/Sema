namespace System.View;




public class ListEventHandle : EventHandle
{
    public virtual List List { get; set; }



    public override bool Execute(object arg)
    {
        Change change;

        change = (Change)arg;




        ComposeObject o;

        o = change.Object;


        this.List.ItemChange(o);


        return true;
    }
}