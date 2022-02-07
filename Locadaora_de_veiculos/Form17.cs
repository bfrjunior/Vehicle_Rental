using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadaora_de_veiculos
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void tab_Cliente_pessoajuridicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_Cliente_pessoajuridicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_Cliente_pessoajuridica'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_Cliente_pessoajuridicaTableAdapter.Fill(this.bDDataSet.Tab_Cliente_pessoajuridica);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //resposta ao formulario
            if (nomeTextBox.Text != "" && maskedTextBox1.Text != "")
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "Cadastrado com Sucesso!";

                //comando salvar
                this.Validate();
                this.tab_Cliente_pessoajuridicaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDDataSet);
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Erro: Informe Nome ou Telefone.";
            };
        }
    }
}
