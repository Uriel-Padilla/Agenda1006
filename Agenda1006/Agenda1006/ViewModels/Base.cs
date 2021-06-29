using Agenda1006.Models;
using Agenda1006.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Agenda1006.ViewModels
{
    public class Base : INotifyPropertyChanged
    {
        public IContactoService<ContactoModel> contactoService => DependencyService.Get<IContactoService<ContactoModel>>();
        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }
        string titulo = string.Empty;
        public string Titulo
        {
            get { return titulo; }
            set { SetProperty(ref titulo, value); }
        }
        protected bool SetProperty<T>(ref T backingStore, T value,[CallerMemberName] string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;
            backingStore = value;
            onChanged?.Invoke();
            onPropertyChanged(propertyName);
            return true;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
