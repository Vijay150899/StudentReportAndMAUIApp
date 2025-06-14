[QueryProperty(nameof(ProductId), "id")]
public partial class ProductDetailsPage : ContentPage
{
    private ProductService _productService = new ProductService();

    public int ProductId { get; set; }

    public ProductDetailsPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var product = await _productService.GetProductByIdAsync(ProductId);
        ProductImage.Source = product.Image;
        ProductTitle.Text = product.Title;
        ProductPrice.Text = $"Price: {product.Price:C}";
        ProductDescription.Text = product.Description;
    }
}
