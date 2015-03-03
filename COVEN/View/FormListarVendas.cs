using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using COVEN.Util;
using COVEN.Model;
using COVEN.Service;

namespace COVEN.View
{
    public partial class FormListarVendas : Form
    {

        
        public FormListarVendas()
        {
            InitializeComponent();
        }

        private void FormListarVendas_Load(object sender, EventArgs e)
        {

            comboBoxFiltro.SelectedIndex = Constantes.ULTIMOS_30_DIAS;
            carregarVendas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            abrirVenda();
        }

        private void buttonAbrirVenda_Click(object sender, EventArgs e)
        {
            abrirVenda();
        }

        private void abrirVenda()
        {
            int codigoVenda = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            VendaService vs = new VendaService();
            Venda venda = vs.getVenda(codigoVenda);
            List<ProdutoVenda> listaProdutos = vs.getProdutosVenda(codigoVenda);
            venda.setProdutosVenda(listaProdutos);
            FormNovaVenda formNovaVenda = new FormNovaVenda();
            formNovaVenda.MdiParent = this.MdiParent;
            formNovaVenda.setVenda(venda);
            formNovaVenda.Show();
            this.Close();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarVendas();
        }

        private void carregarVendas()
        {
            DateTime dataInicio = DateTime.Now.AddMonths(-1); //ULTIMOS_30_DIAS
            switch (comboBoxFiltro.SelectedIndex)
            {
                case Constantes.ULTIMOS_2_MESES:
                    dataInicio = DateTime.Now.AddMonths(-2);
                    break;
                case Constantes.ULTIMOS_4_MESES:
                    dataInicio = DateTime.Now.AddMonths(-4);
                    break;
                case Constantes.ULTIMOS_6_MESES:
                    dataInicio = DateTime.Now.AddMonths(-6);
                    break;
                case Constantes.ULTIMOS_12_MESES:
                    dataInicio = DateTime.Now.AddMonths(-12);
                    break;
            }

            List<OleDbParameter> listaParametros = new List<OleDbParameter>()
            {
                new OleDbParameter() { ParameterName = "@DataSaida", DbType = DbType.DateTime, Value = dataInicio.ToShortDateString() }
            };
            string sql = @"SELECT Venda.Codigo AS [Código], Venda.DataSaida AS [Data], Vendedor.Nome AS Vendedor
            FROM Venda INNER JOIN Vendedor ON Venda.IdVendedor = Vendedor.Codigo
            WHERE Venda.DataSaida >= @DataSaida ORDER BY Venda.DataSaida DESC";
            DataTable table = UtilGeral.executeCommandReader(sql, listaParametros);
            if (table == null)
            {
                MessageBox.Show("Não foi possível recuperar as informações no banco de dados. Favor anotar os passos executados até este" + 
                    "passos executados até este erro e entre em contato com o administrador do sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoResizeColumns();
        }
    }

    static class Constantes
    {
        public const int ULTIMOS_30_DIAS = 0; //Trazer vendas dos últimos 30 dias
        public const int ULTIMOS_2_MESES = 1; //Trazer vendas dos últimos 2 meses
        public const int ULTIMOS_4_MESES = 2; //Trazer vendas dos últimos 4 meses
        public const int ULTIMOS_6_MESES = 3; //Trazer vendas dos últimos 6 meses
        public const int ULTIMOS_12_MESES = 4; //Trazer vendas dos últimos 12 meses
    }
}
