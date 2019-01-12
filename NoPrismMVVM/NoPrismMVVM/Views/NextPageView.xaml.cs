using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoPrismMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPageView : ContentPage
    {
        public NextPageView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.NextPageViewModel(this.Navigation); //繋げるViewModelクラスを指定する
        }
    }
}