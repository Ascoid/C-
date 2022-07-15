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
    public partial class Form5 : Form
    {
        public Thread nt { get; private set; }

        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form05()
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome, chamado, motivo, field;
            nome = textBox1.Text;
            chamado = textBox2.Text;
            motivo = textBox5.Text;
            field = textBox7.Text;
            String anexar = $"Bom dia/boa tarde,\n{nome}\nInformamos que sua solicitação/incidente {chamado}, foi cancelado por {motivo}.\n\nCaso ainda necessite de apoio, solicitamos gentilmente que realize o registro de outro ticket utilizando o Atendente Virtual, Portal de Serviços ou Central de Atendimento.\n\nAtenciosamente,\n{field}\nField Service -Stefanini Group";
            richTextBox1.Text = anexar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox7.Clear();
            richTextBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Abrindo a Form2 no button [SCRIPT DE ATENDIMENTO DO FIELD SERVICE]
            this.Close();
            nt = new Thread(Form05);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
