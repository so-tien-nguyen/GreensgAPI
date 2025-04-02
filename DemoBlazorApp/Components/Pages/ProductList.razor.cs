using DemoBlazorApp.Components.Models;

namespace DemoBlazorApp.Components.Pages
{
    public partial class ProductList
    {
        private bool isAlertVisible = false;
        private Product product { get; set; } = new Product();
        private List<Product> products { get; set; } = new List<Product>();
        private List<Dealer> dealers = new Dealer().GetDealers();


        public void RemoveItem(Guid? id)
        {
            var index = products.FindIndex(x => x.Id == id);
            if (index == -1)
            {
                ShowAlert();
                return;
            }
            products.RemoveAt(index);
           
        }

        public void AddProduct()
        {
            
        }

        public void ShowAlert()
        {
            isAlertVisible = true;
        }
        public void HideAlert()
        {
            isAlertVisible = false;
        }
    }
}
