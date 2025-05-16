using LicenseNedroMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace LicenseNedroMVC.Data
{
    public class LicenseRepository : ILicenseRepository
    {
        private readonly ApplicationDbContext _context;

        public LicenseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<License> GetAll() => _context.Licenses.ToList();
        public License GetById(int id) => _context.Licenses.FirstOrDefault(l => l.Id == id);
        public void Add(License license) => _context.Licenses.Add(license);
        public void Update(License license) => _context.Licenses.Update(license);
        public void Delete(int id) => _context.Licenses.Remove(GetById(id));
        public bool SaveChanges() => _context.SaveChanges() > 0;
    }
}