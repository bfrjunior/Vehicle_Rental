namespace Locadaora_de_veiculos
{
    partial class Form12
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
            System.Windows.Forms.Label nomeCompradorLabel;
            System.Windows.Forms.Label nomeVendedorLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label modeloDoCarroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.label1 = new System.Windows.Forms.Label();
            this.bDDataSet = new Locadaora_de_veiculos.BDDataSet();
            this.tab_USADOS_caminhaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_USADOS_caminhaoTableAdapter = new Locadaora_de_veiculos.BDDataSetTableAdapters.Tab_USADOS_caminhaoTableAdapter();
            this.tableAdapterManager = new Locadaora_de_veiculos.BDDataSetTableAdapters.TableAdapterManager();
            this.tab_USADOS_caminhaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.nomeCompradorTextBox = new System.Windows.Forms.TextBox();
            this.nomeVendedorTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.modeloDoCarroTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.fotoCarroPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            idClienteLabel = new System.Windows.Forms.Label();
            nomeCompradorLabel = new System.Windows.Forms.Label();
            nomeVendedorLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            modeloDoCarroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_USADOS_caminhaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_USADOS_caminhaoBindingNavigator)).BeginInit();
            this.tab_USADOS_caminhaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(432, 458);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(53, 13);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "id Cliente:";
            // 
            // nomeCompradorLabel
            // 
            nomeCompradorLabel.AutoSize = true;
            nomeCompradorLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            nomeCompradorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeCompradorLabel.Location = new System.Drawing.Point(19, 111);
            nomeCompradorLabel.Name = "nomeCompradorLabel";
            nomeCompradorLabel.Size = new System.Drawing.Size(156, 16);
            nomeCompradorLabel.TabIndex = 4;
            nomeCompradorLabel.Text = "Nome do Comprador:";
            // 
            // nomeVendedorLabel
            // 
            nomeVendedorLabel.AutoSize = true;
            nomeVendedorLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            nomeVendedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeVendedorLabel.Location = new System.Drawing.Point(19, 137);
            nomeVendedorLabel.Name = "nomeVendedorLabel";
            nomeVendedorLabel.Size = new System.Drawing.Size(147, 16);
            nomeVendedorLabel.TabIndex = 6;
            nomeVendedorLabel.Text = "Nome do Vendedor:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(19, 163);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(74, 16);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(19, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(51, 16);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(19, 215);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(79, 16);
            enderecoLabel.TabIndex = 12;
            enderecoLabel.Text = "Endereço:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(19, 241);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(45, 16);
            dataLabel.TabIndex = 14;
            dataLabel.Text = "Data:";
            // 
            // modeloDoCarroLabel
            // 
            modeloDoCarroLabel.AutoSize = true;
            modeloDoCarroLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            modeloDoCarroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloDoCarroLabel.Location = new System.Drawing.Point(19, 267);
            modeloDoCarroLabel.Name = "modeloDoCarroLabel";
            modeloDoCarroLabel.Size = new System.Drawing.Size(144, 16);
            modeloDoCarroLabel.TabIndex = 16;
            modeloDoCarroLabel.Text = "Modelo Do Veiculo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículos Usados Vendas de Caminhões";
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_USADOS_caminhaoBindingSource
            // 
            this.tab_USADOS_caminhaoBindingSource.DataMember = "Tab_USADOS_caminhao";
            this.tab_USADOS_caminhaoBindingSource.DataSource = this.bDDataSet;
            // 
            // tab_USADOS_caminhaoTableAdapter
            // 
            this.tab_USADOS_caminhaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tab__USADOS_motoTableAdapter = null;
            this.tableAdapterManager.Tab_Cliente_pessoafisicaTableAdapter = null;
            this.tableAdapterManager.Tab_Cliente_pessoajuridicaTableAdapter = null;
            this.tableAdapterManager.Tab_LOCACAO_caminhaoTableAdapter = null;
            this.tableAdapterManager.Tab_LOCACAO_carroTableAdapter = null;
            this.tableAdapterManager.Tab_LOCACAO_motoTableAdapter = null;
            this.tableAdapterManager.Tab_USADOS_caminhaoTableAdapter = this.tab_USADOS_caminhaoTableAdapter;
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
            // tab_USADOS_caminhaoBindingNavigator
            // 
            this.tab_USADOS_caminhaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tab_USADOS_caminhaoBindingNavigator.BindingSource = this.tab_USADOS_caminhaoBindingSource;
            this.tab_USADOS_caminhaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tab_USADOS_caminhaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tab_USADOS_caminhaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.tab_USADOS_caminhaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tab_USADOS_caminhaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tab_USADOS_caminhaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tab_USADOS_caminhaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tab_USADOS_caminhaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tab_USADOS_caminhaoBindingNavigator.Name = "tab_USADOS_caminhaoBindingNavigator";
            this.tab_USADOS_caminhaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tab_USADOS_caminhaoBindingNavigator.Size = new System.Drawing.Size(661, 25);
            this.tab_USADOS_caminhaoBindingNavigator.TabIndex = 1;
            this.tab_USADOS_caminhaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(62, 22);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "idCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(528, 455);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 3;
            // 
            // nomeCompradorTextBox
            // 
            this.nomeCompradorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "nomeComprador", true));
            this.nomeCompradorTextBox.Location = new System.Drawing.Point(190, 111);
            this.nomeCompradorTextBox.Name = "nomeCompradorTextBox";
            this.nomeCompradorTextBox.Size = new System.Drawing.Size(240, 20);
            this.nomeCompradorTextBox.TabIndex = 0;
            // 
            // nomeVendedorTextBox
            // 
            this.nomeVendedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "nomeVendedor", true));
            this.nomeVendedorTextBox.Location = new System.Drawing.Point(190, 137);
            this.nomeVendedorTextBox.Name = "nomeVendedorTextBox";
            this.nomeVendedorTextBox.Size = new System.Drawing.Size(240, 20);
            this.nomeVendedorTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(190, 189);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(240, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(190, 215);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(240, 20);
            this.enderecoTextBox.TabIndex = 4;
            // 
            // modeloDoCarroTextBox
            // 
            this.modeloDoCarroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "ModeloDoCarro", true));
            this.modeloDoCarroTextBox.Location = new System.Drawing.Point(190, 267);
            this.modeloDoCarroTextBox.Name = "modeloDoCarroTextBox";
            this.modeloDoCarroTextBox.Size = new System.Drawing.Size(240, 20);
            this.modeloDoCarroTextBox.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "Telefone", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(190, 164);
            this.maskedTextBox1.Mask = "(99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tab_USADOS_caminhaoBindingSource, "Data", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(190, 236);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // fotoCarroPictureBox
            // 
            this.fotoCarroPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoCarroPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tab_USADOS_caminhaoBindingSource, "FotoCarro", true));
            this.fotoCarroPictureBox.Location = new System.Drawing.Point(476, 98);
            this.fotoCarroPictureBox.Name = "fotoCarroPictureBox";
            this.fotoCarroPictureBox.Size = new System.Drawing.Size(162, 145);
            this.fotoCarroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoCarroPictureBox.TabIndex = 20;
            this.fotoCarroPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(515, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adicionar Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(661, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fotoCarroPictureBox);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(nomeCompradorLabel);
            this.Controls.Add(this.nomeCompradorTextBox);
            this.Controls.Add(nomeVendedorLabel);
            this.Controls.Add(this.nomeVendedorTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(modeloDoCarroLabel);
            this.Controls.Add(this.modeloDoCarroTextBox);
            this.Controls.Add(this.tab_USADOS_caminhaoBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form12";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_USADOS_caminhaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_USADOS_caminhaoBindingNavigator)).EndInit();
            this.tab_USADOS_caminhaoBindingNavigator.ResumeLayout(false);
            this.tab_USADOS_caminhaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCarroPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource tab_USADOS_caminhaoBindingSource;
        private BDDataSetTableAdapters.Tab_USADOS_caminhaoTableAdapter tab_USADOS_caminhaoTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tab_USADOS_caminhaoBindingNavigator;
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
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox nomeCompradorTextBox;
        private System.Windows.Forms.TextBox nomeVendedorTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox modeloDoCarroTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.PictureBox fotoCarroPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}