using DemoBlazorApp.Components.Models;
using Microsoft.AspNetCore.Components;

namespace DemoBlazorApp.Components.Pages
{
    public partial class ProductAdd
    {

        [Parameter]
        public Guid? Id { get; set; }

        private Product product;

    }
}
