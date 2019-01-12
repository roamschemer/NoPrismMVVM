using NoPrismMVVM.Models;
using Reactive.Bindings;
using System;
using Reactive.Bindings.Extensions;
using Xamarin.Forms;
using NoPrismMVVM.Abstracts;

namespace NoPrismMVVM.ViewModels
{
    public class MainPageViewModel : BindableBase
    {

        public ReactiveProperty<string> Label1 { get; private set; }
        public ReactiveCommand<string> Button1 { get; } = new ReactiveCommand<string>();
        public ReactiveCommand<string> Button2 { get; } = new ReactiveCommand<string>();
        public ReactiveCommand<string> Button3 { get; } = new ReactiveCommand<string>();
        public ReactiveCommand<string> Button4 { get; } = new ReactiveCommand<string>();
        public ReactiveCommand<string> Button5 { get; } = new ReactiveCommand<string>();

        public ReactiveCommand NextPageButton { get; } = new ReactiveCommand();
        public Model model = new Model();

        public MainPageViewModel(INavigation navigation)
        {
            //Model→ViewModel
            this.Label1 = model.ObserveProperty(x => x.Name).ToReactiveProperty();
            //Button
            Button1.Subscribe(x => model.NamePlus(x));
            Button2.Subscribe(x => model.NamePlus(x));
            Button3.Subscribe(x => model.NamePlus(x));
            Button4.Subscribe(x => model.NamePlus(x));
            Button5.Subscribe(x => model.NamePlus(x));
            //Button(ページ遷移)
            NextPageButton.Subscribe(async _ => await navigation.PushAsync(new Views.NextPageView())); 
        }
    }
}
