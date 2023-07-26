using Microsoft.AspNetCore.Mvc;

public class TestContrller : Controller 
{
    public string Hello()
    {
        return "Hello";
    }

    public DateTime CurrentTime()
    {
        return DateTime.Now;
    } 

    public IActionResult ListPeople()
    {
        return View();
    }
}