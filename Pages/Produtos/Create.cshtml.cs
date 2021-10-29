using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InDEVstockWebApp.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace InDEVstockWebApp.Pages.Produtos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Produto produtos { get; set; }
        //URL servidor
        string baseUrl = "https://localhost:44356/";
        public async Task<IActionResult> OnPostAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client
                    .PostAsJsonAsync("api/Produtos", produtos);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                }
                else
                {
                    return RedirectToPage("./Create");
                }
            }
        }
    }
}
