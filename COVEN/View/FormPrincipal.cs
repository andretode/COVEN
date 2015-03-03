using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVEN.View
{
    public partial class FormPrincipal : Form
    {
        FormProduto formProduto;
        FormVendedor formVendedor;
        FormNovaVenda formNovaVenda;
        FormListarVendas formListarVendas;
        public FormPrincipal formPrincipal;

        public FormPrincipal()
        {
            InitializeComponent();
            formPrincipal = this;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formProduto == null)
            {
                formProduto = new FormProduto();
            }
            else if (!formProduto.Created)
            {
                formProduto = new FormProduto();
            }
            formProduto.MdiParent = this;
            formProduto.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formVendedor == null || !formVendedor.Created)
            {
                formVendedor = new FormVendedor();
            }
            formVendedor.MdiParent = this;
            formVendedor.Show();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formNovaVenda == null || !formNovaVenda.Created)
            {
                formNovaVenda = new FormNovaVenda();
            }
            formNovaVenda.MdiParent = this;
            formNovaVenda.Show();
        }

        private void listaSaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formListarVendas == null || !formListarVendas.Created)
            {
                formListarVendas = new FormListarVendas();
            }
            formListarVendas.MdiParent = this;
            formListarVendas.Show();
        }
    }
}
