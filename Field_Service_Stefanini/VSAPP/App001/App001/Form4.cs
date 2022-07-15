using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App001
{
    public partial class Form4 : Form
    {
        public Thread nt { get; private set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome, chamado, causa, resolucao, teste, validado, field;
            nome = textBox1.Text;
            chamado = textBox2.Text;
            causa = textBox3.Text;
            resolucao = textBox4.Text;
            teste = textBox5.Text;
            validado = textBox6.Text;
            field = textBox7.Text;
            String anexar = $"Bom dia/boa tarde, {nome}\nTemos o prazer de informar que sua solicitação/seu incidente {chamado} foi solucionado.\nCausa / Solicitação: {causa}\nResolução: {resolucao}\nTestes Realizados: {teste}\nValidado por: {validado}\n\nInformamos que o mesmo se encontra com status de resolvido. Caso necessite de um novo atendimento, solicitamos que entre em contato conosco através do Atendente Virtual, Portal de Serviços ou Central de Atendimento.Pedimos que avalie esse atendimento para continuamente melhorarmos nosso atendimento.\n\nAtenciosamente,\n{field}\nField Service -Stefanini Group";
            richTextBox1.Text = anexar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Abrindo a Form1 no button [SCRIPT DE ATENDIMENTO DO FIELD SERVICE]
            this.Close();
            nt = new Thread(Form04);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        //Chamando o Form4 [SCRIPT DE ATENDIMENTO DO FIELD SERVICE]
        private void Form04()
        {
            Application.Run(new Form1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
