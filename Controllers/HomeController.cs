using System.Diagnostics;
using LicenseNedroMVC.Data;
using Microsoft.AspNetCore.Mvc;
using LicenseNedroMVC.Models;

namespace LicenseNedroMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILicenseRepository _repository;

    public HomeController(ILicenseRepository repository)
    {
        _repository = repository;
    }
    public IActionResult Index()
    {
        var licenses = _repository.GetAll().ToList();
        return View(licenses);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
        
    [HttpGet]
    public IActionResult Filter(string mineralType, string status)
    {
        var query = _repository.GetAll();
    
        if (!string.IsNullOrEmpty(mineralType))
            query = query.Where(l => l.MineralType == mineralType);
    
        if (!string.IsNullOrEmpty(status))
            query = query.Where(l => l.Status == status);
    
        return PartialView("Index", query.ToList());
    }
}