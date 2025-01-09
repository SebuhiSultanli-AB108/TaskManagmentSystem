namespace TaskManagmentSystem.Entities;

public class Employee : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public decimal Salary { get; set; }
}
