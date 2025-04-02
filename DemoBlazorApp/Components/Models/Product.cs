using System.ComponentModel.DataAnnotations;

namespace DemoBlazorApp.Components.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Id is Require")]
        public Guid Id { get; set; } = new Guid();

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Require")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is Require")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is Require")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Dealer is Require")]
        public int DealerId { get; set; }

        [Required(ErrorMessage = "CreateOn is Require")]
        public DateTime CreateOn { get; set; }

        [Required(ErrorMessage = "Status is Require")]
        public bool Status { get; set; }
    }
}
