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
    public partial class contato : Form
    {
        public contato(string V)
        {
            InitializeComponent();

            lb_name_feild.Text = V; //Recebendo a info do V da N02
            lb_name_feild.Text = lb_name_feild.Text.Substring(7);
        }

        private void contato_Load(object sender, EventArgs e)
        {
            lb_hora.Text = "Hora:" + DateTime.Now.ToString("HH:mm:ss"); // Pega a hora do sistema e colocar na lb_hora 

        }

        private void bt_copiar_Click(object sender, EventArgs e)
        {

        }

        private void tb_resultado_TextChanged(object sender, EventArgs e)
        {


        }

        private void bt_anexar_Click(object sender, EventArgs e)
        {
            string nome, telefone, ramal, tentativas, dia, chamado, field, data, cov_hora = lb_hora.Text.Substring(5, 2);
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
            ramal = tb_ramal.Text;
            telefone = tb_telefone.Text;
            field = lb_name_feild.Text;
            tentativas = tb_tentativas.Text;
            String anexar = $"{dia}, {nome} \nVisando atender sua solicitação/incidente {chamado}, tentamos contato no ramal: {ramal}, no telefone: {telefone} e Microsoft Teams e não obtivemos sucesso.\n\nCaso você possua alguma informação de contato adicional, por favor, inclua neste ticket para que possamos retornar e atendê-lo o mais rápido possível.\n\nEsta foi a nossa {tentativas}º tentativa de contato.\n\nAtenciosamente,\n{field}\nField Service -Stefanini Group";
            rtb_resultado.Text = anexar;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_usuario.Clear();
            tb_chamado.Clear();
            tb_ramal.Clear();
            tb_telefone.Clear();
            tb_tentativas.Clear();
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
