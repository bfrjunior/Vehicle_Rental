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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //altenticando usuario
            if ((textBox1.Text == "ricardo") && (textBox2.Text == "123456"))
            {
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Login ou senha Invalidos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
