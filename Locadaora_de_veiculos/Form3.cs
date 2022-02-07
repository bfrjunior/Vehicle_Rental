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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Veiculos NOVOS vendas carro
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void motosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VEICULOS NOVOS VENDAS MOTO
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void caminhõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VEICULOS NOVOS VENDAS caminhão
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LOCAÇÃO  CARRO
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LOCAÇÃO MOTO
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
        }

        private void caminhãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LOCAÇÃO  CAMINHÃO
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
        }

        private void carrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //VEICULOS USADOS VENDAS CARRO
            Form10 frm10 = new Form10();
            frm10.ShowDialog();
        }

        private void motosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //VEICULOS USADOS VENDAS MOTO
            Form11 frm11 = new Form11();
            frm11.ShowDialog();
        }

        private void caminhõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //VEICULOS USADOS VENDAS CAMINHÃO
            Form12 frm12 = new Form12();
            frm12.ShowDialog();
        }

        private void carrosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //VEICULOS USADOS LOCAÇÃO CARRO
            Form13 frm13 = new Form13();
            frm13.ShowDialog();
        }

        private void motosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //VEICULOS USADOS LOCAÇÃO moto
            Form14 frm14 = new Form14();
            frm14.ShowDialog();
        }

        private void caminhõesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //VEICULOS USADOS LOCAÇÃO Caminhão
            Form15 frm15 = new Form15();
            frm15.ShowDialog();
        }

        private void pessoalFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CLIENTES PESSO FISICA 16
            Form25 frm25 = new Form25();
            frm25.ShowDialog();
        }

        private void pessoaJúridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CLIENTES PESSOA JURIDICA
            Form17 frm17 = new Form17();
            frm17.ShowDialog();
        }

        private void gerVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FUNCIONARIOS GERENTE DE VENDAS
            Form18 frm18 = new Form18();
            frm18.ShowDialog();
        }

        private void gerAlugadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FUNCIONARIOS GERENTE DE LOCADOS
            Form19 frm19 = new Form19();
            frm19.ShowDialog();
        }

        private void vendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VENDEDOR USADOS
            Form20 frm20 = new Form20();
            frm20.ShowDialog();
        }

        private void vendedorAlugadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codigo sair
            //this.close();

            //VENDEDOR LOCADOS
            Form21 frm21 = new Form21();
            frm21.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //data
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
        }

        private void pesquisarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pesquisando clientes
            Form22 frm22 = new Form22();
            frm22.ShowDialog();
        }
    }
}
