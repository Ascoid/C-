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
    public partial class Form1 : Form
    {
        public Thread nt { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //////////////////////////////////////////////////////////////////////////
        private void button3_Click(object sender, EventArgs e)
        {
            //Iniciando a Form4 no button [TICKET RESOLVIDO]
            this.Close();
            nt = new Thread(Form04);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }
        //Chamando o Form4 [TICKET RESOLVIDO]
        private void Form04() {
            Application.Run(new Form4());
        }

        //////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            //Iniciando a Form2 no button [TICKET RESOLVIDO]
            this.Close();
            nt = new Thread(Form02);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Form02()
        {
            Application.Run(new Form2());
        }

        //////////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            //Iniciando a Form3 no button [TICKET RESOLVIDO]
            this.Close();
            nt = new Thread(Form03);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Form03()
        {
            Application.Run(new Form3());
        }

        //////////////////////////////////////////////////////////////////////////
        private void button4_Click(object sender, EventArgs e)
        {
            //Iniciando a Form5 no button [TICKET RESOLVIDO]
            this.Close();
            nt = new Thread(Form05);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Form05()
        {
            Application.Run(new Form5());
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        //////////////////////////////////////////////////////////////////////////
        private void button5_Click(object sender, EventArgs e)
        {
            //Iniciando a Form6 no button [TICKET RESOLVIDO]
            this.Close();
            nt = new Thread(Form06);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Form06()
        {
            Application.Run(new Form6());
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
