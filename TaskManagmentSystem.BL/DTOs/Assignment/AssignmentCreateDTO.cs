namespace TaskManagmentSystem.BL.DTOs.Assignment;

public class AssignmentCreateDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DeadLine { get; set; }
    public HashSet<string> Tags { get; set; }
    public int EmployeeId { get; set; }
}
