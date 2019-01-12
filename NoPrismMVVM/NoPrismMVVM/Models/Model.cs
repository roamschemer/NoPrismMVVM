using NoPrismMVVM.Extends;

namespace NoPrismMVVM.Models
{
    public class Model : BindableBase
    {
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        private string name = "Hello!XamarinForms!!!NoPrism!!!";

        /// <summary>
        /// 文字を付与する
        /// </summary>
        /// <param name="s">付与する文字</param>
        public void NamePlus(string s)
        {
            Name = Name + s;
        }
    }
}
