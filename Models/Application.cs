using System.ComponentModel.DataAnnotations;

namespace LicenseNedroMVC.Models
{
    public class Application
    {
        public int Id { get; set; }
        
        [Required]
        public int LicenseId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [Phone]
        public string Phone { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}