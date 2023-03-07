namespace Sema.Mode;






public class EntryList : InfraObject
{
    public override bool Init()
    {
        base.Init();




        IntCompare intCompare;

        intCompare = new IntCompare();

        intCompare.Init();



        this.IntMap = new Map();

        this.IntMap.Compare = intCompare;

        this.IntMap.Init();





        NameCompare nameCompare;

        nameCompare = new NameCompare();

        nameCompare.Init();



        this.NameMap = new Map();

        this.NameMap.Compare = nameCompare;

        this.NameMap.Init();




        return true;
    }





    public bool Add(Entry entry)
    {
        Pair pairA;

        pairA = new Pair();

        pairA.Init();

        pairA.Key = entry.Int;

        pairA.Value = entry;



        this.IntMap.Add(pairA);






        Pair pairB;

        pairB = new Pair();

        pairB.Init();

        pairB.Key = entry.Name;

        pairB.Value = entry;



        this.NameMap.Add(pairB);



        return true;
    }





    public Entry IntGet(Int varInt)
    {
        return (Entry)this.IntMap.Get(varInt);
    }






    public Entry NameGet(Name name)
    {
        return (Entry)this.NameMap.Get(name);
    }









    private Map IntMap { get; set; }


    private Map NameMap { get; set; }
}