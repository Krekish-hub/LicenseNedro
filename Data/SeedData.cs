using LicenseNedroMVC.Models;

namespace LicenseNedroMVC.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Licenses.Any()) return;

            var licenses = new License[]
            {
                new License {
                    Id = 1,
                    Name = "ООО \"ПОЛЕВАЯ\"",
                    LicenseNumber = "МАГ 02220 БЭ",
                    Location = "р. Сусуман (р.л. 336-508) ниже р.л. 423, за искл.р.л. 384-392, лев. пр. р. Берелех",
                    District = "Ягоднинский городской округ Магаданской области",
                    Activity = "разведка и добыча полезных ископаемых",
                    PositionTop = "80%",
                    PositionLeft = "80%",
                    Latitude = 62.722103m,
                    Longitude = 148.696423m,
                    StartDate = new DateTime(1998, 8, 10),
                    EndDate = new DateTime(2033, 12, 31),
                    MineralType = "Золото",
                    Status = "Действующая",
                    Reserves = "114 кг (С1)",
                    Area = "22,8 км²",
                    Description = "Участок недр имеет отличную транспортную доступность...",
                    Investment = "100 000 000 руб"
                },
            };

            context.Licenses.AddRange(licenses);
            context.SaveChanges();
        }
    }
}