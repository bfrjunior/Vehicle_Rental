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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void tab_pessoa_FISICABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_pessoa_FISICABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet2);

        }

        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet2.Tab_pessoa_FISICA'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_pessoa_FISICATableAdapter.Fill(this.bDDataSet2.Tab_pessoa_FISICA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //resposta ao formulario
            if (nomeTextBox.Text != "" && maskedTextBox1.Text != "")
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "Salvo com Sucesso!";

                //comando salvar
                this.Validate();
                this.tab_pessoa_FISICABindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDDataSet2);
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Erro: Informe Nome ou Telefone.";
            };
        }
    }
}
