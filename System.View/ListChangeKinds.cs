namespace System.View;


public class ListChangeKinds : InfraObject
{
    public static ListChangeKinds This { get; } = CreateGlobal();




    private static ListChangeKinds CreateGlobal()
    {
        ListChangeKinds global;

        global = new ListChangeKinds();

        global.Init();


        return global;
    }







    public virtual ListChangeKind Add { get { return this.AddData; } set {} }


    public virtual ListChangeKind Insert { get { return this.InsertData; } set {} }


    public virtual ListChangeKind Remove { get { return this.RemoveData; } set {} }


    public virtual ListChangeKind Clear { get { return this.ClearData; } set {} }


    public virtual ListChangeKind Set { get { return this.SetData; } set {} }


    public virtual ListChangeKind Item { get { return this.ItemData; } set {} }




    private ListChangeKind AddData { get; set; }

    private ListChangeKind InsertData { get; set; }

    private ListChangeKind RemoveData { get; set; }

    private ListChangeKind ClearData { get; set; }

    private ListChangeKind SetData { get; set; }


    private ListChangeKind ItemData { get; set; }





    public override bool Init()
    {
        base.Init();




        this.AddData = this.CreateKind();


        this.InsertData = this.CreateKind();


        this.RemoveData = this.CreateKind();


        this.ClearData = this.CreateKind();


        this.SetData = this.CreateKind();


        this.ItemData = this.CreateKind();



        return true;
    }




    private ListChangeKind CreateKind()
    {
        ListChangeKind t;

        t = new ListChangeKind();

        t.Init();



        ListChangeKind ret;

        ret = t;

        return ret;
    }
}