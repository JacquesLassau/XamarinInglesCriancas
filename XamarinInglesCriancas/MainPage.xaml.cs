using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;


namespace XamarinInglesCriancas
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCores());
        }

        private void btnNumeros_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageNumeros());
        }

        private void btnFamilia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageFamilia());
        }

        private void btnSair_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Device.BeginInvokeOnMainThread(async () =>
                //{ 
                //    var result = await DisplayAlert("Alerta", "Deseja realmente Sair?", "Sim", "Não");
                //    if (result)
                //    {
                //        #if __ANDROID__
                //            var activit = (Android.App.Activit)Forms.Context;
                //            activit.FinishAffinity();
                //        #endif

                //        #if __IOS__
                //            Thread.CurrentThread.Abort();
                //        #endif
                //    }

                //});

                //DependencyService.Get<ICloseApplication>().closeApplication();

                bool result = Convert.ToBoolean(DisplayAlert("Alerta", "Deseja realmente Sair?", "Sim", "Não"));
                if (result)
                {
                    //Process.GetCurrentProcess().CloseMainWindow(); Apenas Fecha a aplicação
                    Process.GetCurrentProcess().Kill(); // Encerra a aplicação
                }
            }
            catch
            {
                DisplayAlert("Alerta", "Ocorreu um problema ao tentar fechar o aplicativo.", "OK");
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
