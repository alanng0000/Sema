namespace Sema.List;





class ListNode : InfraObject
{
    public ListNode Previous { get; set; }






    public ListNode Next { get; set; }






    public ListNodeRef Ref { get; set; }






    public object Value { get; set; }
}