using COVEN.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVEN.View
{
    public partial class FormFormaPagamento : Form
    {
        private FormNovaVenda formPai;
        private ListView lv;
        private int selectItem;

        public FormFormaPagamento()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            if (valoresValidados())
            {
                switch (selectItem)
                {
                    //Cartao
                    case 0:
                        //Valor
                        formPai.venda.setCartaoValor(UtilGeral.moedaToDecimal(textBoxValorItem.Text));
                        lv.Items[selectItem].SubItems[1].Text = UtilGeral.decimalToMoeda(formPai.venda.getCartaoValor());
                        //N° Parcelas
                        formPai.venda.cartaoNumParcelas = Int32.Parse(textBoxNumParcelas.Text);
                        lv.Items[selectItem].SubItems[2].Text = textBoxNumParcelas.Text;
                        //1° Mês Ano
                        if (maskedTextBoxMesAno.Text != "  /")
                            formPai.venda.setCartaoDataPrimeiroPgto(DateTime.Now.Day.ToString() + "/" + maskedTextBoxMesAno.Text);
                        lv.Items[selectItem].SubItems[3].Text = maskedTextBoxMesAno.Text;
                        //Valor por parcela
                        lv.Items[selectItem].SubItems[4].Text = formPai.venda.valorParcCartao();
                        //Ultimo Mes Cartão
                        lv.Items[selectItem].SubItems[5].Text = formPai.venda.ultimoMesCartao();
                        break;
                    //Cheque
                    case 1:
                        //Valor
                        formPai.venda.setChequeValor(UtilGeral.moedaToDecimal(textBoxValorItem.Text));
                        lv.Items[selectItem].SubItems[1].Text = UtilGeral.decimalToMoeda(formPai.venda.getChequeValor());
                        //N° Parcelas
                        formPai.venda.chequeNumParcelas = Int32.Parse(textBoxNumParcelas.Text);
                        lv.Items[selectItem].SubItems[2].Text = textBoxNumParcelas.Text;
                        //1° Mês Ano
                        if (maskedTextBoxMesAno.Text != "  /")
                            formPai.venda.setChequeDataPrimeiroPgto(DateTime.Now.Day.ToString() + "/" + maskedTextBoxMesAno.Text);
                        lv.Items[selectItem].SubItems[3].Text = maskedTextBoxMesAno.Text;
                        //Valor por parcela
                        lv.Items[selectItem].SubItems[4].Text = formPai.venda.valorParcCheque();
                        //Ultimo Mes Cheque
                        lv.Items[selectItem].SubItems[5].Text = formPai.venda.ultimoMesCheque();
                        break;
                    //Dinheiro
                    case 2:
                        //Valor
                        formPai.venda.setDinheiroValor(UtilGeral.moedaToDecimal(textBoxValorItem.Text));
                        lv.Items[selectItem].SubItems[1].Text = UtilGeral.decimalToMoeda(formPai.venda.getDinheiroValor());
                        break;
                }


                formPai.labelTotalPagamento.Text = formPai.labelTotalPagamento2.Text = UtilGeral.decimalToMoeda(formPai.venda.somaPagamentosTotais());
                formPai.labelTotalGeral.Text = UtilGeral.decimalToMoeda(formPai.venda.faltaPagar());
                formPai.Enabled = true;
                this.Close();
            }
        }

        private bool valoresValidados()
        {
            bool validado = true;

            //Se for DINHEIRO o item selecionado, então não valida numero de parcelas nem data início
            if (selectItem != 2)
            {
                //N° Parcela
                if (textBoxNumParcelas.Text == "" || textBoxNumParcelas.Text == "0")
                {
                    textBoxNumParcelas.Text = "0";
                    maskedTextBoxMesAno.Text = "";
                }
                else if (Int32.Parse(textBoxNumParcelas.Text) > 8 )
                {
                    validado = false;
                    MessageBox.Show("O número de parcelas não pode ser maior que 8 vezes!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxNumParcelas.Focus();
                }
                //1° Mês Ano
                else
                {
                    //Avalia se a data passada é válida
                    try
                    {
                        DateTime.Parse(maskedTextBoxMesAno.Text);
                    }
                    catch (FormatException fe)
                    {
                        validado = false;
                        string mensagemAmigacel = "A data informada é incorreta!";
                        UtilGeral.escreverLog(mensagemAmigacel, fe.Message);
                        MessageBox.Show(mensagemAmigacel, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        maskedTextBoxMesAno.Focus();
                    }

                    //Avalia se a data passada é maior que a data atual
                    if(validado && DateTime.Parse(DateTime.Now.AddDays(1).Day.ToString() + "/" + maskedTextBoxMesAno.Text) < DateTime.Now)
                    {
                        validado = false;
                        MessageBox.Show("A data informada é menor que a data atual!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        maskedTextBoxMesAno.Focus();
                    }
                    //Os pagamentos poderam ser divididos em: 6 vezes, com 60 dias para começar a pagar, ou 8 vezes, com primeiro pagamento para dentro do mês vigente;
                    else if(Int32.Parse(textBoxNumParcelas.Text) <= 6 && (DateTime.Parse(maskedTextBoxMesAno.Text) > DateTime.Now.AddMonths(2)) )
                    {
                        validado = false;
                        MessageBox.Show("Não é permitido conceder mais de 60 dias de carência", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        maskedTextBoxMesAno.Focus();
                    }
                    else if (Int32.Parse(textBoxNumParcelas.Text) == 7 && (DateTime.Parse(maskedTextBoxMesAno.Text) > DateTime.Now.AddMonths(1)))
                    {
                        validado = false;
                        MessageBox.Show("Não é permitido conceder mais de 30 dias de carência para 7 parcelas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        maskedTextBoxMesAno.Focus();
                    }
                    else if (Int32.Parse(textBoxNumParcelas.Text) == 8 && (DateTime.Parse(maskedTextBoxMesAno.Text) > DateTime.Now))
                    {
                        validado = false;
                        MessageBox.Show("Não é permitido conceder dias de carência para 8 parcelas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        maskedTextBoxMesAno.Focus();
                    }
                }
            }

            return validado;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            formPai.Enabled = true;
            this.Close();
        }

        internal void carregaValores(int selectItem, 
            string valorDebitoCredito, FormNovaVenda formNovaVenda, ListView listView)
        {
            this.selectItem = selectItem;
            labelNomeItem.Text = listView.Items[selectItem].Text;
            textBoxValorItem.Text = valorDebitoCredito;
            this.formPai = formNovaVenda;
            this.lv = listView;

            //desabilita campos desnecessário para o pagamento com dinheiro
            if (selectItem == 2)
            {
                this.labelNumParcelas.Enabled = false;
                this.labelMesAno.Enabled = false;
                this.textBoxNumParcelas.Enabled = false;
                this.maskedTextBoxMesAno.Enabled = false;
            }
            else
            {
                //N° Parcelas
                textBoxNumParcelas.Text = lv.Items[selectItem].SubItems[2].Text;

                //carrega 1° data de pagamento
                if (lv.Items[selectItem].SubItems[3].Text == "  /")
                    this.maskedTextBoxMesAno.Text = DateTime.Now.ToString("MM/yyyy");
                else
                    this.maskedTextBoxMesAno.Text = lv.Items[selectItem].SubItems[3].Text;
            }
        }

        private void textBoxValorItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^0-9^,-^\b^]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        private void textBoxNumParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^0-9^\b^]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
