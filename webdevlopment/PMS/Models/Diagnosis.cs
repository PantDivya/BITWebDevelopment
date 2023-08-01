namespace PMS.Models;

    public class Diagnosis
    {
    public int Id { get; set; }
    public string Problem { get; set; }
    public string Description { get; set; }
    public string Medication { get; set; }
    public Patient? Patients { get; set; }
    public int PatientId { get; set; }
}

