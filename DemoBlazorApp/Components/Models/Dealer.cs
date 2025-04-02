namespace DemoBlazorApp.Components.Models
{
    public class Dealer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Dealer> GetDealers() => new()
        {
            new Dealer()
            {
                Id = Guid.Parse("9fa67a48-3f8d-49ee-915f-bf29527ac90c"),
                Name = "Dealer 1"

            },
            new Dealer()
            {
                Id = Guid.Parse("4466fc16-c80e-47a5-b139-6788c47ae48e"),
                Name = "Dealer 2"
            },
            new Dealer()
            {
                Id = Guid.Parse("28212a09-017a-477d-90ac-238940e52620"),
                Name = "Dealer 3"
            }
        };
    }
}
