using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LicenseNedroMVC.Models
{
    public class License
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string LicenseNumber { get; set; }

        [Required]
        public string Location { get; set; }

        public string District { get; set; }

        public string Activity { get; set; }

        [Column(TypeName = "decimal(10, 6)")]
        public decimal Latitude { get; set; }

        [Column(TypeName = "decimal(10, 6)")]
        public decimal Longitude { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public string MineralType { get; set; } // Тип полезного ископаемого

        [Required]
        public string Status { get; set; }

        public string Reserves { get; set; } // Запасы
        public string Area { get; set; } // Площадь
        public string Description { get; set; }
        public string Investment { get; set; }
        
        [Required]
        public string PositionTop { get; set; } = "50%"; // Значение по умолчанию
    
        [Required]
        public string PositionLeft { get; set; } = "50%"; // Значение по умолчанию
    }
}