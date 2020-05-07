using AppVanguarda.Models;
using AppVanguarda.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace AppVanguarda.ViewModel
{
    class ListaItensViewModel : BaseViewModel
    {
        public ObservableCollection<ItemRom> Itens { get; }

        private RomExchangeAPI _romExchangeAPI;

        public ListaItensViewModel()
        {
            Titulo = "Itens Ragnarok M";

            Itens = new ObservableCollection<ItemRom>();
            _romExchangeAPI = new RomExchangeAPI();

        }

        public override async Task LoadAsync()
        {
            Ocupado = true;
            try
            {
                var listaItens = await _romExchangeAPI.GetItensAsync();

                Itens.Clear();

                foreach (var item in listaItens)
                {
                    item.UrlImagem = "https://static.poporing.life/items/" + item.name.Replace(" ","_").ToLower() + ".png";
                    Itens.Add(item);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro", ex.Message);
            }
            finally
            {
                Ocupado = false;
            }

        }
    }
}
