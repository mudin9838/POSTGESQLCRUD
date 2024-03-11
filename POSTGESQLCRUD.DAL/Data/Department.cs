namespace POSTGESQLCRUD.DAL.Data;

public class Department
{
    public int Id { get; set; }

    public string DepartmentName { get; set; }

    public ICollection<Student>? student { get; set; }


}
