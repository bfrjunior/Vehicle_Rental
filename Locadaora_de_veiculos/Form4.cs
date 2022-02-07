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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tab_venda_carroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_venda_carroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_venda_carro'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_venda_carroTableAdapter.Fill(this.bDDataSet.Tab_venda_carro);
            
            //LINHA QUE ADICIONA O CADASTRO NO BANCO DE DADOS
            this.tab_venda_carroBindingSource.AddNew();
            //adicionando preenchimento da data
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
                this.tab_venda_carroBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDDataSet);
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Erro: Informe Nome ou Telefone.";
            };
            

            
            //BOTÃO SALVANDO NO BANCO
            //this.Validate();
            //this.tab_venda_carroBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.bDDataSet);
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

