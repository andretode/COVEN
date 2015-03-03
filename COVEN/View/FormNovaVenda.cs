using COVEN.Model;
using COVEN.Service;
using COVEN.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVEN.View
{
    public partial class FormNovaVenda : Form
    {
        public Venda venda;
        bool alterarVenda = false;
        AutoCompleteStringCollection colecaoProdutos = new AutoCompleteStringCollection();
        FormDebitoVendedor formDebitoVendedor;
        FormFormaPagamento formFormaPagamento;

        public FormNovaVenda()
        {
            InitializeComponent();
        }

        private void FormNovaVenda_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'covenDataSet.ProdutosVenda' table. You can move, or remove it, as needed.
            this.produtosVendaTableAdapter.Fill(this.covenDataSet.ProdutosVenda);
            // TODO: This line of code loads data into the 'covenDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.covenDataSet.Produto);
            // TODO: This line of code loads data into the 'covenDataSet.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter.Fill(this.covenDataSet.Vendedor);

            //Prepara o campo Vendedor para autocompletar na pesquisa
            BindingSource bsVendedores = new BindingSource();
            bsVendedores.DataSource = this.covenDataSet.Vendedor.Where(x => x.Ativo == true).OrderBy(x => x.Nome).ToList();
            comboBoxVendedor.DataSource = bsVendedores.DataSource;
            comboBoxVendedor.DisplayMember = "Nome";
            comboBoxVendedor.ValueMember = "Codigo";
            comboBoxVendedor.SelectedItem = null;

            //Prepara o campo Produto para autocompletar na pesquisa
            var produtos = this.covenDataSet.Produto.Select(x => x.Nome);
            foreach (string nome in produtos)
            {
                colecaoProdutos.Add(nome.ToUpper());
            }
            textBoxProduto.AutoCompleteCustomSource = colecaoProdutos;

            //Seta a data de hoje
            maskedTextBoxDataSaida.Text = DateTime.Today.GetDateTimeFormats('d')[0];

            if (venda == null)
                venda = new Venda();
            else
            {
                if (!carregaVenda())
                    this.Close();
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string msg = validarInsercaoProduto();
            if (msg == "")
            {
                adicionaProdutoVenda();
                limpaCamposProduto();
                atualizaTotalizadorVenda();
            }
            else
                MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool produtoJaAdicionado(string nomeProduto)
        {
            var l = listViewProdutos.FindItemWithText(nomeProduto);
            if (l != null)
                return true;
            else
                return false;
        }

        private void adicionaProdutoVenda()
        {

            COVEN.covenDataSet.ProdutoRow pr = this.covenDataSet.Produto.Where(x =>
                x.Nome.ToUpper() == textBoxProduto.Text.ToUpper()).First();

            ProdutoVenda produto = new ProdutoVenda
            {
                idProduto = pr.Codigo,
                nome = textBoxProduto.Text.ToUpper(),
                quantSaida = (int)quantSaida.Value,
                quantRetorno = (int)quantRetorno.Value,
                valorUnit = pr.Valor
            };
            venda.incluirProdutoVenda(produto);

            string[] row = { produto.idProduto.ToString(), produto.nome, produto.quantSaida.ToString(),
                            produto.quantRetorno.ToString(), produto.quantVenda().ToString(),
                            produto.valorUnitToMoeda(), produto.subtotalNfToMoeda(),
                            produto.subtotalVendaToMoeda()
                        };
            var listViewItem = new ListViewItem(row);
            listViewProdutos.Items.Add(listViewItem);
        }

        private string validarInsercaoProduto()
        {
            if (textBoxProduto.Text == "")
                return "Nenhum produto foi selecionado";

            if (!colecaoProdutos.Contains(textBoxProduto.Text.ToUpper()))
                return "Você está tentado adicionar um produto que não está cadastrado no sistema.";

            if (produtoJaAdicionado(textBoxProduto.Text.ToUpper()))
                return "Este produto já foi adicionado";

            if (quantSaida.Value < 1)
                return "A quantidade de saída deve ser maior que zero";

            if (quantRetorno.Value > quantSaida.Value)
                return "A quantidade de retorno não pode ser maior que a quantidade de saída.";
            
            return "";
        }

        private void limpaCamposProduto()
        {
            textBoxProduto.Clear();
            quantSaida.Value = 0;
            quantRetorno.Value = 0;
        }

        private void atualizaTotalizadorVenda()
        {
            labelQuantTotalSaida.Text = venda.quantTotalSaidaToString();
            labelQuantTotalRetorno.Text = venda.quantTotalRetornoToString();
            labelQuantTotalVenda.Text = venda.quantTotalVendaToString();
            labelValorTotalNF.Text = venda.valorTotalNFToMoney();
            labelValorTotalVenda.Text = labelTotalVenda2.Text = venda.valorTotalVendaToMoney();
            labelTotalGeral.Text = UtilGeral.decimalToMoeda(venda.faltaPagar());
            labelTotalPagamento.Text = labelTotalPagamento2.Text = UtilGeral.decimalToMoeda(venda.somaPagamentosTotais());
            labelTotalDebitos.Text = labelTotalDebitos2.Text = UtilGeral.decimalToMoeda(venda.somaDebitosCreditosTotais());
        }

        private void listViewDebitos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (formDebitoVendedor == null)
                formDebitoVendedor = new FormDebitoVendedor();
            else if (!formDebitoVendedor.Created)
                formDebitoVendedor = new FormDebitoVendedor();
            formDebitoVendedor.carregaValores(listViewDebitos.SelectedItems[0].Index,
                listViewDebitos.SelectedItems[0].SubItems[1].Text, this, listViewDebitos);
            formDebitoVendedor.Show();
            this.Enabled = false;
        }

        private void listViewFormaPagamento_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (formDebitoVendedor == null)
                formFormaPagamento = new FormFormaPagamento();
            else if (!formDebitoVendedor.Created)
                formFormaPagamento = new FormFormaPagamento();
            formFormaPagamento.carregaValores(listViewFormaPagamento.SelectedItems[0].Index,
                listViewFormaPagamento.SelectedItems[0].SubItems[1].Text, this, listViewFormaPagamento);
            formFormaPagamento.Show();
            this.Enabled = false;
        }

        private void buttonFecharVenda_Click(object sender, EventArgs e)
        {
            if (validarFechamentoVenda())
            {
                salvarVenda();

                MessageBox.Show("Venda salva com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoverProduto_Click(object sender, EventArgs e)
        {
            removerProduto();
        }

        private void salvarVenda()
        {
            venda.idVendedor= Int32.Parse(this.comboBoxVendedor.SelectedValue.ToString());
            venda.dataSaida = DateTime.Parse(this.maskedTextBoxDataSaida.Text);

            if (!alterarVenda)
            {
                this.vendaTableAdapter.Insert(venda.idVendedor, venda.dataSaida, venda.getDebitoValores(), venda.getDebitoGasolina(), venda.getAluguelMaquinetaCartao(),
                venda.getCreditoValores(), venda.getCartaoValor(), 
                venda.cartaoNumParcelas, DateTime.Parse(venda.getCartaoDataPrimeiroPgto_DMA()), venda.getChequeValor(), venda.chequeNumParcelas,
                DateTime.Parse(venda.getChequeDataPrimeiroPgto_DMA()), venda.getDinheiroValor());

                //Pega o codigo da venda inserida para ligar aos produtos vendidos
                string codigoVenda = this.vendaTableAdapter.SelectIdentity().ToString();

                List<ProdutoVenda> listaProdutos = this.venda.getProdutosVenda();
                for (int i = 0; i < listaProdutos.Count; i++)
                {
                    var novoProdutosVenda = this.covenDataSet.ProdutosVenda.NewProdutosVendaRow();
                    novoProdutosVenda.IdProduto = listaProdutos[i].idProduto;
                    novoProdutosVenda.IdVenda = Int32.Parse(codigoVenda);
                    novoProdutosVenda.ValorUnitario = listaProdutos[i].valorUnit;
                    novoProdutosVenda.QuantidadeSaida = listaProdutos[i].quantSaida;
                    novoProdutosVenda.QuantidadeRetornada = listaProdutos[i].quantRetorno;
                    this.covenDataSet.ProdutosVenda.Rows.Add(novoProdutosVenda);
                }
            }
            else
            {
                VendaService vs = new VendaService();
                vs.updateVenda(venda);
            }

            this.produtosVendaTableAdapter.Update(this.covenDataSet.ProdutosVenda);
        }

        private bool validarFechamentoVenda()
        {
            if (comboBoxVendedor.SelectedValue == null)
            {
                MessageBox.Show("O vendedor não foi informado!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxVendedor.Focus();
                return false;
            }
            if (listViewProdutos.Items.Count == 0)
            {
                MessageBox.Show("Nenhum produto adicionado à venda!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (listViewFormaPagamento.Items.Count == 0)
            {
                MessageBox.Show("Nenhuma forma de pagamento adicionada!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (venda.faltaPagar() != 0)
            {
                MessageBox.Show("A soma da venda, débitos/créditos e pagamentos não estão fechando!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Avalia se item selecionado foi relativo a cobrança de aluguel da maquineta de cartao e se deve ser cobrado aluguel conforme o numero de peças vendidos
            int quantVendaMinima = 20;
            if (venda.getQuantTotalVenda() >= quantVendaMinima && venda.getAluguelMaquinetaCartao() > 0)
            {
                MessageBox.Show("Cobra-se aluguel somente de vendas menores de " + quantVendaMinima + " peças!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (venda.getQuantTotalVenda() < quantVendaMinima && venda.getAluguelMaquinetaCartao() <= 0)
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Deseja continuar sem cobrar o aluguel da maquineta de cartão?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.No)
                    return false;
            }

            return true;
        }

        private void removerProduto()
        {
            if (listViewProdutos.SelectedItems.Count > 0)
            {
                int codigo = Int32.Parse(listViewProdutos.SelectedItems[0].SubItems[0].Text);
                listViewProdutos.Items.Remove(listViewProdutos.SelectedItems[0]);
                venda.removerProdutoVenda(codigo);
                atualizaTotalizadorVenda();
            }
        }

        public void setVenda(Venda v)
        {
            venda = v;
            alterarVenda = true; //Informa que está em modo de alteração e não de novo cadastro para alterar o comportamento da ação no banco.
        }

        private bool carregaVenda()
        {
            try
            {
                this.Text = buttonFecharVenda.Text = "Alterar Venda";
                this.maskedTextBoxDataSaida.Text = venda.dataSaida.ToString();
                this.comboBoxVendedor.SelectedValue = venda.idVendedor;

                //Debitos
                listViewDebitos.Items[0].SubItems[1].Text = UtilGeral.strToMoeda(venda.getDebitoValores().ToString()); //Debitos em valores
                listViewDebitos.Items[1].SubItems[1].Text = UtilGeral.strToMoeda(venda.getDebitoGasolina().ToString()); //Debitos em combustivel
                listViewDebitos.Items[2].SubItems[1].Text = UtilGeral.strToMoeda(venda.getAluguelMaquinetaCartao().ToString()); //Aluguel maquineta cartao
                listViewDebitos.Items[3].SubItems[1].Text = UtilGeral.strToMoeda(venda.getCreditoValores().ToString()); //Creditos em valores

                //Forma de pagamento
                listViewFormaPagamento.Items[0].SubItems[1].Text = UtilGeral.strToMoeda(venda.getCartaoValor().ToString()); //Cartao
                listViewFormaPagamento.Items[0].SubItems[2].Text = venda.cartaoNumParcelas.ToString(); //Cartao Parcela
                listViewFormaPagamento.Items[0].SubItems[3].Text = venda.getCartaoDataPrimeiroPgto_MA().ToString(); //Cartao Data Inicio
                listViewFormaPagamento.Items[1].SubItems[1].Text = UtilGeral.strToMoeda(venda.getChequeValor().ToString()); //Cheque
                listViewFormaPagamento.Items[1].SubItems[2].Text = venda.chequeNumParcelas.ToString(); //Cheque Parcela
                listViewFormaPagamento.Items[1].SubItems[3].Text = venda.getChequeDataPrimeiroPgto_MA().ToString(); //Cheque Data Inicio
                listViewFormaPagamento.Items[2].SubItems[1].Text = UtilGeral.strToMoeda(venda.getDinheiroValor().ToString()); //Dinheiro

                //Atualiza lista de produtos da venda
                List<ProdutoVenda> listaProdutos = venda.getProdutosVenda();
                for (int i = 0; i < listaProdutos.Count; i++)
                {
                    ProdutoVenda produto = listaProdutos[i];

                    string[] row = { produto.idProduto.ToString(), produto.nome, produto.quantSaida.ToString(),
                            produto.quantRetorno.ToString(), produto.quantVenda().ToString(),
                            produto.valorUnitToMoeda(), produto.subtotalNfToMoeda(),
                            produto.subtotalVendaToMoeda()
                        };
                    var listViewItem = new ListViewItem(row);
                    listViewProdutos.Items.Add(listViewItem);
                }

                //por fim atualiza os totais nos labels
                atualizaTotalizadorVenda();
            }
            catch(Exception ex){
                string msg = "Um erro ocorreu ao tentar carregar a venda de código " + venda.idVenda + ". Favor anotar o código da venda, os passos realizados até o erro e entrar em contato com o administrador do sistema.";
                UtilGeral.escreverLog(msg, ex.Message);
                MessageBox.Show(msg,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void buttonGeraNota_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Produto.Codigo as idProduto, Produto.nome as nome, QuantidadeSaida as quantRetorno, QuantidadeRetornada as quantSaida, ValorUnitario as valorUnit" +
                " FROM ProdutosVenda INNER JOIN Produto ON ProdutosVenda.idProduto=Produto.Codigo WHERE IdVenda=" + venda.idVenda;
            DataTable dtProdutosVenda = UtilGeral.GetData(sql);

            sql = "SELECT Venda.Codigo as idVenda, Vendedor.Nome as nomeVendedor, Venda.DataSaida"+
            " FROM Venda INNER JOIN Vendedor ON Vendedor.Codigo=Venda.idVendedor WHERE Venda.Codigo=" + venda.idVenda;
            DataTable dtVenda = UtilGeral.GetData(sql);

            FormRelatorioNotaVenda formRelatorioNotaVenda = new FormRelatorioNotaVenda();
            formRelatorioNotaVenda.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rdsProdutosVenda = new ReportDataSource("ModelProdutosVenda", dtProdutosVenda);
            formRelatorioNotaVenda.reportViewer1.LocalReport.DataSources.Add(rdsProdutosVenda);
            ReportDataSource rdsVenda = new ReportDataSource("ModelVenda", dtVenda);
            formRelatorioNotaVenda.reportViewer1.LocalReport.DataSources.Add(rdsVenda);

            formRelatorioNotaVenda.reportViewer1.RefreshReport();
            formRelatorioNotaVenda.MdiParent = this.MdiParent;
            formRelatorioNotaVenda.Show();
        }

        private void gerarRelatorioPdf()
        {
            ReportViewer rv = new ReportViewer();
            rv.ProcessingMode = ProcessingMode.Local;
            rv.LocalReport.ReportEmbeddedResource = "COVEN.View.ReportNotaVenda.rdlc";

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytePDF = rv.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);
            FileStream fsPdf = null;
            string nomeArquivoPdf = Path.GetTempPath() + "nota-venda-coven" + ".pdf"; //+ venda.idVenda.ToString() + ".pdf";
            fsPdf = new FileStream(nomeArquivoPdf, FileMode.Create);
            fsPdf.Write(bytePDF, 0, bytePDF.Length);
            fsPdf.Close();
            Process.Start(nomeArquivoPdf);
        }
    }
}
