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
    public partial class Inicio : Form
    {

        public Thread nt { get; private set; }

        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Iniciando a Form4 no button [TICKET RESOLVIDO]
            this.Close();
            nt = new Thread(Form01);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        //Chamando o Form4 [TICKET RESOLVIDO]
        private void Form01()
        {
            Application.Run(new Form1());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string field;
            field = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

