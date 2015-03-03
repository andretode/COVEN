namespace COVEN.View
{
    partial class FormNovaVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Débitos em Valores",
            "0,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Débitos em Combustível",
            "0,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Aluguel Maquineta Cartão",
            "0,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Créditos em Valores",
            "0,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cartão",
            "R$ 0,00",
            "0",
            "  /",
            "0",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Cheque",
            "R$ 0,00",
            "0",
            "  /",
            "0",
            "--"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dinheiro",
            "R$ 0,00"}, -1);
            this.VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covenDataSet = new COVEN.covenDataSet();
            this.produtosVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxProdutos = new System.Windows.Forms.GroupBox();
            this.buttonRemoverProduto = new System.Windows.Forms.Button();
            this.labelValorTotalVenda = new System.Windows.Forms.Label();
            this.labelValorTotalNF = new System.Windows.Forms.Label();
            this.labelQuantTotalVenda = new System.Windows.Forms.Label();
            this.labelQuantTotalRetorno = new System.Windows.Forms.Label();
            this.labelQuantTotalSaida = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.quantRetorno = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.quantSaida = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantRetorno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValorUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtotalNF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtotalVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxGeralVenda = new System.Windows.Forms.GroupBox();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.tabDebito = new System.Windows.Forms.TabControl();
            this.tabPageDebitos = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTotalDebitos = new System.Windows.Forms.Label();
            this.listViewDebitos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageFormaPagamento = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTotalPagamento = new System.Windows.Forms.Label();
            this.listViewFormaPagamento = new System.Windows.Forms.ListView();
            this.columnFormaPgt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumParc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column1Mes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVlrParc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUltimoMes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotalVenda2 = new System.Windows.Forms.Label();
            this.labelTotalDebitos2 = new System.Windows.Forms.Label();
            this.labelTotalPagamento2 = new System.Windows.Forms.Label();
            this.labelTotalGeral = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonFecharVenda = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedorTableAdapter = new COVEN.covenDataSetTableAdapters.VendedorTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new COVEN.covenDataSetTableAdapters.ProdutoTableAdapter();
            this.vendaTableAdapter = new COVEN.covenDataSetTableAdapters.VendaTableAdapter();
            this.produtosVendaTableAdapter = new COVEN.covenDataSetTableAdapters.ProdutosVendaTableAdapter();
            this.buttonGeraNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendaBindingSource)).BeginInit();
            this.groupBoxProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantRetorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantSaida)).BeginInit();
            this.groupBoxGeralVenda.SuspendLayout();
            this.tabDebito.SuspendLayout();
            this.tabPageDebitos.SuspendLayout();
            this.tabPageFormaPagamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VendaBindingSource
            // 
            this.VendaBindingSource.DataMember = "Venda";
            this.VendaBindingSource.DataSource = this.covenDataSet;
            // 
            // covenDataSet
            // 
            this.covenDataSet.DataSetName = "covenDataSet";
            this.covenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosVendaBindingSource
            // 
            this.produtosVendaBindingSource.DataMember = "ProdutosVenda";
            this.produtosVendaBindingSource.DataSource = this.covenDataSet;
            // 
            // groupBoxProdutos
            // 
            this.groupBoxProdutos.Controls.Add(this.buttonRemoverProduto);
            this.groupBoxProdutos.Controls.Add(this.labelValorTotalVenda);
            this.groupBoxProdutos.Controls.Add(this.labelValorTotalNF);
            this.groupBoxProdutos.Controls.Add(this.labelQuantTotalVenda);
            this.groupBoxProdutos.Controls.Add(this.labelQuantTotalRetorno);
            this.groupBoxProdutos.Controls.Add(this.labelQuantTotalSaida);
            this.groupBoxProdutos.Controls.Add(this.label10);
            this.groupBoxProdutos.Controls.Add(this.label9);
            this.groupBoxProdutos.Controls.Add(this.label8);
            this.groupBoxProdutos.Controls.Add(this.label7);
            this.groupBoxProdutos.Controls.Add(this.label6);
            this.groupBoxProdutos.Controls.Add(this.buttonAdicionar);
            this.groupBoxProdutos.Controls.Add(this.label5);
            this.groupBoxProdutos.Controls.Add(this.quantRetorno);
            this.groupBoxProdutos.Controls.Add(this.label4);
            this.groupBoxProdutos.Controls.Add(this.quantSaida);
            this.groupBoxProdutos.Controls.Add(this.label3);
            this.groupBoxProdutos.Controls.Add(this.textBoxProduto);
            this.groupBoxProdutos.Controls.Add(this.listViewProdutos);
            this.groupBoxProdutos.Location = new System.Drawing.Point(12, 86);
            this.groupBoxProdutos.Name = "groupBoxProdutos";
            this.groupBoxProdutos.Size = new System.Drawing.Size(646, 263);
            this.groupBoxProdutos.TabIndex = 3;
            this.groupBoxProdutos.TabStop = false;
            this.groupBoxProdutos.Text = "Saída de Produtos";
            // 
            // buttonRemoverProduto
            // 
            this.buttonRemoverProduto.Location = new System.Drawing.Point(550, 38);
            this.buttonRemoverProduto.Name = "buttonRemoverProduto";
            this.buttonRemoverProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverProduto.TabIndex = 22;
            this.buttonRemoverProduto.Text = "Remover";
            this.buttonRemoverProduto.UseVisualStyleBackColor = true;
            this.buttonRemoverProduto.Click += new System.EventHandler(this.buttonRemoverProduto_Click);
            // 
            // labelValorTotalVenda
            // 
            this.labelValorTotalVenda.AutoSize = true;
            this.labelValorTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalVenda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelValorTotalVenda.Location = new System.Drawing.Point(554, 248);
            this.labelValorTotalVenda.Name = "labelValorTotalVenda";
            this.labelValorTotalVenda.Size = new System.Drawing.Size(13, 13);
            this.labelValorTotalVenda.TabIndex = 21;
            this.labelValorTotalVenda.Text = "--";
            // 
            // labelValorTotalNF
            // 
            this.labelValorTotalNF.AutoSize = true;
            this.labelValorTotalNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalNF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelValorTotalNF.Location = new System.Drawing.Point(472, 248);
            this.labelValorTotalNF.Name = "labelValorTotalNF";
            this.labelValorTotalNF.Size = new System.Drawing.Size(13, 13);
            this.labelValorTotalNF.TabIndex = 20;
            this.labelValorTotalNF.Text = "--";
            // 
            // labelQuantTotalVenda
            // 
            this.labelQuantTotalVenda.AutoSize = true;
            this.labelQuantTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantTotalVenda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantTotalVenda.Location = new System.Drawing.Point(320, 248);
            this.labelQuantTotalVenda.Name = "labelQuantTotalVenda";
            this.labelQuantTotalVenda.Size = new System.Drawing.Size(13, 13);
            this.labelQuantTotalVenda.TabIndex = 19;
            this.labelQuantTotalVenda.Text = "--";
            // 
            // labelQuantTotalRetorno
            // 
            this.labelQuantTotalRetorno.AutoSize = true;
            this.labelQuantTotalRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantTotalRetorno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantTotalRetorno.Location = new System.Drawing.Point(245, 248);
            this.labelQuantTotalRetorno.Name = "labelQuantTotalRetorno";
            this.labelQuantTotalRetorno.Size = new System.Drawing.Size(13, 13);
            this.labelQuantTotalRetorno.TabIndex = 18;
            this.labelQuantTotalRetorno.Text = "--";
            // 
            // labelQuantTotalSaida
            // 
            this.labelQuantTotalSaida.AutoSize = true;
            this.labelQuantTotalSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantTotalSaida.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelQuantTotalSaida.Location = new System.Drawing.Point(181, 248);
            this.labelQuantTotalSaida.Name = "labelQuantTotalSaida";
            this.labelQuantTotalSaida.Size = new System.Drawing.Size(13, 13);
            this.labelQuantTotalSaida.TabIndex = 17;
            this.labelQuantTotalSaida.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(554, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Valor Total Venda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(472, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valor Total NF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Retorno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Saída";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(469, 38);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 7;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quant. Retorno";
            // 
            // quantRetorno
            // 
            this.quantRetorno.Location = new System.Drawing.Point(395, 40);
            this.quantRetorno.Name = "quantRetorno";
            this.quantRetorno.Size = new System.Drawing.Size(68, 20);
            this.quantRetorno.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quant. Saída";
            // 
            // quantSaida
            // 
            this.quantSaida.Location = new System.Drawing.Point(318, 41);
            this.quantSaida.Name = "quantSaida";
            this.quantSaida.Size = new System.Drawing.Size(68, 20);
            this.quantSaida.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxProduto.Location = new System.Drawing.Point(6, 40);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(306, 20);
            this.textBoxProduto.TabIndex = 4;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.BackColor = System.Drawing.SystemColors.Window;
            this.listViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnProduto,
            this.columnQuantSaida,
            this.columnQuantRetorno,
            this.columnQuantVenda,
            this.columnValorUnit,
            this.columnSubtotalNF,
            this.columnSubtotalVenda});
            this.listViewProdutos.FullRowSelect = true;
            this.listViewProdutos.Location = new System.Drawing.Point(6, 66);
            this.listViewProdutos.MultiSelect = false;
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(639, 166);
            this.listViewProdutos.TabIndex = 8;
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            this.listViewProdutos.View = System.Windows.Forms.View.Details;
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Cód.";
            this.columnCodigo.Width = 35;
            // 
            // columnProduto
            // 
            this.columnProduto.Text = "Produto";
            this.columnProduto.Width = 160;
            // 
            // columnQuantSaida
            // 
            this.columnQuantSaida.Text = "Qt. Saída";
            // 
            // columnQuantRetorno
            // 
            this.columnQuantRetorno.Text = "Qt. Retorno";
            this.columnQuantRetorno.Width = 70;
            // 
            // columnQuantVenda
            // 
            this.columnQuantVenda.Text = "Qt. Venda";
            this.columnQuantVenda.Width = 70;
            // 
            // columnValorUnit
            // 
            this.columnValorUnit.Text = "Vr. Unit.";
            this.columnValorUnit.Width = 70;
            // 
            // columnSubtotalNF
            // 
            this.columnSubtotalNF.Text = "Subtotal NF";
            this.columnSubtotalNF.Width = 80;
            // 
            // columnSubtotalVenda
            // 
            this.columnSubtotalVenda.Text = "Subtotal Venda";
            this.columnSubtotalVenda.Width = 87;
            // 
            // groupBoxGeralVenda
            // 
            this.groupBoxGeralVenda.Controls.Add(this.comboBoxVendedor);
            this.groupBoxGeralVenda.Controls.Add(this.label2);
            this.groupBoxGeralVenda.Controls.Add(this.label1);
            this.groupBoxGeralVenda.Controls.Add(this.maskedTextBoxDataSaida);
            this.groupBoxGeralVenda.Location = new System.Drawing.Point(12, 4);
            this.groupBoxGeralVenda.Name = "groupBoxGeralVenda";
            this.groupBoxGeralVenda.Size = new System.Drawing.Size(651, 76);
            this.groupBoxGeralVenda.TabIndex = 0;
            this.groupBoxGeralVenda.TabStop = false;
            this.groupBoxGeralVenda.Text = "Dados Gerais da Venda";
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxVendedor.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxVendedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(118, 49);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(240, 21);
            this.comboBoxVendedor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do Vendedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data de Saída";
            // 
            // maskedTextBoxDataSaida
            // 
            this.maskedTextBoxDataSaida.Location = new System.Drawing.Point(118, 22);
            this.maskedTextBoxDataSaida.Mask = "00/00/0000";
            this.maskedTextBoxDataSaida.Name = "maskedTextBoxDataSaida";
            this.maskedTextBoxDataSaida.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDataSaida.TabIndex = 1;
            this.maskedTextBoxDataSaida.ValidatingType = typeof(System.DateTime);
            // 
            // tabDebito
            // 
            this.tabDebito.Controls.Add(this.tabPageDebitos);
            this.tabDebito.Controls.Add(this.tabPageFormaPagamento);
            this.tabDebito.Location = new System.Drawing.Point(13, 355);
            this.tabDebito.Name = "tabDebito";
            this.tabDebito.SelectedIndex = 0;
            this.tabDebito.Size = new System.Drawing.Size(462, 145);
            this.tabDebito.TabIndex = 9;
            // 
            // tabPageDebitos
            // 
            this.tabPageDebitos.Controls.Add(this.label13);
            this.tabPageDebitos.Controls.Add(this.labelTotalDebitos);
            this.tabPageDebitos.Controls.Add(this.listViewDebitos);
            this.tabPageDebitos.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebitos.Name = "tabPageDebitos";
            this.tabPageDebitos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebitos.Size = new System.Drawing.Size(454, 119);
            this.tabPageDebitos.TabIndex = 0;
            this.tabPageDebitos.Text = "Débitos/Créditos do Vendedor";
            this.tabPageDebitos.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Total Débito/Crédito";
            // 
            // labelTotalDebitos
            // 
            this.labelTotalDebitos.AutoSize = true;
            this.labelTotalDebitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDebitos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTotalDebitos.Location = new System.Drawing.Point(145, 104);
            this.labelTotalDebitos.Name = "labelTotalDebitos";
            this.labelTotalDebitos.Size = new System.Drawing.Size(13, 13);
            this.labelTotalDebitos.TabIndex = 18;
            this.labelTotalDebitos.Text = "--";
            // 
            // listViewDebitos
            // 
            this.listViewDebitos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDebitos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewDebitos.Location = new System.Drawing.Point(0, 0);
            this.listViewDebitos.MultiSelect = false;
            this.listViewDebitos.Name = "listViewDebitos";
            this.listViewDebitos.Size = new System.Drawing.Size(454, 100);
            this.listViewDebitos.TabIndex = 10;
            this.listViewDebitos.UseCompatibleStateImageBehavior = false;
            this.listViewDebitos.View = System.Windows.Forms.View.Details;
            this.listViewDebitos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDebitos_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Débito/Crédito";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor";
            this.columnHeader2.Width = 84;
            // 
            // tabPageFormaPagamento
            // 
            this.tabPageFormaPagamento.Controls.Add(this.label12);
            this.tabPageFormaPagamento.Controls.Add(this.labelTotalPagamento);
            this.tabPageFormaPagamento.Controls.Add(this.listViewFormaPagamento);
            this.tabPageFormaPagamento.Location = new System.Drawing.Point(4, 22);
            this.tabPageFormaPagamento.Name = "tabPageFormaPagamento";
            this.tabPageFormaPagamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormaPagamento.Size = new System.Drawing.Size(454, 119);
            this.tabPageFormaPagamento.TabIndex = 1;
            this.tabPageFormaPagamento.Text = "Forma de Pagamento";
            this.tabPageFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Total Pagamento";
            // 
            // labelTotalPagamento
            // 
            this.labelTotalPagamento.AutoSize = true;
            this.labelTotalPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPagamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTotalPagamento.Location = new System.Drawing.Point(120, 83);
            this.labelTotalPagamento.Name = "labelTotalPagamento";
            this.labelTotalPagamento.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPagamento.TabIndex = 19;
            this.labelTotalPagamento.Text = "--";
            // 
            // listViewFormaPagamento
            // 
            this.listViewFormaPagamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFormaPgt,
            this.columnValor,
            this.columnNumParc,
            this.column1Mes,
            this.columnVlrParc,
            this.columnUltimoMes});
            this.listViewFormaPagamento.FullRowSelect = true;
            this.listViewFormaPagamento.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listViewFormaPagamento.Location = new System.Drawing.Point(0, 0);
            this.listViewFormaPagamento.MultiSelect = false;
            this.listViewFormaPagamento.Name = "listViewFormaPagamento";
            this.listViewFormaPagamento.Size = new System.Drawing.Size(458, 80);
            this.listViewFormaPagamento.TabIndex = 11;
            this.listViewFormaPagamento.UseCompatibleStateImageBehavior = false;
            this.listViewFormaPagamento.View = System.Windows.Forms.View.Details;
            this.listViewFormaPagamento.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFormaPagamento_MouseDoubleClick);
            // 
            // columnFormaPgt
            // 
            this.columnFormaPgt.Text = "Forma de Pagamento";
            this.columnFormaPgt.Width = 115;
            // 
            // columnValor
            // 
            this.columnValor.Text = "Valor";
            this.columnValor.Width = 69;
            // 
            // columnNumParc
            // 
            this.columnNumParc.Text = "N° Parc.";
            this.columnNumParc.Width = 53;
            // 
            // column1Mes
            // 
            this.column1Mes.Text = "1° Mês/Ano";
            this.column1Mes.Width = 69;
            // 
            // columnVlrParc
            // 
            this.columnVlrParc.Text = "Vlr Parcela";
            this.columnVlrParc.Width = 84;
            // 
            // columnUltimoMes
            // 
            this.columnUltimoMes.Text = "Último Mês";
            this.columnUltimoMes.Width = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalVenda2);
            this.groupBox1.Controls.Add(this.labelTotalDebitos2);
            this.groupBox1.Controls.Add(this.labelTotalPagamento2);
            this.groupBox1.Controls.Add(this.labelTotalGeral);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Location = new System.Drawing.Point(477, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 142);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // labelTotalVenda2
            // 
            this.labelTotalVenda2.AutoSize = true;
            this.labelTotalVenda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVenda2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTotalVenda2.Location = new System.Drawing.Point(126, 25);
            this.labelTotalVenda2.Name = "labelTotalVenda2";
            this.labelTotalVenda2.Size = new System.Drawing.Size(13, 13);
            this.labelTotalVenda2.TabIndex = 14;
            this.labelTotalVenda2.Text = "--";
            // 
            // labelTotalDebitos2
            // 
            this.labelTotalDebitos2.AutoSize = true;
            this.labelTotalDebitos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDebitos2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTotalDebitos2.Location = new System.Drawing.Point(126, 47);
            this.labelTotalDebitos2.Name = "labelTotalDebitos2";
            this.labelTotalDebitos2.Size = new System.Drawing.Size(13, 13);
            this.labelTotalDebitos2.TabIndex = 16;
            this.labelTotalDebitos2.Text = "--";
            // 
            // labelTotalPagamento2
            // 
            this.labelTotalPagamento2.AutoSize = true;
            this.labelTotalPagamento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPagamento2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTotalPagamento2.Location = new System.Drawing.Point(126, 69);
            this.labelTotalPagamento2.Name = "labelTotalPagamento2";
            this.labelTotalPagamento2.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPagamento2.TabIndex = 18;
            this.labelTotalPagamento2.Text = "--";
            // 
            // labelTotalGeral
            // 
            this.labelTotalGeral.AutoSize = true;
            this.labelTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGeral.ForeColor = System.Drawing.Color.Blue;
            this.labelTotalGeral.Location = new System.Drawing.Point(126, 92);
            this.labelTotalGeral.Name = "labelTotalGeral";
            this.labelTotalGeral.Size = new System.Drawing.Size(13, 13);
            this.labelTotalGeral.TabIndex = 20;
            this.labelTotalGeral.Text = "--";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(7, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Falta Para Fechar:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Total Pagamento:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Total Débitos/Créditos:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Total Venda:";
            // 
            // buttonFecharVenda
            // 
            this.buttonFecharVenda.Location = new System.Drawing.Point(13, 506);
            this.buttonFecharVenda.Name = "buttonFecharVenda";
            this.buttonFecharVenda.Size = new System.Drawing.Size(170, 28);
            this.buttonFecharVenda.TabIndex = 21;
            this.buttonFecharVenda.Text = "&Fechar Venda";
            this.buttonFecharVenda.UseVisualStyleBackColor = true;
            this.buttonFecharVenda.Click += new System.EventHandler(this.buttonFecharVenda_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(488, 506);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(170, 28);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.covenDataSet;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.covenDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtosVendaTableAdapter
            // 
            this.produtosVendaTableAdapter.ClearBeforeFill = true;
            // 
            // buttonGeraNota
            // 
            this.buttonGeraNota.Location = new System.Drawing.Point(249, 506);
            this.buttonGeraNota.Name = "buttonGeraNota";
            this.buttonGeraNota.Size = new System.Drawing.Size(170, 28);
            this.buttonGeraNota.TabIndex = 23;
            this.buttonGeraNota.Text = "&Gerar Nota de Venda";
            this.buttonGeraNota.UseVisualStyleBackColor = true;
            this.buttonGeraNota.Click += new System.EventHandler(this.buttonGeraNota_Click);
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(671, 543);
            this.Controls.Add(this.buttonGeraNota);
            this.Controls.Add(this.buttonFecharVenda);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabDebito);
            this.Controls.Add(this.groupBoxGeralVenda);
            this.Controls.Add(this.groupBoxProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNovaVenda";
            this.ShowIcon = false;
            this.Text = "Nova Venda";
            this.Load += new System.EventHandler(this.FormNovaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendaBindingSource)).EndInit();
            this.groupBoxProdutos.ResumeLayout(false);
            this.groupBoxProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantRetorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantSaida)).EndInit();
            this.groupBoxGeralVenda.ResumeLayout(false);
            this.groupBoxGeralVenda.PerformLayout();
            this.tabDebito.ResumeLayout(false);
            this.tabPageDebitos.ResumeLayout(false);
            this.tabPageDebitos.PerformLayout();
            this.tabPageFormaPagamento.ResumeLayout(false);
            this.tabPageFormaPagamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private covenDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quantRetorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quantSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.ListView listViewProdutos;
        private System.Windows.Forms.ColumnHeader columnProduto;
        private System.Windows.Forms.ColumnHeader columnQuantSaida;
        private System.Windows.Forms.ColumnHeader columnQuantRetorno;
        private System.Windows.Forms.ColumnHeader columnQuantVenda;
        private System.Windows.Forms.ColumnHeader columnValorUnit;
        private System.Windows.Forms.ColumnHeader columnSubtotalNF;
        private System.Windows.Forms.ColumnHeader columnSubtotalVenda;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private covenDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxGeralVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataSaida;
        private System.Windows.Forms.Label labelValorTotalVenda;
        private System.Windows.Forms.Label labelValorTotalNF;
        private System.Windows.Forms.Label labelQuantTotalVenda;
        private System.Windows.Forms.Label labelQuantTotalRetorno;
        private System.Windows.Forms.Label labelQuantTotalSaida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabDebito;
        private System.Windows.Forms.TabPage tabPageDebitos;
        private System.Windows.Forms.ListView listViewDebitos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPageFormaPagamento;
        private System.Windows.Forms.ListView listViewFormaPagamento;
        private System.Windows.Forms.ColumnHeader columnFormaPgt;
        private System.Windows.Forms.ColumnHeader columnValor;
        private System.Windows.Forms.ColumnHeader columnNumParc;
        private System.Windows.Forms.ColumnHeader column1Mes;
        private System.Windows.Forms.ColumnHeader columnVlrParc;
        private System.Windows.Forms.ColumnHeader columnUltimoMes;
        internal System.Windows.Forms.Label labelTotalDebitos;
        internal System.Windows.Forms.Label labelTotalPagamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label labelTotalPagamento2;
        internal System.Windows.Forms.Label labelTotalGeral;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label labelTotalDebitos2;
        internal System.Windows.Forms.Label labelTotalVenda2;
        private System.Windows.Forms.Button buttonFecharVenda;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.Button buttonCancelar;
        private covenDataSet covenDataSet;
        private covenDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource produtosVendaBindingSource;
        private covenDataSetTableAdapters.ProdutosVendaTableAdapter produtosVendaTableAdapter;
        private System.Windows.Forms.Button buttonRemoverProduto;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.Button buttonGeraNota;
        private System.Windows.Forms.BindingSource VendaBindingSource;
    }
}