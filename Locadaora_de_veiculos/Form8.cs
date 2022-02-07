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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void tab_LOCACAO_motoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_LOCACAO_motoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_LOCACAO_moto'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_LOCACAO_motoTableAdapter.Fill(this.bDDataSet.Tab_LOCACAO_moto);
           

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
                this.tab_LOCACAO_motoBindingSource.EndEdit();
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
