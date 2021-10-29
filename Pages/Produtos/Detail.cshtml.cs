using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InDEVstockWebApp.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace InDEVstockWebApp.Pages.Produtos
{
    public class DetailModel : PageModel
    {
        public Produto Produtos { get; set; }
        string baseUrl = "https://localhost:44356/";
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Produtos/" + id);

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    Produtos = JsonConvert.DeserializeObject<Produto>(result);
                }
            }

            return Page();
        }
    }
}
