namespace TaskManagmentSystem.Core.Entities;

public class Assignment : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DeadLine { get; set; }
    public ICollection<Tag> Tags { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}