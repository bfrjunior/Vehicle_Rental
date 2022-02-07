namespace Locadaora_de_veiculos
{
    partial class Form22
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label idClienteLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabpessoaFISICABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet2 = new Locadaora_de_veiculos.BDDataSet2();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.tab_pessoa_FISICABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.tabpessoaFISICABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_pessoa_FISICATableAdapter = new Locadaora_de_veiculos.BDDataSet2TableAdapters.Tab_pessoa_FISICATableAdapter();
            this.bDDataSet = new Locadaora_de_veiculos.BDDataSet();
            this.tabClientepessoafisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_Cliente_pessoafisicaTableAdapter = new Locadaora_de_veiculos.BDDataSetTableAdapters.Tab_Cliente_pessoafisicaTableAdapter();
            nomeLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabpessoaFISICABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_pessoa_FISICABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpessoaFISICABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabClientepessoafisicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(34, 121);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 16);
            nomeLabel.TabIndex = 21;
            nomeLabel.Text = "Nome:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.Location = new System.Drawing.Point(34, 147);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(41, 16);
            cpfLabel.TabIndex = 23;
            cpfLabel.Text = "CPF:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(34, 173);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(79, 16);
            enderecoLabel.TabIndex = 24;
            enderecoLabel.Text = "Endereço:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.Location = new System.Drawing.Point(34, 199);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(54, 16);
            bairroLabel.TabIndex = 25;
            bairroLabel.Text = "Bairro:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(34, 225);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(74, 16);
            telefoneLabel.TabIndex = 26;
            telefoneLabel.Text = "Telefone:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(308, 386);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(53, 13);
            idClienteLabel.TabIndex = 28;
            idClienteLabel.Text = "id Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.tab_pessoa_FISICABindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "Id";
            // 
            // tabpessoaFISICABindingSource1
            // 
            this.tabpessoaFISICABindingSource1.DataMember = "Tab_pessoa_FISICA";
            this.tabpessoaFISICABindingSource1.DataSource = this.bDDataSet2;
            // 
            // bDDataSet2
            // 
            this.bDDataSet2.DataSetName = "BDDataSet2";
            this.bDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pessoa_FISICABindingSource, "CPF", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(135, 147);
            this.maskedTextBox2.Mask = "000-000-000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 27;
            // 
            // tab_pessoa_FISICABindingSource
            // 
            this.tab_pessoa_FISICABindingSource.DataMember = "Tab_pessoa_FISICA";
            this.tab_pessoa_FISICABindingSource.DataSource = this.bDDataSet2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pessoa_FISICABindingSource, "Telefone", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(135, 227);
            this.maskedTextBox1.Mask = "(99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pessoa_FISICABindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(135, 120);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(226, 20);
            this.nomeTextBox.TabIndex = 17;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pessoa_FISICABindingSource, "Endereço", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(135, 172);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(226, 20);
            this.enderecoTextBox.TabIndex = 18;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pessoa_FISICABindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(135, 198);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(226, 20);
            this.bairroTextBox.TabIndex = 19;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_pessoa_FISICABindingSource, "Id", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(369, 383);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 29;
            // 
            // tab_pessoa_FISICATableAdapter
            // 
            this.tab_pessoa_FISICATableAdapter.ClearBeforeFill = true;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabClientepessoafisicaBindingSource
            // 
            this.tabClientepessoafisicaBindingSource.DataMember = "Tab_Cliente_pessoafisica";
            this.tabClientepessoafisicaBindingSource.DataSource = this.bDDataSet;
            // 
            // tab_Cliente_pessoafisicaTableAdapter
            // 
            this.tab_Cliente_pessoafisicaTableAdapter.ClearBeforeFill = true;
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(447, 365);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form22";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultando Cliente";
            this.Load += new System.EventHandler(this.Form22_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabpessoaFISICABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_pessoa_FISICABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabpessoaFISICABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabClientepessoafisicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.BindingSource tabpessoaFISICABindingSource;
        private BDDataSet2TableAdapters.Tab_pessoa_FISICATableAdapter tab_pessoa_FISICATableAdapter;
        private System.Windows.Forms.BindingSource tab_pessoa_FISICABindingSource;
        private BDDataSet2 bDDataSet2;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource tabClientepessoafisicaBindingSource;
        private BDDataSetTableAdapters.Tab_Cliente_pessoafisicaTableAdapter tab_Cliente_pessoafisicaTableAdapter;
        private System.Windows.Forms.BindingSource tabpessoaFISICABindingSource1;
    }
}