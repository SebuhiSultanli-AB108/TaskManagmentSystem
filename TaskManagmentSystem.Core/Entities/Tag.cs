namespace TaskManagmentSystem.Core.Entities;

public class Tag : BaseEntity
{
    public string Description { get; set; }
    public ICollection<Assignment> Assignments { get; set; }
}
