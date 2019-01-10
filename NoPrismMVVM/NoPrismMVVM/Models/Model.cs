using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NoPrismMVVM.Models
{
    public class Model : INotifyPropertyChanged
    {
        //https://blog.okazuki.jp/entry/2015/02/22/212827
        //かずきさんのとこで見つけた書き方。Prismの場合SetPropertyが内包されている
        public event PropertyChangedEventHandler PropertyChanged;
        private void SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            if (object.Equals(field, value)) { return; }
            field = value;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //いつもの
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
