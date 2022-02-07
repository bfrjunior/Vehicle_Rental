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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void tab_USADOS_LOCACAO_carroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_USADOS_LOCACAO_carroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_USADOS_LOCACAO_carro'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_USADOS_LOCACAO_carroTableAdapter.Fill(this.bDDataSet.Tab_USADOS_LOCACAO_carro);
            //ADICIONANDO DATA AUTOMATICA
            maskedTextBox2.Text = DateTime.Now.ToShortDateString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //resposta ao formulario
            if (nomeCompradorTextBox.Text != "" && maskedTextBox1.Text != "")
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "Salvo com Sucesso!";

                //comando salvar
                this.Validate();
                this.tab_USADOS_LOCACAO_carroBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDDataSet);
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Erro: Informe Nome ou Telefone.";
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ADICIONANDO FOTO DO MODELO DO CARRO
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoCarroPictureBox.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
