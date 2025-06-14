using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class ProductViewModel : INotifyPropertyChanged
{
    private readonly ProductService _productService = new ProductService();

    public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

    public ProductViewModel()
    {
        LoadProducts();
    }

    private async void LoadProducts()
    {
        var products = await _productService.GetProductsAsync();
        foreach (var product in products)
        {
            Products.Add(product);
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
