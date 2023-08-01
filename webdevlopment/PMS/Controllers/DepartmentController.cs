using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PMS.Database;
using PMS.Models;

namespace PMS.Controllers;

public class DepartmentController : Controller
{
    PMSDbContext db = new();


    [HttpGet]
    public IActionResult Index()
    {
        //Fetch list of department
        var departments = db.Departments.ToList();
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
        db.Departments.Add(department);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpPost]
    public IActionResult Edit(Department department)
    {
        db.Departments.Update(department);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var department = db.Departments.Find(id);
        return View(department);
    }

    [HttpPost]
    public IActionResult Delete(Department department)
    {
        db.Departments.Remove(department);
        db.SaveChanges();
        return RedirectToAction("Index");
    }


}
