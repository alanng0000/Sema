namespace Sema.Module;






public class EntryLoad : InfraObject
{
    private string EntryFilePath { get; set; }






    public EntryList List { get; set; }







    private int Row { get; set; }




    private string[] LineList { get; set; }


    



    public override bool Init()
    {
        base.Init();





        Path path;

        path = Path.This;




        this.EntryFilePath = SystemPath.Combine(path.Root, path.EntryName);




        return true;
    }






    public bool Execute()
    {
        string[] u;

        u = File.ReadAllLines(this.EntryFilePath);




        this.LineList = u;



        int rowCount;


        rowCount = this.LineList.Length;





        this.Row = 0;




        while (this.Row < rowCount)
        {
            this.ExecuteRow();
        }




        return true;
    }




    private bool ExecuteRow()
    {
        string s;


        s = this.LineList[this.Row];




        string line;

        line = s;




        InfraConvert convert;

        convert = InfraConvert.This;




        ulong k;

        k = convert.ULong(this.Row);



        ulong index;

        index = k;





        Int varInt;

        varInt = new Int();

        varInt.Init();

        varInt.Value = index;




        Name name;

        name = new Name();

        name.Init();

        name.Value = line;





        Entry entry;

        entry = new Entry();

        entry.Init();

        entry.Int = varInt;

        entry.Name = name;




        this.List.Add(entry);
        





        this.Row = this.Row + 1;





        return true;
    }
}