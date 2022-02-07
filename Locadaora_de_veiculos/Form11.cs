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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void tab__USADOS_motoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab__USADOS_motoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet._Tab__USADOS_moto'. Você pode movê-la ou removê-la conforme necessário.
            this.tab__USADOS_motoTableAdapter.Fill(this.bDDataSet._Tab__USADOS_moto);
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
                this.tab__USADOS_motoBindingSource.EndEdit();
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
