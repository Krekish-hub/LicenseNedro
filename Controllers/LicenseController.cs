using LicenseNedroMVC.Data;
using LicenseNedroMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LicenseNedroMVC.Controllers
{
    public class LicenseController : Controller
    {
        private readonly ILicenseRepository _repository;

        public LicenseController(ILicenseRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var licenses = _repository.GetAll();
            return View(licenses);
        }

        public IActionResult Detail(int id)
        {
            var license = _repository.GetById(id);
            if (license == null) return NotFound();
            
            return View(license);
        }
        
        [HttpGet]
        public IActionResult Filter(string mineralType, string status)
        {
            var query = _repository.GetAll();

            if (!string.IsNullOrEmpty(mineralType))
                query = query.Where(l => l.MineralType == mineralType);

            if (!string.IsNullOrEmpty(status))
                query = query.Where(l => l.Status == status);

            return PartialView("_LicenseListPartial", query.ToList());
        }
    }
}