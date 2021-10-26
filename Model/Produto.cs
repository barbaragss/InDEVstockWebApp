using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InDEVstockWebApp.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Modelo { get; set; }
        public String Cor { get; set; }
        public int Quantidade { get; set; }
        public char Tamanho { get; set; }
        public String image { get; set; }
    }
}
