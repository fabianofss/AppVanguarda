using AppVanguarda.Helpers;
using AppVanguarda.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppVanguarda.Services
{
    public class RomExchangeAPI
    {         public async Task<List<ItemRom>> GetItensAsync()         {
            List<ItemRom> itens = new List<ItemRom>();

            try
            {
                var httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var response = await httpClient.GetAsync(Constantes.UrlAllItems).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    var resultado = JsonConvert.DeserializeObject<List<ItemRom>>(conteudo);
                    itens = resultado;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return itens;         }     }
}
