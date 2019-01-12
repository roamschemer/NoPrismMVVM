using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoPrismMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MainPageViewModel(this.Navigation); //繋げるViewModelクラスを指定する
        }
    }
}