using COVEN.Model;
using COVEN.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVEN.Service
{
    class VendaService
    {
        public Venda getVenda(int codigoVenda)
        {
            DataTable vendaTable = UtilGeral.GetData("SELECT Codigo, IdVendedor, DataSaida, DebitosValores, DebitosCombustivel," +
                "AluguelMaqCartao, CreditosValores, CartaoValor, CartaoNumParcelas, CartaoDataPrimeiroPgto, ChequeValor," +
                " ChequeNumParcelas, ChequeDataPrimeiroPgto, DinheiroValor" +
                " FROM venda WHERE Codigo=" + codigoVenda);

            Venda venda = new Venda();
            venda.idVenda = Int32.Parse(vendaTable.Rows[0]["Codigo"].ToString());
            venda.idVendedor = Int32.Parse(vendaTable.Rows[0]["IdVendedor"].ToString());
            venda.dataSaida = DateTime.Parse(vendaTable.Rows[0]["DataSaida"].ToString());
            venda.setDebitoValores(Decimal.Parse(vendaTable.Rows[0]["DebitosValores"].ToString()));
            venda.setDebitoGasolina(Decimal.Parse(vendaTable.Rows[0]["DebitosCombustivel"].ToString()));
            venda.setAluguelMaquinetaCartao(Decimal.Parse(vendaTable.Rows[0]["AluguelMaqCartao"].ToString()));
            venda.setCreditoValores(Decimal.Parse(vendaTable.Rows[0]["CreditosValores"].ToString()));
            venda.setCartaoValor(Decimal.Parse(vendaTable.Rows[0]["CartaoValor"].ToString()));
            venda.cartaoNumParcelas = Int32.Parse(vendaTable.Rows[0]["CartaoNumParcelas"].ToString());
            venda.setCartaoDataPrimeiroPgto(vendaTable.Rows[0]["CartaoDataPrimeiroPgto"].ToString());
            venda.setChequeValor(Decimal.Parse(vendaTable.Rows[0]["ChequeValor"].ToString()));
            venda.chequeNumParcelas = Int32.Parse(vendaTable.Rows[0]["ChequeNumParcelas"].ToString());
            venda.setChequeDataPrimeiroPgto(vendaTable.Rows[0]["ChequeDataPrimeiroPgto"].ToString());
            venda.setDinheiroValor(Decimal.Parse(vendaTable.Rows[0]["DinheiroValor"].ToString()));

            return venda;
        }

        public void updateVenda(Venda venda)
        {
            List<OleDbParameter> listaParametros = new List<OleDbParameter>()
            {
                new OleDbParameter() {ParameterName = "@IdVendedor", DbType= DbType.Int32, Value = venda.idVendedor},
                new OleDbParameter() {ParameterName = "@DataSaida",  DbType= DbType.DateTime, Value = venda.dataSaida},
                new OleDbParameter() {ParameterName = "@DebitosValores", DbType= DbType.Currency, Value = venda.getDebitoValores()},
                new OleDbParameter() {ParameterName = "@DebitosCombustivel", DbType= DbType.Currency, Value = venda.getDebitoGasolina()},
                new OleDbParameter() {ParameterName = "@AluguelMaqCartao", DbType= DbType.Currency, Value = venda.getAluguelMaquinetaCartao()},
                new OleDbParameter() {ParameterName = "@CreditosValores", DbType= DbType.Currency, Value = venda.getCreditoValores()},
                new OleDbParameter() {ParameterName = "@CartaoValor", DbType= DbType.Currency, Value = venda.getCartaoValor()},
                new OleDbParameter() {ParameterName = "@CartaoNumParcelas", DbType= DbType.Int32, Value = venda.cartaoNumParcelas},
                new OleDbParameter() {ParameterName = "@CartaoDataPrimeiroPgto", DbType= DbType.DateTime, Value = venda.getCartaoDataPrimeiroPgto_DMA()},
                new OleDbParameter() {ParameterName = "@ChequeValor", DbType= DbType.Currency, Value = venda.getChequeValor()},
                new OleDbParameter() {ParameterName = "@ChequeNumParcelas", DbType= DbType.Int32, Value = venda.chequeNumParcelas},
                new OleDbParameter() {ParameterName = "@ChequeDataPrimeiroPgto", DbType= DbType.DateTime, Value = venda.getChequeDataPrimeiroPgto_DMA()},
                new OleDbParameter() {ParameterName = "@DinheiroValor", DbType= DbType.Currency, Value = venda.getDinheiroValor()},
                new OleDbParameter() {ParameterName = "@Codigo", DbType= DbType.Int32, Value = venda.idVenda}
            };

            string sql = "UPDATE venda SET IdVendedor=@IdVendedor,DataSaida=@DataSaida,DebitosValores=@DebitosValores,DebitosCombustivel=@DebitosCombustivel,"+
                "AluguelMaqCartao=@AluguelMaqCartao,CreditosValores=@CreditosValores,CartaoValor=@CartaoValor,CartaoNumParcelas=@CartaoNumParcelas,"+
                "CartaoDataPrimeiroPgto=@CartaoDataPrimeiroPgto,ChequeValor=@ChequeValor,ChequeNumParcelas=@ChequeNumParcelas,"+
                "ChequeDataPrimeiroPgto=@ChequeDataPrimeiroPgto,DinheiroValor=@DinheiroValor" +
                " WHERE Codigo=@Codigo";

            UtilGeral.executeCommand(sql, listaParametros);
        }

        public List<ProdutoVenda> getProdutosVenda(int codigoVenda)
        {
            DataTable vendaTable = UtilGeral.GetData("SELECT Produto.Codigo, Produto.Nome, ProdutosVenda.ValorUnitario, ProdutosVenda.QuantidadeSaida," +
                " ProdutosVenda.QuantidadeRetornada" +
                " FROM Produto INNER JOIN ProdutosVenda ON Produto.Codigo=ProdutosVenda.IdProduto WHERE ProdutosVenda.IdVenda=" + codigoVenda);

            List<ProdutoVenda> listaProdutos = new List<ProdutoVenda>();
            for (int i = 0; i < vendaTable.Rows.Count; i++)
            {
                ProdutoVenda produto = new ProdutoVenda();
                produto.idProduto = Int32.Parse(vendaTable.Rows[i]["Codigo"].ToString());
                produto.nome = vendaTable.Rows[i]["Nome"].ToString();
                produto.valorUnit = Int32.Parse(vendaTable.Rows[i]["ValorUnitario"].ToString());
                produto.quantSaida = Int32.Parse(vendaTable.Rows[i]["QuantidadeSaida"].ToString());
                produto.quantRetorno = Int32.Parse(vendaTable.Rows[i]["QuantidadeRetornada"].ToString());

                listaProdutos.Add(produto);
            }

            return listaProdutos;
        }
    }
}
