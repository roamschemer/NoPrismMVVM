using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoPrismMVVM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageView : ContentPage
	{
		public MainPageView ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.MainPageViewModel(); //繋げるViewModelクラスを指定する
        }
	}
}