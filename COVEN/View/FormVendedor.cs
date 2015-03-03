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
    public partial class FormVendedor : Form
    {
        public FormVendedor()
        {
            InitializeComponent();
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covenDataSet1.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter.Fill(this.covenDataSet1.Vendedor);

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            vendedorTableAdapter.Update(covenDataSet1);
        }

    }
}
