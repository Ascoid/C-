using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace App001
{
    public partial class Form6 : Form
    {
        private Thread nt;

        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome, problema, field, chave;
            nome = textBox1.Text;
            problema = textBox2.Text;
            field = textBox3.Text;
            chave = textBox4.Text;
            String anexar = $"Bom dia/boa tarde {nome}, Eu sou o tecnico {field} da Stefanini/STIC, Chave {chave}, e estou aqui para verificar um incidente/chamado sobre o {problema}";
            richTextBox1.Text = anexar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Abrindo a Form2 no button [SCRIPT DE ATENDIMENTO DO FIELD SERVICE]
            this.Close();
            nt = new Thread(Form01);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Form01()
        {
            Application.Run(new Form1());
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
