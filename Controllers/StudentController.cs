using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using BLL;
using BOL;

namespace Portal.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
    public IActionResult Base()
    {
        CatlogManager man=new CatlogManager();
        List<Student> allstudents=man.Getallstudent();
        this.ViewData["Student"]=allstudents;
        return View();
    }
}