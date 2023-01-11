namespace System.Comp;






public class FieldHandle : Handle
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