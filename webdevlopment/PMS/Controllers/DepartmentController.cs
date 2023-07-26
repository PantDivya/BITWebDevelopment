using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PMS.Models;

namespace PMS.Controllers;

public class DepartmentController : Controller
{
    static List<Department> departments = new()
        {
            new Department
            {
                Id = 1, Name = "OPD", Description = "It is out patient department", Established = new DateTime(2002,  1,  1)
            },
            new Department
            {
                Id = 2, Name = "Orthopedics", Description = "It is orthopedic department", Established = new DateTime(2005 , 4 , 21)
            },
            new Department
            {
                Id = 1, Name = "Gyno", Description = "It is Gyno department", Established = new DateTime(2007 , 11 , 12)
            }
        };
    
    [HttpGet]
    public IActionResult Index()
    {
        //Fetch list of department
        return View(departments);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Department department)
    {
        departments.Add(department);
        return RedirectToAction("Index");
    }

   
}
