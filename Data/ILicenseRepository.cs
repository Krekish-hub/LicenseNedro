using LicenseNedroMVC.Models;
using System.Collections.Generic;

namespace LicenseNedroMVC.Data
{
    public interface ILicenseRepository
    {
        IEnumerable<License> GetAll();
        License GetById(int id);
        void Add(License license);
        void Update(License license);
        void Delete(int id);
        bool SaveChanges();
    }
}