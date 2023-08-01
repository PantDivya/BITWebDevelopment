using PMS.Enums;

namespace PMS.Models;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime Dob { get; set; }
    public string Contact { get; set; }
    public Gender Gender { get; set; }
    public Doctor? Doctor { get; set; }
    public int DoctorId { get; set; }
}
