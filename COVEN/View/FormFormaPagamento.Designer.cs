namespace COVEN.View
{
    partial class FormFormaPagamento
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
            this.textBoxValorItem = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelNomeItem = new System.Windows.Forms.Label();
            this.labelNumParcelas = new System.Windows.Forms.Label();
            this.textBoxNumParcelas = new System.Windows.Forms.TextBox();
            this.labelMesAno = new System.Windows.Forms.Label();
            this.maskedTextBoxMesAno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxValorItem
            // 
            this.textBoxValorItem.Location = new System.Drawing.Point(30, 35);
            this.textBoxValorItem.Name = "textBoxValorItem";
            this.textBoxValorItem.Size = new System.Drawing.Size(155, 20);
            this.textBoxValorItem.TabIndex = 1;
            this.textBoxValorItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorItem_KeyPress);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(29, 166);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(110, 166);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelNomeItem
            // 
            this.labelNomeItem.AutoSize = true;
            this.labelNomeItem.Location = new System.Drawing.Point(27, 19);
            this.labelNomeItem.Name = "labelNomeItem";
            this.labelNomeItem.Size = new System.Drawing.Size(77, 13);
            this.labelNomeItem.TabIndex = 0;
            this.labelNomeItem.Text = "labelNomeItem";
            // 
            // labelNumParcelas
            // 
            this.labelNumParcelas.AutoSize = true;
            this.labelNumParcelas.Location = new System.Drawing.Point(27, 63);
            this.labelNumParcelas.Name = "labelNumParcelas";
            this.labelNumParcelas.Size = new System.Drawing.Size(78, 13);
            this.labelNumParcelas.TabIndex = 2;
            this.labelNumParcelas.Text = "N° de Parcelas";
            // 
            // textBoxNumParcelas
            // 
            this.textBoxNumParcelas.Location = new System.Drawing.Point(30, 79);
            this.textBoxNumParcelas.Name = "textBoxNumParcelas";
            this.textBoxNumParcelas.Size = new System.Drawing.Size(155, 20);
            this.textBoxNumParcelas.TabIndex = 3;
            this.textBoxNumParcelas.Text = "0";
            this.textBoxNumParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumParcelas_KeyPress);
            // 
            // labelMesAno
            // 
            this.labelMesAno.AutoSize = true;
            this.labelMesAno.Location = new System.Drawing.Point(28, 111);
            this.labelMesAno.Name = "labelMesAno";
            this.labelMesAno.Size = new System.Drawing.Size(64, 13);
            this.labelMesAno.TabIndex = 4;
            this.labelMesAno.Text = "1° Mês/Ano";
            // 
            // maskedTextBoxMesAno
            // 
            this.maskedTextBoxMesAno.Location = new System.Drawing.Point(31, 127);
            this.maskedTextBoxMesAno.Mask = "00/0000";
            this.maskedTextBoxMesAno.Name = "maskedTextBoxMesAno";
            this.maskedTextBoxMesAno.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBoxMesAno.TabIndex = 5;
            // 
            // FormFormaPagamento
            // 
            this.AcceptButton = this.buttonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 216);
            this.ControlBox = false;
            this.Controls.Add(this.maskedTextBoxMesAno);
            this.Controls.Add(this.labelMesAno);
            this.Controls.Add(this.labelNumParcelas);
            this.Controls.Add(this.textBoxNumParcelas);
            this.Controls.Add(this.labelNomeItem);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxValorItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFormaPagamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valores";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValorItem;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelNomeItem;
        private System.Windows.Forms.Label labelNumParcelas;
        private System.Windows.Forms.TextBox textBoxNumParcelas;
        private System.Windows.Forms.Label labelMesAno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMesAno;
    }
}