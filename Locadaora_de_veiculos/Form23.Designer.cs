namespace Locadaora_de_veiculos
{
    partial class Form23
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            this.bDDataSet = new Locadaora_de_veiculos.BDDataSet();
            this.tab_Cliente_pessoafisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_Cliente_pessoafisicaTableAdapter = new Locadaora_de_veiculos.BDDataSetTableAdapters.Tab_Cliente_pessoafisicaTableAdapter();
            this.tableAdapterManager = new Locadaora_de_veiculos.BDDataSetTableAdapters.TableAdapterManager();
            this.tab_Cliente_pessoafisicaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            idClienteLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Cliente_pessoafisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Cliente_pessoafisicaBindingNavigator)).BeginInit();
            this.tab_Cliente_pessoafisicaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_Cliente_pessoafisicaBindingSource
            // 
            this.tab_Cliente_pessoafisicaBindingSource.DataMember = "Tab_Cliente_pessoafisica";
            this.tab_Cliente_pessoafisicaBindingSource.DataSource = this.bDDataSet;
            // 
            // tab_Cliente_pessoafisicaTableAdapter
            // 
            this.tab_Cliente_pessoafisicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tab__USADOS_motoTableAdapter = null;
            this.tableAdapterManager.Tab_Cliente_pessoafisicaTableAdapter = this.tab_Cliente_pessoafisicaTableAdapter;
            this.tableAdapterManager.Tab_Cliente_pessoajuridicaTableAdapter = null;
            this.tableAdapterManager.Tab_LOCACAO_caminhaoTableAdapter = null;
            this.tableAdapterManager.Tab_LOCACAO_carroTableAdapter = null;
            this.tableAdapterManager.Tab_LOCACAO_motoTableAdapter = null;
            this.tableAdapterManager.Tab_USADOS_caminhaoTableAdapter = null;
            this.tableAdapterManager.Tab_USADOS_carroTableAdapter = null;
            this.tableAdapterManager.Tab_USADOS_LOCACAO_caminhaoTableAdapter = null;
            this.tableAdapterManager.Tab_USADOS_LOCACAO_carroTableAdapter = null;
            this.tableAdapterManager.Tab_USADOS_LOCACAO_motoTableAdapter = null;
            this.tableAdapterManager.Tab_USADOS_motoTableAdapter = null;
            this.tableAdapterManager.Tab_venda_caminhaoTableAdapter = null;
            this.tableAdapterManager.Tab_venda_carroTableAdapter = null;
            this.tableAdapterManager.Tab_venda_motoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Locadaora_de_veiculos.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tab_Cliente_pessoafisicaBindingNavigator
            // 
            this.tab_Cliente_pessoafisicaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.BindingSource = this.tab_Cliente_pessoafisicaBindingSource;
            this.tab_Cliente_pessoafisicaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem});
            this.tab_Cliente_pessoafisicaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tab_Cliente_pessoafisicaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.Name = "tab_Cliente_pessoafisicaBindingNavigator";
            this.tab_Cliente_pessoafisicaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tab_Cliente_pessoafisicaBindingNavigator.Size = new System.Drawing.Size(495, 25);
            this.tab_Cliente_pessoafisicaBindingNavigator.TabIndex = 0;
            this.tab_Cliente_pessoafisicaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(104, 75);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(53, 13);
            idClienteLabel.TabIndex = 1;
            idClienteLabel.Text = "id Cliente:";
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_Cliente_pessoafisicaBindingSource, "idCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(165, 72);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(104, 101);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_Cliente_pessoafisicaBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(165, 98);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(104, 127);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 5;
            cpfLabel.Text = "cpf:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_Cliente_pessoafisicaBindingSource, "cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(165, 124);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfTextBox.TabIndex = 6;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(104, 153);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_Cliente_pessoafisicaBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(165, 150);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(104, 179);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 9;
            bairroLabel.Text = "bairro:";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_Cliente_pessoafisicaBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(165, 176);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(100, 20);
            this.bairroTextBox.TabIndex = 10;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(104, 205);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 11;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_Cliente_pessoafisicaBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(165, 202);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 12;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tab_Cliente_pessoafisicaBindingNavigatorSaveItem
            // 
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tab_Cliente_pessoafisicaBindingNavigatorSaveItem.Image")));
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem.Name = "tab_Cliente_pessoafisicaBindingNavigatorSaveItem";
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tab_Cliente_pessoafisicaBindingNavigatorSaveItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tab_Cliente_pessoafisicaBindingSource;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "idCliente";
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 366);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.tab_Cliente_pessoafisicaBindingNavigator);
            this.Name = "Form23";
            this.Text = "Form23";
            this.Load += new System.EventHandler(this.Form23_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Cliente_pessoafisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Cliente_pessoafisicaBindingNavigator)).EndInit();
            this.tab_Cliente_pessoafisicaBindingNavigator.ResumeLayout(false);
            this.tab_Cliente_pessoafisicaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource tab_Cliente_pessoafisicaBindingSource;
        private BDDataSetTableAdapters.Tab_Cliente_pessoafisicaTableAdapter tab_Cliente_pessoafisicaTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tab_Cliente_pessoafisicaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tab_Cliente_pessoafisicaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}