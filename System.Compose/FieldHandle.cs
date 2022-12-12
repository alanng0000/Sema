namespace System.Compose;






public class FieldHandle : EventHandle
{
    public Field Field { get; set; }




    public override bool Execute(object arg)
    {
        Change change;

        change = (Change)arg;



        this.Field.Change(change);




        return true;
    }
}