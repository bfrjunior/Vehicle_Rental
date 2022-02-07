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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_Cliente_pessoafisica'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_Cliente_pessoafisicaTableAdapter.Fill(this.bDDataSet.Tab_Cliente_pessoafisica);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Tab_Cliente_pessoafisica'. Você pode movê-la ou removê-la conforme necessário.
            this.tab_Cliente_pessoafisicaTableAdapter.Fill(this.bDDataSet.Tab_Cliente_pessoafisica);

        }

        private void tab_Cliente_pessoafisicaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tab_Cliente_pessoafisicaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }
    }
}
