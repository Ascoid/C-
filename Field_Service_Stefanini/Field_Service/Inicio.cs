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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_lista_Click(object sender, EventArgs e)
        {
            if (tb_name_field.Text == "")  //Comparaçao de tem algum testo no campo tb_listadd 
            {
                MessageBox.Show("Digite o nome do Field"); //se nao tiver ele vai abrir um msg solicitando colocar
                tb_name_field.Focus(); //Vai focar no local do arquivo 

                tb_name_field.Focus();
            }
            if (tb_name_field.Text != "") 
            {
                menu menuu = new menu(tb_name_field.Text); //N01 - Inicia a abertura do aba
                menuu.Show(); //N01 - Abre a aba

                // N02 
                // OBs campo tb_listaok.Text esta passando para F_Veiculos [em F_Veiculos tem que ter o public F_Veiculos(String V)]

            }


        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
