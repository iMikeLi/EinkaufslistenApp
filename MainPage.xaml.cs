using EinkaufslistenApp.ViewModels;

namespace EinkaufslistenApp
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel viewModel = new();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void OnAddProductClicked(object sender, EventArgs e)
        {
            viewModel.AddProduct(ProductEntry.Text);
            ProductEntry.Text = string.Empty;
        }
    }
}
