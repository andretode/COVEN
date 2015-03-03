using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COVEN.Util;

namespace COVEN.Model
{
    public class Venda
    {
        public int idVendedor { get; set; }
        public string nomeVendedor { get; set; }
        public int idVenda { get; set; }
        public DateTime dataSaida { get; set; }
        public List<ProdutoVenda> produtosVenda { get; set; }
        public List<ProdutoVenda> getProdutosVenda() { return produtosVenda; }
        public void setProdutosVenda(List<ProdutoVenda> listaProdutos) { produtosVenda = listaProdutos; }
        private int quantTotalSaida() { return produtosVenda.Sum(x => x.quantSaida); }
        public string quantTotalSaidaToString() { return quantTotalSaida().ToString(); }
        private int quantTotalRetorno() { return produtosVenda.Sum(x => x.quantRetorno); }
        public string quantTotalRetornoToString() { return quantTotalRetorno().ToString(); }
        private int quantTotalVenda() { return quantTotalSaida() - quantTotalRetorno(); }
        public string quantTotalVendaToString() { return quantTotalVenda().ToString(); }
        public int getQuantTotalVenda() { return quantTotalVenda(); }

        private decimal ValorTotalNF() { return produtosVenda.Sum(x => x.valorUnit * x.quantSaida); }
        public string valorTotalNFToMoney() { return UtilGeral.decimalToMoeda(ValorTotalNF()); }
        private decimal ValorTotalVenda() { return produtosVenda.Sum(x => x.valorUnit * (x.quantSaida - x.quantRetorno)); }
        public string valorTotalVendaToMoney() { return UtilGeral.decimalToMoeda(ValorTotalVenda()); }

        //Debitos/Creditos do Vendedor
        private decimal debitoEmValores;
        public void setDebitoValores(decimal debito) { debitoEmValores = Math.Abs(debito); }
        public decimal getDebitoValores() { return debitoEmValores; }

        private decimal debitoEmGasolina;
        public void setDebitoGasolina(decimal debito) { debitoEmGasolina = Math.Abs(debito); }
        public decimal getDebitoGasolina() { return debitoEmGasolina; }

        private decimal aluguelMaquinetaCartao;
        public void setAluguelMaquinetaCartao(decimal debito) { aluguelMaquinetaCartao = Math.Abs(debito); }
        public decimal getAluguelMaquinetaCartao() { return aluguelMaquinetaCartao; }

        private decimal creditoEmValores;
        public void setCreditoValores(decimal credito) { creditoEmValores = Math.Abs(credito) * -1; }
        public decimal getCreditoValores() { return creditoEmValores; }

        public decimal somaDebitosCreditosTotais() { return debitoEmValores + debitoEmGasolina + aluguelMaquinetaCartao + creditoEmValores; }

        //Forma de pagamento
        private decimal valorCartao;
        public void setCartaoValor(decimal valor) { valorCartao = -1 * Math.Abs(valor); }
        public decimal getCartaoValor() { return valorCartao; }

        public int cartaoNumParcelas { get; set; }

        private DateTime priMesAnoCartao;
        public void setCartaoDataPrimeiroPgto(string valor) { priMesAnoCartao = DateTime.Parse(valor); }
        public string getCartaoDataPrimeiroPgto_MA() { return priMesAnoCartao.ToString("MM/yyyy"); }
        public string getCartaoDataPrimeiroPgto_DMA() { return priMesAnoCartao.ToString("dd/MM/yyyy"); }

        private decimal valorCheque;
        public void setChequeValor(decimal valor) { valorCheque = -1 * Math.Abs(valor); }
        public decimal getChequeValor() { return valorCheque; }

        public int chequeNumParcelas { get; set; }

        private DateTime priMesAnoCheque;
        public void setChequeDataPrimeiroPgto(string valor) { priMesAnoCheque = DateTime.Parse(valor); }
        public string getChequeDataPrimeiroPgto_MA() { return priMesAnoCheque.ToString("MM/yyyy"); }
        public string getChequeDataPrimeiroPgto_DMA() { return priMesAnoCheque.ToString("dd/MM/yyyy"); }

        private decimal valorDinheiro;
        public void setDinheiroValor(decimal valor) { valorDinheiro = -1 * Math.Abs(valor); }
        public decimal getDinheiroValor() { return valorDinheiro; }

        public decimal somaPagamentosTotais() { return valorCartao + valorCheque + valorDinheiro; }

        public decimal faltaPagar() { return ValorTotalVenda() + somaDebitosCreditosTotais() + somaPagamentosTotais();  }
        public string valorParcCartao()
        {
            if (cartaoNumParcelas == 0)
                return "0";
            return UtilGeral.decimalToMoeda(valorCartao/cartaoNumParcelas);
        }
        public string valorParcCheque()
        {
            if (chequeNumParcelas == 0)
                return "0";
            return UtilGeral.decimalToMoeda(valorCheque / chequeNumParcelas);
        }
        public string ultimoMesCartao()
        {
            if (cartaoNumParcelas != 0)
                return priMesAnoCartao.AddMonths(cartaoNumParcelas - 1).ToString("MM/yyyy");
            else
                return "--";
        }
        public string ultimoMesCheque()
        {
            if (chequeNumParcelas != 0)
                return priMesAnoCartao.AddMonths(chequeNumParcelas - 1).ToString("MM/yyyy");
            else
                return "--";
        }

        public void incluirProdutoVenda(ProdutoVenda p)
        {
            produtosVenda.Add(p);
        }

        public void removerProdutoVenda(int codigo)
        {
            produtosVenda.Remove(produtosVenda.Find(x => x.idProduto == codigo));
        }

        public Venda()
        {
            produtosVenda = new List<ProdutoVenda>();
        }
    }
}
