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
    public partial class Form2 : Form
    {
        public Thread nt { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //Chamando o Form2 [SCRIPT DE ATENDIMENTO DO FIELD SERVICE]
        private void Form02()
        {
            Application.Run(new Form1());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string nome, chamado, field, data;
            nome = textBox1.Text;
            chamado = textBox2.Text;
            data = dateTimePicker1.Text;
            field = textBox7.Text;
            String anexar = $"Bom dia/boa tarde, {nome}\nConforme conversamos, o atendimento da solicitação/incidente do chamado: {chamado}, foi agendado para {data} e será realizado via Teams, pessoalmente ou Acesso Remoto.\n\nRetornaremos o contato na data combinada. \nImportante: caso não haja contato na data e hora agendadas, haverá atraso no atendimento da sua solicitação.\n \nAtenciosamente,\n{field} \nField Service -Stefanini Group";
            richTextBox1.Text = anexar;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
            textBox1.Focus();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Abrindo a Form2 no button [SCRIPT DE ATENDIMENTO DO FIELD SERVICE]
            this.Close();
            nt = new Thread(Form02);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
