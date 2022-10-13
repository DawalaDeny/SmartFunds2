using SmartFunds.Ui.Webapp.Models;

namespace SmartFunds.Ui.Webapp.Data
{
    public class SmartFundsDatabase
    {
        public IList<Organization> Organizations { get; set; } = new List<Organization>();

        public void Seed()
        {
            Organizations = new List<Organization>
            {
                new()
                {
                    Id = 1,
                    Name = "Vives",
                    Type = "School",
                    CompanyNumber = "123-456-789"
                },
                new()
                {
                    Id = 2,
                    Name = "Club Brugge",
                    Type = "Soccer Club",
                    CompanyNumber = "123-456-780"
                },
                new()
                {
                    Id = 3,
                    Name = "Badmintonclub Kortrijk",
                    Type = "Badminton",
                    CompanyNumber = "123-456-788"
                },
                new()
                {
                    Id = 4,
                    Name = "De Lustige Darters",
                    Type = "Zwemclub",
                    CompanyNumber = "123-456-782"
                }
            };
        }
    }
}
