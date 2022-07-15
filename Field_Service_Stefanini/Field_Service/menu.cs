using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Field_Service
{
    public partial class menu : Form
    {
        public menu(String V) // N02 - inicio passando o info
        {
            InitializeComponent();

            lb_namefield.Text = V; //Recebendo a info do V da N02
            lb_namefield.Text = "Field: " + lb_namefield.Text;
        }

        private void F_Veiculos_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void bt_agenda_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(lb_namefield.Text); //N01 - Inicia a abertura do aba
            form1.Show(); //N01 - Abre a aba
            this.Close(); // Fecha a tela em aberto


        }

        private void bt_contato_Click(object sender, EventArgs e)
        {
            contato contatoo = new contato(lb_namefield.Text); //N01 - Inicia a abertura do aba
            contatoo.Show(); //N01 - Abre a aba
            this.Close(); // Fecha a tela em aberto
        }
    }
}
