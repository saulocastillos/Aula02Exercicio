using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aula02Exercicio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CodePlusXamlPage();
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
