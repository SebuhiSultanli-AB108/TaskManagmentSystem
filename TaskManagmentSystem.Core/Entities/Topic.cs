namespace TaskManagmentSystem.Core.Entities;

public class Topic : BaseEntity
{
    public string Description { get; set; }
    public int AssignmentId { get; set; }
    public Assignment Assignment { get; set; }
}