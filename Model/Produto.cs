using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InDEVstockWebApp.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Quantidade { get; set; }
        public string Tamanho { get; set; }
        public string imageUrl { get; set; }
    }
}
