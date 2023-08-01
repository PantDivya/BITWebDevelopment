using Microsoft.EntityFrameworkCore;
using PMS.Models;
using System.Net;

namespace PMS.Database;

public class PMSDbContext: DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Diagnosis> Diagnoses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PMS_db;Integrated Security=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }
    public DbSet<PMS.Models.Patient> Patient { get; set; } = default!;

}
