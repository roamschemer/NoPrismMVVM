using NoPrismMVVM.Abstracts;
using Reactive.Bindings;
using System;
using Xamarin.Forms;

namespace NoPrismMVVM.ViewModels
{
    public class NextPageViewModel : BindableBase
    {
        public ReactiveCollection<string> ListView { get; set; } = new ReactiveCollection<string>();
        public ReactiveProperty<string> SelectItem { get; set; } = new ReactiveProperty<string>();
        public ReactiveProperty<string> Text { get; set; } = new ReactiveProperty<string>();

        public NextPageViewModel(INavigation navigation)
        {
            ListView = new ReactiveCollection<string>
            {
                "エビのお姉ちゃん","黒羽白砂","おむすび","しーちゃん","木村牡丹","えんむすび","千代家ぷりり",
                "∞(ムゲン)","ユイきゅん","ボス","ジョア","Ｖーン","やまいけさん"
            };

            SelectItem.Subscribe(x => Text.Value = x);
        }
    }
}
