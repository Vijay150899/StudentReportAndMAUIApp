public partial class MainPage : ContentPage
{
    private ProductService _productService = new ProductService();

    public MainPage()
    {
        InitializeComponent();
        LoadProducts();
    }

    private async void LoadProducts()
    {
        var products = await _productService.GetProductsAsync();
        ProductsCollectionView.ItemsSource = products;
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Product selectedProduct)
        {
            await Shell.Current.GoToAsync($"productdetails?id={selectedProduct.Id}");
        }
    }
}
