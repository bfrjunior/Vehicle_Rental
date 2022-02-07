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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_Cliente_pessoafisica'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_Cliente_pessoafisicaTableAdapter.Fill(this.bDDataSet.Tab_Cliente_pessoafisica);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet2.Tab_pessoa_FISICA'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_pessoa_FISICATableAdapter.Fill(this.bDDataSet2.Tab_pessoa_FISICA);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_Cliente_pessoafisica'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_Cliente_pessoafisicaTableAdapter.Fill(this.bDDataSet.Tab_Cliente_pessoafisica);

        }
    }
}
