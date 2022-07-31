using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cbsStudents.Models.Entities;
using CbsStudents.Data;

namespace ExamProject.Controllers
{
    public class WebAPIController : Controller
    {
        
        private CbsStudentsContext _context;

    public WebAPIController(CbsStudentsContext context)
    {
       this._context = context;
    }

    public IActionResult Index(string StudentId = "")
    {
        
        if (StudentId != null && StudentId != "")
        {
            return Redirect($"~/api/students/{StudentId}");
        }

        return View();
    }

    }
}