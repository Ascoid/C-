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
    public partial class Form1 : Form
    {
        public Form1(string V)
        {
            InitializeComponent();

            lb_name_feild.Text = V; //Recebendo a info do V da N02
            lb_name_feild.Text = lb_name_feild.Text.Substring(7); // Pega o somente o nome sem field na posiçao 7 [Feild : ]
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_hora.Text = "Hora:" + DateTime.Now.ToString("HH:mm:ss"); // Pega a hora do sistema e colocar na lb_hora 

        }

        private void bt_anexar_Click(object sender, EventArgs e)
        {                                           // O cov_hora pega somente 2 caracteres do lb_hora
            string nome, dia, chamado, field, data, cov_hora = lb_hora.Text.Substring(5, 2);
            int hora = Convert.ToInt32(cov_hora); // coverte o cov_hora para int
           
            // Compara a hora para determinar se e Bom dia ou Boa tarde
            if (hora < 12)
            {
                dia = "Bom dia";
            }
            else
            {
                dia = "Boa tarde";
            }

            nome = tb_usuario.Text;
            chamado = tb_chamado.Text;
            data = dtp_data.Text;
            field = lb_name_feild.Text;
            String anexar = $"{dia}, {nome}\nConforme conversamos, o atendimento da solicitação/incidente do chamado: {chamado}, foi agendado para {data}, e será realizado via Teams, pessoalmente ou Acesso Remoto.\n\nRetornaremos o contato na data combinada. \nImportante: caso não haja contato na data e hora agendadas, haverá atraso no atendimento da sua solicitação.\n \nAtenciosamente,\n{field} \nField Service -Stefanini Group";
            rtb_resultado.Text = anexar;
        }

        private void lb_hora_Click(object sender, EventArgs e)
        {

        }

        private void rtb_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_copiar_Click(object sender, EventArgs e)
        {

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_usuario.Clear();
            tb_chamado.Clear();
            rtb_resultado.Clear();
            tb_usuario.Focus();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            menu menuu = new menu(tb_usuario.Text); //N01 - Inicia a abertura do aba
            menuu.Show(); //N01 - Abre a aba
            this.Close(); // Fecha a tela em aberto
        }
    }
}
