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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covenDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.covenDataSet.Produto);

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            produtoTableAdapter.Update(covenDataSet);
        }
    }
}
