namespace POSTGESQLCRUD.DAL.Data;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int DepartmentId { get; set; }

    public Department? Department { get; set; }

}
