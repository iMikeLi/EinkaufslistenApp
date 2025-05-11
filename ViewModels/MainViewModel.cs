using System.Collections.ObjectModel;
using EinkaufslistenApp.Models;

namespace EinkaufslistenApp.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Product> Products { get; set; } = new();

        public void AddProduct(string productName)
        {
            if (!string.IsNullOrWhiteSpace(productName))
            {
                Products.Add(new Product { Name = productName, IsBought = false });
            }
        }
    }
}
