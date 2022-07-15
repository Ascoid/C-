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
    public partial class Form3 : Form
    {
        public Thread nt { get; private set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nome, chamado, telefone, ramal, tentativas, field;
            nome = textBox1.Text;
            chamado = textBox2.Text;
            ramal = textBox5.Text;
            telefone = textBox6.Text;
            field = textBox7.Text;
            tentativas = textBox3.Text;
            String anexar = $"Bom dia/boa tarde, {nome} \nVisando atender sua solicitação/incidente {chamado}, tentamos contato no ramal: {ramal}, no telefone: {telefone} e Microsoft Teams e não obtivemos sucesso.\n\nCaso você possua alguma informação de contato adicional, por favor, inclua neste ticket para que possamos retornar e atendê-lo o mais rápido possível.\n\nEsta foi a nossa {tentativas}º tentativa de contato.\n\nAtenciosamente,\n{field}\nField Service -Stefanini Group";
            richTextBox1.Text = anexar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Iniciando a Form3 no button [SCRIPT DE ATENDIMENTO DO FIELD SERVICE]
            this.Close();
            nt = new Thread(Form03);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Form03()
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
