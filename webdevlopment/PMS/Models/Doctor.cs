using PMS.Enums;

namespace PMS.Models;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Contact { get; set; }
    public string Specialist { get; set; }
    public Credential Credentials { get; set; }
    public Department? Department { get; set; }
    public int DepartmentId { get; set; }
}
