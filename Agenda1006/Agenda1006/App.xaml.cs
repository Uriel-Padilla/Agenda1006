using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agenda1006.View;
using Agenda1006.Service;
namespace Agenda1006
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<ContactoService>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
