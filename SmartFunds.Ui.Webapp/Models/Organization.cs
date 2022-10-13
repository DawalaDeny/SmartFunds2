using System.ComponentModel.DataAnnotations;

namespace SmartFunds.Ui.Webapp.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string CompanyNumber { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; }

    }
}
