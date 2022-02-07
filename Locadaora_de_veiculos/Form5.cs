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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tab_venda_motoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_venda_motoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_venda_moto'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_venda_motoTableAdapter.Fill(this.bDDataSet.Tab_venda_moto);
            //ADICIONANDO DATA AUTOMATICA
            maskedTextBox2.Text = DateTime.Now.ToShortDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //resposta ao formulario
            if (nomeCompradorTextBox.Text != "" && maskedTextBox1.Text != "")
            {
                label3.ForeColor = System.Drawing.Color.Green;
                label3.Text = "Salvo com Sucesso!";

                //comando salvar
                this.Validate();
                this.tab_venda_motoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDDataSet);
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Erro: Informe Nome ou Telefone.";
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ADICIONANDO FOTO DO MODELO DO CARRO
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoDoCarroPictureBox.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
