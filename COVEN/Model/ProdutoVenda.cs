using COVEN.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVEN.Model
{
    public class ProdutoVenda
    {
        public int idProduto { get; set; }
        public string nome { get; set; }
        public int quantSaida { get; set; }
        public int quantRetorno { get; set; }
        public int quantVenda() { return quantSaida - quantRetorno; }
        public decimal valorUnit { get; set; }
        public string valorUnitToMoeda() { return UtilGeral.decimalToMoeda(valorUnit); }
        public decimal subtotalNf() { return quantSaida * valorUnit; }
        public string subtotalNfToMoeda() { return UtilGeral.decimalToMoeda(subtotalNf()); }
        public decimal subtotalVenda() { return quantVenda() * valorUnit; }
        public string subtotalVendaToMoeda() { return UtilGeral.decimalToMoeda(subtotalVenda()); }
    }
}
