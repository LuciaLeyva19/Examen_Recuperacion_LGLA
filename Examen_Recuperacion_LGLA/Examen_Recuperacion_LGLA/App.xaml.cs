using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen_Recuperacion_LGLA.VistaModelo;
using Examen_Recuperacion_LGLA.Vista;
using Examen_Recuperacion_LGLA;
namespace Examen_Recuperacion_LGLA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vista.Page1());
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
