using smoralesS3A1.Models;
using smoralesS3A1.PageModels;

namespace smoralesS3A1.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}