namespace LicenseNedroMVC.Models;

public class Deposit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string License { get; set; }
    public string Location { get; set; }
    public string District { get; set; }
    public string Activity { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Type { get; set; }
    public string Status { get; set; } // "Действующая", "Заявка", "Приостановлена"
    public string Reserves { get; set; }
    public string Area { get; set; }
    public string Description { get; set; }
    public decimal Investment { get; set; }
    public string AssignedUserId { get; set; }
}