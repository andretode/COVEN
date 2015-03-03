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
    public partial class FormDebitoVendedor : Form
    {
        private FormNovaVenda formPai;
        private ListView lv;
        private int selectItem;

        public FormDebitoVendedor()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            switch (selectItem)
            {
                case 0:
                    formPai.venda.setDebitoValores(UtilGeral.moedaToDecimal(textBoxValorItem.Text));
                    lv.Items[selectItem].SubItems[1].Text = UtilGeral.decimalToMoeda(formPai.venda.getDebitoValores());
                    break;
                case 1:
                    formPai.venda.setDebitoGasolina(UtilGeral.moedaToDecimal(textBoxValorItem.Text));
                    lv.Items[selectItem].SubItems[1].Text = UtilGeral.decimalToMoeda(formPai.venda.getDebitoGasolina());
                    break;
                case 2:
                    formPai.venda.setAluguelMaquinetaCartao(UtilGeral.moedaToDecimal(textBoxValorItem.Text));
                    lv.Items[selectItem].SubItems[1].Text = UtilGeral.decimalToMoeda(formPai.venda.getAluguelMaquinetaCartao());
                    break;
                case 3:
                    formPai.venda.setCreditoValores(UtilGeral.moedaToDecimal(textBoxValorItem.Text));
                    lv.Items[selectItem].SubItems[1].Text = UtilGeral.decimalToMoeda(formPai.venda.getCreditoValores());
                    break;
            }

            formPai.labelTotalDebitos.Text = formPai.labelTotalDebitos2.Text = UtilGeral.decimalToMoeda(formPai.venda.somaDebitosCreditosTotais());
            formPai.labelTotalGeral.Text = UtilGeral.decimalToMoeda(formPai.venda.faltaPagar());
            formPai.Enabled = true;
            this.Close();
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
        }

        private void textBoxValorItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"[^0-9^,-^\b^]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
