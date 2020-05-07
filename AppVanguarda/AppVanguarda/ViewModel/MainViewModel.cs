using AppVanguarda.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AppVanguarda.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        public ObservableCollection<ItemRom> Itens { get; }

        public MainViewModel()
        {
            Titulo = "Vanguarda/Ragnarok M";
        }

        public override async Task LoadAsync()
        {
            Ocupado = true;
            Ocupado = false;

        }
    }
}
