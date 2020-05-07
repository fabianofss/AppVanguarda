using AppVanguarda.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppVanguarda
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListaItensPage : ContentPage
    {
        private ListaItensViewModel ViewModel => BindingContext as ListaItensViewModel;
        public ListaItensPage()
        {
            InitializeComponent();
            this.BindingContext = new ListaItensViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ViewModel.LoadAsync();

        }
    }
}
